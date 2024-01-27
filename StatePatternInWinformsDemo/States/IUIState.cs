namespace StatePatternDemo
{
    internal interface IUIState
    {
        string Caption { get; }
        ToolStripLabel ToolStripTaxpayerIDLabel { get; set; }
        ToolStripComboBox ToolStripTaxpayerIDComboBox { get; set; }
        ToolStripLabel ToolStripYearLabel { get; set; }
        ToolStripComboBox ToolStripYearComboBox { get; set; }
        ToolStripLabel ToolStripAmendmentNoLabel { get; set; }
        ToolStripComboBox ToolStripAmendmentNoComboBox { get; set; }
        void ListEntities();
        void Add();
        void Edit();
        void Delete();
        void Print();
    }
}