namespace StatePatternDemo
{
    internal class PurchasesState : IUIState
    {
        public string Caption => "Purchases";
        public ToolStripLabel _toolStripYearLabel = new ToolStripLabel();
        public ToolStripComboBox _toolStripYearComboBox = new ToolStripComboBox();
        public ToolStripLabel _toolStripAmendmentNoLabel = new ToolStripLabel();
        public ToolStripComboBox _toolStripAmendmentNoComboBox = new ToolStripComboBox();

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

        public ToolStripLabel ToolStripAmendmentNoLabel
        {
            get
            {
                return _toolStripAmendmentNoLabel;
            }
            set
            {
                _toolStripAmendmentNoLabel = value;
            }
        }

        public ToolStripComboBox ToolStripAmendmentNoComboBox
        {
            get
            {
                return _toolStripAmendmentNoComboBox;
            }
            set
            {
                _toolStripAmendmentNoComboBox = value;
            }
        }

        public void tscboYear_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateList();
        }

        public void tscboAmendmentNo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateList();
        }

        public void ListEntities()
        {
            _toolStripYearComboBox.SelectedIndexChanged += tscboYear_SelectedIndexChanged;
            _toolStripAmendmentNoComboBox.SelectedIndexChanged += tscboAmendmentNo_SelectedIndexChanged;
            _toolStripYearLabel.Visible = true;
            _toolStripYearComboBox.Visible = true;
            _toolStripAmendmentNoLabel.Visible = true;
            _toolStripAmendmentNoComboBox.Visible = true;
            UpdateList();
        }

        private void UpdateList()
        {
            string strYear = _toolStripYearComboBox.Text.ToString();
            string strAmendmentNo = _toolStripAmendmentNoComboBox.Text.ToString();
            MessageBox.Show(String.Format("Code to list {0} purchases amendment {1} goes here.", strYear, strAmendmentNo));
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
