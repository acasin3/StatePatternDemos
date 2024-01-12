using System.Security.Principal;

namespace StatePatternDemo
{
    public partial class Form1 : Form
    {
        private IUIState _currentUIState;
        private IUIState _usersState = new UsersState();
        private IUIState _rolesState = new RolesState();
        private IUIState _salesState = new SalesState();

        public Form1()
        {
            InitializeComponent();
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
            _currentUIState = _salesState;
            ListEntities();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("explorer.exe", "https://icons8.com/");
        }
    }
}