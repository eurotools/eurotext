using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmCheckExitMarkers : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmCheckExitMarkers()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmCheckExitMarkers_Load(object sender, EventArgs e)
        {
            //Get text file path
            string[] TextGroups = CommonFunctions.ReadTextGroups();
            if (TextGroups != null)
            {
                chkTextGroups.BeginUpdate();
                chkTextGroups.Items.Clear();
                chkTextGroups.Items.AddRange(TextGroups);
                chkTextGroups.EndUpdate();

                lblTotalGroups.Text = "Total: " + TextGroups.Length;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void lbxForReview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string textFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages", lbxForReview.SelectedItem + ".etf");
            if (File.Exists(textFilePath))
            {
                using (FrmMainTextEditor editor = new FrmMainTextEditor(textFilePath))
                {
                    editor.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void btnRun_Click(object sender, EventArgs e)
        {
            TimerForm TmrForm = new TimerForm();
            void work(BackgroundWorker bw, DoWorkEventArgs f)
            {
                string[] filesToInspect = GetEtfFilesToReview(bw);
                string[] result = GetTextsWithoutExitMarkers(filesToInspect, bw);
                lbxForReview.Invoke((MethodInvoker)delegate
                {
                    lbxForReview.BeginUpdate();
                    lbxForReview.Items.Clear();
                    lbxForReview.Items.AddRange(result);
                    lbxForReview.EndUpdate();
                });
            }
            TmrForm.SetWork(work);
            TmrForm.ShowDialog();

            //Inform user
            if (lbxForReview.Items.Count == 0)
            {
                MessageBox.Show("All texts contain a valid exit marker. No blocked texts were found.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Update label
            lblForReviewCount.Text = "Total: " + lbxForReview.Items.Count;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal string[] GetTextsWithoutExitMarkers(string[] filesToInspect, BackgroundWorker bw)
        {
            ConcurrentBag<string> blockedTexts = new ConcurrentBag<string>();

            Regex waitRegex = new Regex(@"<W\s+\d+>", RegexOptions.IgnoreCase);
            Regex questionRegex = new Regex(@"<B\s+\d+>", RegexOptions.IgnoreCase);

            int totalFiles = filesToInspect.Length;
            int processed = 0;
            bw.ReportProgress(0);

            Parallel.For(0, totalFiles, new ParallelOptions { MaxDegreeOfParallelism = Math.Max(2, Environment.ProcessorCount - 1) },
                i =>
                {
                    // Reader independiente por hilo
                    ETXML_Reader reader = new ETXML_Reader();
                    string filePath = filesToInspect[i];

                    EuroText_TextFile fileData = reader.ReadTextFile(filePath);
                    foreach (string text in fileData.Messages.Values)
                    {
                        if (string.IsNullOrWhiteSpace(text))
                        {
                            continue;
                        }

                        if (!text.Contains("<E>") && !waitRegex.IsMatch(text) && !questionRegex.IsMatch(text))
                        {
                            blockedTexts.Add(Path.GetFileNameWithoutExtension(filePath));
                            break;
                        }
                    }

                    // Progreso aproximado (thread-safe)
                    int done = Interlocked.Increment(ref processed);
                    if (bw != null)
                    {
                        int progress = done * 100 / totalFiles;
                        bw.ReportProgress(progress, "Validating exits: " + Path.GetFileNameWithoutExtension(filePath));
                    }
                });

            return blockedTexts.ToArray();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal string[] GetEtfFilesToReview(BackgroundWorker bw)
        {
            bw.ReportProgress(0);

            // Grupos seleccionados por el usuario
            HashSet<string> selectedGroups = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (string item in chkTextGroups.CheckedItems)
            {
                selectedGroups.Add(item);
            }

            //Check files based in user selection
            List<string> filesToReview = new List<string>();
            if (selectedGroups.Count > 0)
            {
                string messagesFilePath = Path.Combine(GlobalVariables.CurrentProject.MessagesDirectory, "Messages");
                string[] etfFiles = Directory.GetFiles(messagesFilePath, "*.etf", SearchOption.TopDirectoryOnly);

                //Search files in the selected groups
                int totalFiles = etfFiles.Length;
                for (int i = 0; i < totalFiles; i++)
                {
                    string filePath = etfFiles[i];
                    string group = ReadGroupFromEtfFast(filePath);
                    if (group != null && selectedGroups.Contains(group))
                    {
                        filesToReview.Add(filePath);
                    }

                    // Report progress
                    int progress = (i + 1) * 100 / totalFiles;
                    bw.ReportProgress(progress, "Checking group: " + group);
                }
            }

            return filesToReview.ToArray();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private string ReadGroupFromEtfFast(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        int open = line.IndexOf("<Group>", StringComparison.OrdinalIgnoreCase);
                        if (open < 0)
                        {
                            continue;
                        }

                        int close = line.IndexOf("</Group>", open, StringComparison.OrdinalIgnoreCase);
                        if (close < 0)
                        {
                            continue;
                        }

                        open += 7; // "<Group>".Length
                        return line.Substring(open, close - open).Trim();
                    }
                }
            }
            catch
            {
                // Archivo ilegible o corrupto: se ignora
            }

            return null;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        // Context menu
        //-------------------------------------------------------------------------------------------------------------------------------
        private void ctxGroupsSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkTextGroups.Items.Count; i++)
            {
                chkTextGroups.SetItemChecked(i, true);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ctxGroupsSelectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkTextGroups.Items.Count; i++)
            {
                chkTextGroups.SetItemChecked(i, false);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ctxGroupsInvertSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkTextGroups.Items.Count; i++)
            {
                bool isChecked = chkTextGroups.GetItemChecked(i);
                chkTextGroups.SetItemChecked(i, !isChecked);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
