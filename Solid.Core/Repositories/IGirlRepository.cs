using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IGirlRepository
    {

        List<Girl> GetAll(string? text = "");
        Girl Get(int id);
        void Delete(int id);
        void Post(Girl girl);
        void put(int id, Girl girl);
    }
}
