using System.Messaging;

namespace Mensageria.Queue
{
    public class MSMQ
    {
        
        public static void SendPrivate(string json)
        {
            const string queue_name = @".\private$\dynamics";
            MessageQueue queue;
            if (MessageQueue.Exists(queue_name))
                queue = new MessageQueue(queue_name);
            else
                queue = MessageQueue.Create(queue_name);

            queue.Send(json);
        }

    }
}