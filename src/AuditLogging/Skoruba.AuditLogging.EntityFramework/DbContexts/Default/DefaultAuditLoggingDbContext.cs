using Microsoft.EntityFrameworkCore;
using Skoruba.AuditLogging.EntityFramework.Entities;

namespace Skoruba.AuditLogging.EntityFramework.DbContexts.Default
{
    public class DefaultAuditLoggingDbContext : AuditLoggingDbContext<AuditLog>
    {
        public DefaultAuditLoggingDbContext(DbContextOptions<AuditLoggingDbContext<AuditLog>> dbContextOptions) 
            : base(dbContextOptions)
        {

        }
    }
}