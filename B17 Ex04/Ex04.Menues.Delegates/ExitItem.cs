namespace Ex04.Menues.Delegates
{
    class ExitItem : MenuItem
    {
        public ExitItem(SelectedEventHandler i_EventHandler) 
            : base("Exit", 0, i_EventHandler)
        {
        }

        public override void OnSelected() { }
    }
}
