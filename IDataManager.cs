using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13
{
    public interface IDataManager
    {
        //string GenerateNumber();
        List<int> GenerateNumber();

        List<int> GenerateNumber(int start, int end);

        int GenerateNumber_Id(int id);

        bool GenerateNumber_Post(int id);

        bool GenerateNumber_Put(int id, int value);

        bool GenerateNumber_Delete(int id);
    }
}
