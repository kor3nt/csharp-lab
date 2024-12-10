using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Messenger<T> where T : IMessage
    {
        public T Message { get; set; }
        public void Send()
        {
            Console.WriteLine($"Sending {Message.GetType()}: {Message.Content}.");
        }
    }
}
