using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IGuyRepository
    {
        List<Guy> GetAll(string? text = "");
        Guy Get(int id);
        void Delete(int id);
        void Post(Guy guy);
        void put(int id, Guy guy);
    }
}
