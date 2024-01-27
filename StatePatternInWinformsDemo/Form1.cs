using System.Security.Principal;
using static System.Windows.Forms.AxHost;

namespace StatePatternDemo
{
    public partial class Form1 : Form
    {
        private IUIState _currentUIState;
        private IUIState _usersState = new UsersState();
        private IUIState _rolesState = new RolesState();
        private IUIState _salesState = new SalesState();
        private IUIState _purchasesState = new PurchasesState();

        public Form1()
        {
            InitializeComponent();
            tscboYear.SelectedIndex = 0;

            _usersState.ToolStripYearLabel = this.tslblYear;
            _usersState.ToolStripYearComboBox = this.tscboYear;
            _rolesState.ToolStripYearLabel = this.tslblYear;
            _rolesState.ToolStripYearComboBox = this.tscboYear;
            _salesState.ToolStripYearLabel = this.tslblYear;
            _salesState.ToolStripYearComboBox = this.tscboYear;
            _purchasesState.ToolStripYearLabel = this.tslblYear;
            _purchasesState.ToolStripYearComboBox = this.tscboYear;

            _currentUIState = _usersState;
            ListEntities();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            _currentUIState.Add();
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            _currentUIState.Edit();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            _currentUIState.Delete();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            _currentUIState.Print();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentUIState = _usersState;
            ListEntities();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentUIState = _rolesState;
            ListEntities();
        }

        private void ListEntities()
        {
            this.Text = _currentUIState.Caption;
            _currentUIState.ListEntities();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnsubscribeFromUIEvents();
            _currentUIState = _salesState;
            ListEntities();
        }
        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnsubscribeFromUIEvents();
            _currentUIState = _purchasesState;
            ListEntities();
        }

        private void UnsubscribeFromUIEvents()
        {
            // Remove the event handler before switching state
            if (_currentUIState is SalesState)
            {
                tscboYear.SelectedIndexChanged -= ((SalesState)_currentUIState).tscboYear_SelectedIndexChanged;
            }
            else if (_currentUIState is PurchasesState)
            {
                tscboYear.SelectedIndexChanged -= ((PurchasesState)_currentUIState).tscboYear_SelectedIndexChanged;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("explorer.exe", "https://icons8.com/");
        }
    }
}