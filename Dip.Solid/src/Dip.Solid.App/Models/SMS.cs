using System;
using Dip.Solid.App.Models.Interfaces;

namespace Dip.Solid.App.Models
{
    public class SMS : IMessage
    {
        public string Number { get; set; }
        public string Message { get; set; }

        public void Send()
        {
            Console.WriteLine("Sending Message: " + this.Message);
        }

        public void Validate()
        {
            Console.WriteLine("Validating...");
        }
    }
}