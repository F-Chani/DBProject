using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class GuyRepository : IGuyRepository
    {
        private readonly DataContext _context;
        public GuyRepository(DataContext context)
        {
            _context = context; 
        }
        public void Delete(int id)
        {
            _context.guys.Remove(_context.guys.ToList().Find(x => x.Id == id));
        }
        public Guy Get(int id)
        {
            return _context.guys.Where(x => x.Id == id).First();
        }
        public List<Guy> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _context.guys.Where(u => u.Name.Contains(text)).ToList();
        }
        public void Post(Guy guy)
        {
            _context.guys.Add(guy);
        }

        public void put(int id, Guy guy)
        {
            int index = _context.guys.ToList().FindIndex(x => x.Id == id);
            _context.guys.ToList()[index] = guy;
        }
    }
}

