namespace EuroTextEditor
{

    public partial class ComboItemData
    {
        private string StrNombre;
        private string IntCodigo;

        public ComboItemData()
        {
            StrNombre = "";
            IntCodigo = 0.ToString();
        }

        public ComboItemData(string Name, string ID)
        {
            StrNombre = Name;
            IntCodigo = ID;
        }

        public string Name
        {
            get
            {
                return StrNombre;
            }

            set
            {
                StrNombre = value;
            }
        }

        public string ItemData
        {
            get
            {
                return IntCodigo;
            }

            set
            {
                IntCodigo = value;
            }
        }

        public override string ToString()
        {
            return StrNombre;
        }
    }

}
