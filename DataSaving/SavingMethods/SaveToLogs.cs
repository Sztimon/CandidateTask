using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSaving.Models;
using NLog;

namespace DataSaving.SavingMethods
{
    public class SaveToLogs
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void Save(List<LogDTO> logDTO)
        {
            try
            {
                foreach (var log in logDTO)
                {
                    logger.Info("{0}, {1}", log.Name, log.Surname);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }
}
