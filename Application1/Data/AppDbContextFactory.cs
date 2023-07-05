using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.Data
{
    public class AppDbContextFactory : IDbContextFactory<AppDbContext>
    {
        public AppDbContext Create()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Application;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            return new AppDbContext(connectionString);
        }
    }
}
