namespace StatePatternDemo
{
    internal interface IUIState
    {
        string Caption { get; }

        void ListEntities();

        void Add();

        void Edit();

        void Delete();

        void Print();
    }
}