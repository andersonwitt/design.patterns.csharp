namespace CreationalDesignPatterns.Factory
{
    public class WebDialog : Dialog
    {
        public override void CloseDialog()
        {
            Console.WriteLine("Web dialog was closed.");
        }

        public override IButton CreateButton()
        {
            return new HTMLButton();
        }
    }
}