using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MoneyMart.EntityFrameworkCore
{
    public static class MoneyMartDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MoneyMartDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MoneyMartDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
