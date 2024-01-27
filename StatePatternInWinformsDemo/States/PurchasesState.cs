namespace StatePatternDemo
{
    internal class PurchasesState : IUIState
    {
        public string Caption => "Purchases";
        public ToolStripLabel _toolStripYearLabel = new ToolStripLabel();
        public ToolStripComboBox _toolStripYearComboBox = new ToolStripComboBox();

        public ToolStripLabel ToolStripYearLabel
        {
            get
            {
                return _toolStripYearLabel;
            }
            set
            {
                _toolStripYearLabel = value;
            }
        }

        public ToolStripComboBox ToolStripYearComboBox
        {
            get
            {
                return _toolStripYearComboBox;
            }
            set
            {
                _toolStripYearComboBox = value;
            }
        }

        public void tscboYear_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateList();
        }

        public void ListEntities()
        {
            _toolStripYearComboBox.SelectedIndexChanged += tscboYear_SelectedIndexChanged;
            _toolStripYearLabel.Visible = true;
            _toolStripYearComboBox.Visible = true;
            UpdateList();
        }

        private void UpdateList()
        {
            string strYear = _toolStripYearComboBox.Text.ToString();
            MessageBox.Show(String.Format("Code to list {0} purchases goes here.", strYear));
        }

        public void Add()
        {
            MessageBox.Show("Code to add a purchase goes here.");
        }

        public void Edit()
        {
            MessageBox.Show("Code to edit a purchase goes here.");
        }

        public void Delete()
        {
            MessageBox.Show("Code to delete a purchase goes here.");
        }

        public void Print()
        {
            string strYear = _toolStripYearComboBox.Text.ToString();
            MessageBox.Show(String.Format("Code to print {0} purchases goes here.", strYear));
        }
    }
}
