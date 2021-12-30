using Design_Patterns_Assignment.Decorator;
using System;

namespace Design_Patterns_Assignment
{
    public abstract class HTMLGenerator : IText
    {
        IText UserText { get; set; }
        public string TextTag { get; set; }

        public HTMLGenerator(IText userText)
        {
            UserText = userText;
        }

        public string GetText()
        {
            return "<" + TextTag + ">" + UserText.GetText() + "</" + TextTag + ">";
        }
    }
}