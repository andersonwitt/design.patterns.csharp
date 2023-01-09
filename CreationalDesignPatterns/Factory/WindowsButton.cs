using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class WindowsButton : IButton
    {
        void render()
        {
            //render windows button
        }

        void onClick(Func function)
        {
            function();
        }

    }
}