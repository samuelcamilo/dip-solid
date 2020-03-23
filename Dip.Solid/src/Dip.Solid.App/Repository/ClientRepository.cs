using System;
using Dip.Solid.App.Models;
using Dip.Solid.App.Models.Interfaces;

namespace Dip.Solid.App.Repository
{
    public class ClientRepository : IClientRepository
    {
        public void Add(Client client)
        {
            Console.WriteLine("Client Save!");
        }
    }
}