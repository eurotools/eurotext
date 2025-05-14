using System;
using System.ComponentModel;
using System.Windows.Forms;
using static EuroText2.TaskbarProgress;

namespace EuroText2
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class TimerForm : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        private Action<BackgroundWorker, DoWorkEventArgs> workToDo;

        //-------------------------------------------------------------------------------------------------------------------------------
        public TimerForm()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TimerForm_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                if (!IsDisposed && taskbarSupported)
                {
                    SetValue(Handle, 0, ProgressBar_Status.Maximum);
                    SetState(Handle, TaskbarStates.NoProgress);
                }
                backgroundWorker.RunWorkerAsync();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                e.Cancel = true;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void SetWork(Action<BackgroundWorker, DoWorkEventArgs> work)
        {
            workToDo = work;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            workToDo?.Invoke(backgroundWorker, e);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar_Status.Value = e.ProgressPercentage;
            if (e.UserState is string userState && !string.IsNullOrEmpty(userState))
            {
                Text = userState;
            }
            if (!IsDisposed && taskbarSupported)
            {
                SetValue(Handle, e.ProgressPercentage, ProgressBar_Status.Maximum);
                SetState(Handle, TaskbarStates.Normal);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (!IsDisposed && taskbarSupported)
                {
                    SetErrorState();
                }
                MessageBox.Show(e.Error.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void SetErrorState()
        {
            SetState(Handle, TaskbarStates.Error);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void SetPausedState()
        {
            SetState(Handle, TaskbarStates.Paused);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SetState(IntPtr windowHandle, TaskbarStates taskbarState)
        {
            try
            {
                taskbarInstance.SetProgressState(windowHandle, taskbarState);
            }
            catch
            {
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SetValue(IntPtr windowHandle, double progressValue, double progressMax)
        {
            try
            {
                taskbarInstance.SetProgressValue(windowHandle, (ulong)progressValue, (ulong)progressMax);
            }
            catch
            {
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
