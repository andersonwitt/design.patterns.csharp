namespace CreationalDesignPatterns.Factory
{
    public class ApplicationInitializer
    {
        public Dialog? Dialog { get; set; }
        public ApplicationInitializer(string os)
        {
            this.Initialize(os);
        }

        void Initialize(string os)
        {
            if (os.ToLower() == "windows")
            {
                Dialog = new WindowsDialog();
                return;
            }

            if (os.ToLower() == "web")
            {
                Dialog = new WebDialog();
                return;
            }

            throw new Exception("Error! Unknown operating system.");
        }
    }
}