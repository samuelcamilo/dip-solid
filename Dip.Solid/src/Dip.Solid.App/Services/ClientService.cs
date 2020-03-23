using Dip.Solid.App.Models;
using Dip.Solid.App.Models.Interfaces;

namespace Dip.Solid.App.Services
{
    public class ClientService : IClientService
    {
        private readonly IMessage _message;
        private readonly IClientRepository _repository;

        public ClientService(IMessage message, IClientRepository repository)
        {
            this._message = message;
            this._repository = repository;
        }
        public void SendMessageAndSaveClient()
        {
            var client = new Client();
            _repository.Add(client);
            _message.Send();
        }
    }
}