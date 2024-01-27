namespace StatePatternDemo
{
    internal class SalesState : IUIState
    {
        public string Caption => "Sales";
        public ToolStripLabel _toolStripTaxpayerIDLabel = new ToolStripLabel();
        public ToolStripComboBox _toolStripTaxpayerIDComboBox = new ToolStripComboBox();
        public ToolStripLabel _toolStripYearLabel = new ToolStripLabel();
        public ToolStripComboBox _toolStripYearComboBox = new ToolStripComboBox();
        public ToolStripLabel _toolStripAmendmentNoLabel = new ToolStripLabel();
        public ToolStripComboBox _toolStripAmendmentNoComboBox = new ToolStripComboBox();

        public ToolStripLabel ToolStripTaxpayerIDLabel
        {
            get => _toolStripTaxpayerIDLabel;
            set => _toolStripTaxpayerIDLabel = value;
        }

        public ToolStripComboBox ToolStripTaxpayerIDComboBox
        {
            get => _toolStripTaxpayerIDComboBox;
            set => _toolStripTaxpayerIDComboBox = value;
        }

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

        public void tscboTaxpayerID_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateList();
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
            _toolStripTaxpayerIDComboBox.SelectedIndexChanged += tscboTaxpayerID_SelectedIndexChanged;
            _toolStripYearComboBox.SelectedIndexChanged += tscboYear_SelectedIndexChanged;
            _toolStripAmendmentNoComboBox.SelectedIndexChanged += tscboAmendmentNo_SelectedIndexChanged;
            _toolStripTaxpayerIDLabel.Visible = true;
            _toolStripTaxpayerIDComboBox.Visible = true;
            _toolStripYearLabel.Visible = true;
            _toolStripYearComboBox.Visible = true;
            _toolStripAmendmentNoLabel.Visible = true;
            _toolStripAmendmentNoComboBox.Visible = true;
            UpdateList();
        }

        private void UpdateList()
        {
            string strTaxpayer = _toolStripTaxpayerIDComboBox.Text;
            string strYear = _toolStripYearComboBox.Text.ToString();
            string strAmendmentNo = _toolStripAmendmentNoComboBox.Text.ToString();
            MessageBox.Show(String.Format("Code to list {0}'s {1} amendment {2} sales goes here.", strTaxpayer, strYear, strAmendmentNo));
        }

        public void Add()
        {
            MessageBox.Show("Code to add a sale goes here.");
        }

        public void Edit()
        {
            MessageBox.Show("Code to edit a sale goes here.");
        }

        public void Delete()
        {
            MessageBox.Show("Code to delete a sale goes here.");
        }

        public void Print()
        {
            string strYear = _toolStripYearComboBox.Text.ToString();
            MessageBox.Show(String.Format("Code to print {0} sales goes here.", strYear));
        }
    }
}
