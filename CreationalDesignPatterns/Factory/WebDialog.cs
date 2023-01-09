using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class WebDialog : Dialog
    {
        HTMLButton createButton()
        {
            return new HTMLButton();
        }
    }
}