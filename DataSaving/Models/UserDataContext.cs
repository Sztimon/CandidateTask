using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace DataSaving.Models
{
    public class UserDataContext : DbContext
    {
        public DbSet<LogDTO> Logs { get; set; }

        public UserDataContext()
            : base("DefaultConnection")
        {
        }
    }
}