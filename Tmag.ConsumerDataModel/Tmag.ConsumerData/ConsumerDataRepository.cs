using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Tmag.Common;
using Tmag.Common.Repositories;
using Tmag.Identity;

namespace Tmag.ConsumerData
{
    public class ConsumerDataRepository : Repository
    {
        //private ILogger _logger;

        public ConsumerDataRepository()
        {

        }

        public ConsumerDataRepository(IOptions<ConnectionStrings> settings, 
            IUserIdResolver userIdResolver, 
            ILoggerFactory loggerFactory) : base(settings,loggerFactory)
        {
            ConnectionString = settings.Value.MainDb;
            DbContext = new Context(ConnectionString);
            UserId = userIdResolver.Resolve();
            
        }

        public override void ReloadContext()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
                DbContext = new Context(ConnectionString);
            }
        }
    }
}
