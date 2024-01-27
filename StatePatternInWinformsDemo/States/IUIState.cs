namespace StatePatternDemo
{
    internal interface IUIState
    {
        string Caption { get; }

        ToolStripLabel ToolStripYearLabel { get; set; }
        ToolStripComboBox ToolStripYearComboBox { get; set; }
        void ListEntities();

        void Add();

        void Edit();

        void Delete();

        void Print();
    }
}