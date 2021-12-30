using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    class DataRepository
    {
        public string GetData(string data)
        {
            return SimulatedDatabase.Load(data);
        }
        public void SaveData(string data)
        {
            SimulatedDatabase.Save(data);
        }
    }
}
