﻿namespace Chess.Providers
{
    using System;

    public class Logger : ILogger
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
