namespace Ex04.Menues.Delegates
{
    public class BackItem : MenuItem
    {
        public BackItem(/*SelectedEventHandler i_EventHandler*/) 
            : base("Back", 0/*, i_EventHandler*/)
        {
        }

        public override void OnSelected() { }
    }
}
