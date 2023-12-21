using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IMatchmakerRepository
    {
        List<Matchmaker> GetAll(string? text = "");
        Matchmaker Get(int id);
        void Delete(int id);
        void Post(Matchmaker matchmaker);
        void put(int id, Matchmaker matchmaker);
    }
}
