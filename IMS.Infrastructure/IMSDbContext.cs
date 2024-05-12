using IMS.Infrastructure.Entity_Configration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure
{
    public class IMSDbContext:DbContext
    {
        public IMSDbContext(DbContextOptions<IMSDbContext>
           dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoreConfigration())
;         }
    }
}
