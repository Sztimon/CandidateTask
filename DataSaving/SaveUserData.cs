using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSaving.Models;
using AutoMapper;
using DataSaving.SavingMethods;

namespace DataSaving
{
    public class SaveUserData
    {
        private SaveToDB SaveDataToDB = new SaveToDB();
        private SaveToXml SaveDataToXml = new SaveToXml();
        private SaveToLogs SaveDataToLogs = new SaveToLogs();

        public SaveUserData()
        {
        }

        public void SaveData(List<UserData> listOfUsers)
        {
            if (listOfUsers != null)
            {
                var logDTO = Mapper.Map<List<LogDTO>>(listOfUsers);

                Parallel.Invoke(
                    () => SaveDataToDB.Save(logDTO),
                    () => SaveDataToLogs.Save(logDTO),
                    () => SaveDataToXml.Save(logDTO)
                    );
            }
        }
    }
}
