using CircleConnect.Data;
using StackExchange.Redis;

namespace CircleConnect.Services
{
    public class NotificationListener
    {
        private readonly ISubscriber _subscriber;

        public NotificationListener(RedisManager redisManager)
        {
            _subscriber = redisManager.GetSubscriber();
        }

        public void SubscribeToChannel(string channelName)
        {
            _subscriber.Subscribe(channelName, (ch, msg) =>
            {
                Console.WriteLine(ch + ": " + msg);
            });
        }
    }
}
