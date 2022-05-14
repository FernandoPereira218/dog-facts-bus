using Azure.Messaging.ServiceBus;

namespace dog_facts_bus.Model
{
    public abstract class ServiceBus
    {
        public string ConnectionString { get; set; }
        protected string queueName = "message-queue";
        protected ServiceBusClient client;
        public ServiceBus()
        {
            ConnectionString = "Endpoint=sb://fernando-218.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=C1jE0wQEMORp3Y8wF8+6b+u7X8IokmzVk09U0jNIllQ=";
            client = new ServiceBusClient(ConnectionString);
        }
    }
}
