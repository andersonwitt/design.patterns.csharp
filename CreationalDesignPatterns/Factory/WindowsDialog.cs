namespace CreationalDesignPatterns.Factory
{
    public class WindowsDialog : Dialog
    {
        public override void CloseDialog()
        {
            Console.WriteLine("Windows dialog was closed.");
        }

        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}