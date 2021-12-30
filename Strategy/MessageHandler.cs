﻿using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler
    {
        public IMessage Message { get; set; }


        public void Send(string message)
        {
            Message.Send(message);
        }
    }
}