using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Emphasized : HTMLGenerator
    {
        public Emphasized(IText userText) : base(userText)
        {
            TextTag = "em";
        }
    }
}
