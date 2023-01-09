using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class WindowsDialog : Dialog
    {
        WindowsButton createButton()
        {
            return new WindowsButton();
        }
    }
}