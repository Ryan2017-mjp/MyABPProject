using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPProject.EntityFrameworkCore
{
    public static class ABPProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
