namespace StatePatternDemo
{
    internal class SalesState : IUIState
    {
        public string Caption => "Sales";

        public void ListEntities()
        {
            MessageBox.Show("Code to list sales goes here.");
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
            MessageBox.Show("Code to print list of sales goes here.");
        }
    }
}
