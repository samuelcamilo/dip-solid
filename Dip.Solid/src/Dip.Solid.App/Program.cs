using System;
using Dip.Solid.App.Models;
using Dip.Solid.App.Models.Interfaces;
using Dip.Solid.App.Repository;
using Dip.Solid.App.Services;
using SimpleInjector;

namespace Dip.Solid.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrap.Start();
            var clientService = Bootstrap.Container.GetInstance<IClientService>();
            clientService.SendMessageAndSaveClient();
        }
    }

    internal class Bootstrap
    {
        public static Container Container;

        public static void Start()
        {
            // Create container...
            Container = new Container();

            // Registre DI...
            Container.Register<IMessage, Email>(Lifestyle.Singleton);
            Container.Register<IClientRepository, ClientRepository>(Lifestyle.Transient);
            Container.Register<IClientService, ClientService>(Lifestyle.Transient);

            // Verifies and diagnoses this Container instance...
            Container.Verify();
        }
    }
}
