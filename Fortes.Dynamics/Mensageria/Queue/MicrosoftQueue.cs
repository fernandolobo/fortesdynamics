using System.Messaging;

namespace Mensageria.Queue
{
    public class MicrosoftQueue
    {

        public void SendPrivate(string json)
        {
            const string queue_name = @".\private$\dynamics";
            MessageQueue queue;
            if (MessageQueue.Exists(queue_name))
                queue = new MessageQueue(queue_name);
            else
                queue = MessageQueue.Create(queue_name);

            queue.Send(json);
        }

        public string MessageReceiver()
        {
            const string queue_name = @".\private$\dynamics";
            var queue = new MessageQueue(queue_name);
            queue.Formatter = new XmlMessageFormatter(new[] { typeof(string) });
            return queue.Receive().Body.ToString();
        }
    }
}