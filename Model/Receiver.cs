using Azure.Messaging.ServiceBus;
using dog_facts_bus.Utils;
using System.Text.Json;
using System.Threading.Tasks;

namespace dog_facts_bus.Model
{
    public class Receiver : ServiceBus
    {
        private ServiceBusProcessor processor;
        public Receiver()
        {
            ConnectionString = base.ConnectionString;
        }

        public async Task ReceiveMessages()
        {
            client = new ServiceBusClient(ConnectionString);
            processor = client.CreateProcessor(queueName, new ServiceBusProcessorOptions());
            processor.ProcessMessageAsync += MessageHandler;
            processor.ProcessErrorAsync += ErrorHandler;
            await processor.StartProcessingAsync();
        }

        private async Task MessageHandler(ProcessMessageEventArgs args)
        {
            string body = args.Message.Body.ToString();
            var result = (DogFacts)JsonSerializer.Deserialize(body, typeof(DogFacts));
            UtilsExcel.CreateExcel(result);
            await args.CompleteMessageAsync(args.Message);
        }

        private Task ErrorHandler(ProcessErrorEventArgs args)
        {
            throw args.Exception;
        }
    }
}
