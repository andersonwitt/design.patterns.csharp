using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            //render windows button
            Console.WriteLine("Windows button was rendered.");
        }

        public void OnClick(Action function)
        {
            Console.WriteLine("Windows button was clicked.");
            function();
        }

    }
}