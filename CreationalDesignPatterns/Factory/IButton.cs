using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public interface IButton
    {
        public void Render();
        public void OnClick(Action function);
    }
}