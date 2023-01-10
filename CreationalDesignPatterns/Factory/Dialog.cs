namespace CreationalDesignPatterns.Factory
{
    public abstract class Dialog
    {
        public abstract void CloseDialog();
        public void Render()
        {
            IButton button = this.CreateButton();

            button.Render();

            button.OnClick(CloseDialog);

        }
        public abstract IButton CreateButton();
    }
}