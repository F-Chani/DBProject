using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Models;
using Solid.Core.Repositories;

namespace Solid.Data
{
    public class GirlRepository : IGirlRepository
    {
        private readonly DataContext _context;
        public GirlRepository(DataContext context)
        {
            _context = context; 
        }
        public void Delete(int id)
        {
            _context.girls.Remove(_context.girls.ToList().Find(x => x.Id == id));
        }

        public Girl Get(int id)
        {
            return _context.girls.Where(x => x.Id == id).First();
        }

        public List<Girl> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _context.girls.Where(u => u.Name.Contains(text)).ToList();
        }

        public void Post(Girl girl)
        {
            _context.girls.Add(girl);
        }

        public void put(int id, Girl girl)
        {
            int index = _context.girls.ToList().FindIndex(x => x.Id == id);
            _context.girls.ToList()[index] = girl;
        }
    }
}
