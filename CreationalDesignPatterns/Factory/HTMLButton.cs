using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class HTMLButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("HTML button was rendered.");
        }

        public void OnClick(Action function)
        {
            Console.WriteLine("HTML button was clicked.");
            function();
        }
    }
}