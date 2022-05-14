using Azure.Messaging.ServiceBus;
using System;
using System.Threading.Tasks;

namespace dog_facts_bus.Model
{
    public class Sender : ServiceBus
    {
        private ServiceBusSender sender;
        public Sender()
        {
            ConnectionString = base.ConnectionString;
        }

        public async Task SendMessage(string message)
        {
            client = new ServiceBusClient(ConnectionString);
            sender = client.CreateSender(queueName);
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

            var newMessage = new ServiceBusMessage(message);
            if (messageBatch.TryAddMessage(newMessage) == false)
            {
                throw new Exception("Failed to load message.");
            }

            try
            {
                await sender.SendMessagesAsync(messageBatch);
            }
            finally
            {
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }
        }
    }
}
