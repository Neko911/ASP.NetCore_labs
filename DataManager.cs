using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13
{
    public class DataManager : IDataManager
    {
        //public string GenerateNumber()
        //{
        //    return “Some data”;
        //}
        List<int> array = new List<int>();
        Random r = new Random();

        public DataManager()
        {
            
            for (int i = 0; i < 100; i++)
            {
                array.Add(r.Next());
            }
        }

        public List<int> GenerateNumber()
        {
            return array;
        }

        public List<int> GenerateNumber(int start, int end)
        {
            return array.GetRange(start, end);
        }

        public int GenerateNumber_Id(int id)
        {
            return array[id];
        }

        public bool GenerateNumber_Post(int value)
        {
            array.Add(value);
            return true;
        }

        public bool GenerateNumber_Put(int id, int value)
        {
            if (id < array.Count)
            {
                array[id] = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GenerateNumber_Delete(int id)
        {
            if (id < array.Count)
            {
                array.RemoveAt(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
