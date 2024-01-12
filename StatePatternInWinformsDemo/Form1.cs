using System.Security.Principal;

namespace StatePatternDemo
{
    public partial class Form1 : Form
    {
        private enum DemoModule
        {
            Users,
            Roles
        }

        private DemoModule _demoMod = DemoModule.Users;

        public Form1()
        {
            InitializeComponent();
            ListEntities();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            AddEntity();
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            EditEntity();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            DeleteEntity();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            PrintEntity();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _demoMod = DemoModule.Users;
            ListEntities();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _demoMod = DemoModule.Roles;
            ListEntities();
        }

        private void ListEntities()
        {
            switch (_demoMod)
            {
                case DemoModule.Users:
                    this.Text = "Users";
                    MessageBox.Show("Code to list users goes here.");
                    break;
                case DemoModule.Roles:
                    this.Text = "Roles";
                    MessageBox.Show("Code to list roles goes here.");
                    break;

            }
        }

        private void AddEntity()
        {
            switch (_demoMod)
            {
                case DemoModule.Users:
                    MessageBox.Show("Code to add a user goes here.");
                    break;
                case DemoModule.Roles:
                    MessageBox.Show("Code to add a role goes here.");
                    break;
            }
        }

        private void EditEntity()
        {
            switch (_demoMod)
            {
                case DemoModule.Users:
                    MessageBox.Show("Code to edit a user goes here.");
                    break;
                case DemoModule.Roles:
                    MessageBox.Show("Code to edit a role goes here.");
                    break;
            }
        }

        private void DeleteEntity()
        {
            switch (_demoMod)
            {
                case DemoModule.Users:
                    MessageBox.Show("Code to delete a user goes here.");
                    break;
                case DemoModule.Roles:
                    MessageBox.Show("Code to delete a role goes here.");
                    break;
            }
        }

        private void PrintEntity()
        {
            switch (_demoMod)
            {
                case DemoModule.Users:
                    MessageBox.Show("Code to print list of users goes here.");
                    break;
                case DemoModule.Roles:
                    MessageBox.Show("Code to print list of roles goes here.");
                    break;
            }
        }
    }
}