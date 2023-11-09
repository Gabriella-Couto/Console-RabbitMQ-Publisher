using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRabbitMQ
{
    public class InactiveClientsProducer
    {
        public IModel? _channel { get; set; }
        public string _message { get; set; }
        public InactiveClientsProducer(IModel? channel, string message)
        {
            _channel = channel;
            _message = message;
        }

        public void SendMessage()
        {
            var encodingMessage = Encoding.UTF8.GetBytes(_message);

            _channel!.BasicPublish(exchange: "",
                        routingKey: "inactive-clients",
                        basicProperties: null,
                        body: encodingMessage);

            Console.WriteLine($"Enviou a mensagem {_message}");
        }
    }
}
