namespace StatePatternDemo
{
    internal class RolesState : IUIState
    {
        public string Caption => "Roles";

        public void ListEntities()
        {
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
