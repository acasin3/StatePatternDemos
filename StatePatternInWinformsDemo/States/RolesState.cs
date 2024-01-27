namespace StatePatternDemo
{
    internal class RolesState : IUIState
    {
        public string Caption => "Roles";
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
            get => _toolStripAmendmentNoLabel;
            set => _toolStripAmendmentNoLabel = value;
        }

        public ToolStripComboBox ToolStripAmendmentNoComboBox
        {
            get => _toolStripAmendmentNoComboBox;
            set => _toolStripAmendmentNoComboBox = value;
        }

        public void ListEntities()
        {
            _toolStripYearLabel.Visible = false;
            _toolStripYearComboBox.Visible = false;
            _toolStripAmendmentNoLabel.Visible = false;
            _toolStripAmendmentNoComboBox.Visible = false;
            MessageBox.Show("Code to list roles goes here.");
        }

        public void Add()
        {
            MessageBox.Show("Code to add a role goes here.");
        }

        public void Edit()
        {
            MessageBox.Show("Code to edit a role goes here.");
        }

        public void Delete()
        {
            MessageBox.Show("Code to delete a role goes here.");
        }

        public void Print()
        {
            MessageBox.Show("Code to print list of roles goes here.");
        }
    }
}
