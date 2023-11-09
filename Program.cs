using ConsoleAppRabbitMQ;
using RabbitMQ.Client;

var factory = new ConnectionFactory { HostName = "localhost" };

var connection = factory.CreateConnection();

var channel = connection.CreateModel();

channel.QueueDeclare(queue: "active-clients",
                    durable:false,
                    exclusive:false,
                    autoDelete: false,
                    arguments: null);

channel.QueueDeclare(queue: "inactive-clients",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

var activeClientsProducer = new ActiveClientsProducer(channel, "Leila Camargo");
activeClientsProducer.SendMessage();

var inactiveProducer = new InactiveClientsProducer(channel, "Denise Ferreira");
inactiveProducer.SendMessage();
