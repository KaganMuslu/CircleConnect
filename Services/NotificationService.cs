using CircleConnect.Data;
using StackExchange.Redis;

namespace CircleConnect.Services
{
    public class NotificationService
    {
        private readonly ISubscriber _subscriber;

        public NotificationService(RedisManager redisManager)
        {
            _subscriber = redisManager.GetSubscriber();
        }

        public void PublishNotification(string channel, string message)
        {
            _subscriber.Publish(channel, message);
        }
    }
}
