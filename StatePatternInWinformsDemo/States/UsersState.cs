namespace StatePatternDemo
{
    internal class UsersState : IUIState
    {
        public string Caption => "Users";

        public void ListEntities()
        {
            MessageBox.Show("Code to list users goes here.");
        }

        public void Add()
        {
            MessageBox.Show("Code to add a user goes here.");
        }

        public void Edit()
        {
            MessageBox.Show("Code to edit a user goes here.");
        }

        public void Delete()
        {
            MessageBox.Show("Code to delete a user goes here.");
        }

        public void Print()
        {
            MessageBox.Show("Code to print list of users goes here.");
        }
    }
}
