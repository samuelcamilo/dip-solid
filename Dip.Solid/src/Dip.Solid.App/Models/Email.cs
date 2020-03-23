
using System;
using Dip.Solid.App.Models.Interfaces;

namespace Dip.Solid.App.Models
{
    public class Email : IMessage
    {
        public string Mail { get; set; }
        public string Message { get; set; }
        
        public void Send()
        {
            Console.WriteLine("Sending Message");
        }

        public void Validate()
        {
            Console.WriteLine("Validating...");
        }
    }
}