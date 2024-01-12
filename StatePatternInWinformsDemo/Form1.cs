using System.Security.Principal;

namespace StatePatternDemo
{
    public partial class Form1 : Form
    {
        private IUIState _currentUIState;
        private IUIState _usersState = new UsersState();
        private IUIState _rolesState = new RolesState();

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
    }
}