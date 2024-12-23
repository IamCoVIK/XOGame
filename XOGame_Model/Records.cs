using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOGame_Model
{
    public class Records
    {
        Settings Settings;
        public List<(string name, string points)> records;

        public Records(Settings settings)
        {
            Settings = settings;
            GetRecords(Settings.GetRecords());
        }

        private void GetRecords(string[] file)
        {
            foreach (string line in file)
            {
                string[] parts = line.Split('|');
                records.Add((parts[0], parts[1]));
            }
        }
    }
}
