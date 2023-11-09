# Console-RabbitMQ-Publisher
Simple console application done in C#, using .NET 6, Docker and consuming RabbitMQ to publish messages.

To run this application is necessary to have Docker Desktop in your computer. Then, you go to prompt command and type: docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.9-management![image](https://github.com/Gabriella-Couto/Console-RabbitMQ-Publisher/assets/40771985/24d0466d-547a-4cc9-a1c4-ac2df20a5c26)

After that, is just to check your Docker Desktop Containers and access the port that is running the RabbitMQ and type the default credentials.


