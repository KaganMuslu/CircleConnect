using StackExchange.Redis;

namespace CircleConnect.Data
{
    public class RedisManager
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisManager(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        public ISubscriber GetSubscriber()
        {
            return _connectionMultiplexer.GetSubscriber();
        }
    }
}
