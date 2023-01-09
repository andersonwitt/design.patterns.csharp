using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class Application
    {
        public Dialog Dialog { get; set; }

        void initialize(string os)
        {
            if (os == "Windows")
            {
                Dialog = new WindowsDialog();
                return;
            }

            if (os == "Web")
            {
                Dialog = new WebDialog();
                return;
            }

            throw new Exception("Error! Unknown operating system.");
        }

        public static void Main(string[] args)
        {
            this.initialize();

            Dialog.render();
        }
    }
}