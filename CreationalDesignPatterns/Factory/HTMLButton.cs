using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class HTMLButton : IButton
    {
        void render()
        {
            //render HTMLButton
        }

        void onClick(Func function)
        {
            function();
        }
    }
}