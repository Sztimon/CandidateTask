using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSaving.Models;

namespace DataSaving.SavingMethods
{
    public class SaveToDB
    {
        private UserDataContext _context;

        public SaveToDB() {
            _context = new UserDataContext();
        }

        public void Save(List<LogDTO> logDTO) {

            _context.Set<LogDTO>().AddRange(logDTO);
            _context.ChangeTracker.DetectChanges();
            _context.SaveChanges();

        }


    }
}
