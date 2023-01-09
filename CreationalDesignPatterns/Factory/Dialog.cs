using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public abstract class Dialog
    {
        void closeDialog();
        void render()
        {
            IButton button = this.createButton();

            button.onClick(closeDialog);

            button.render();
        }
        abstract createButton();
    }
}