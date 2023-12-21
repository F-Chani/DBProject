using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class MatchmakerRepository : IMatchmakerRepository
    {
        private readonly DataContext _context;

        public MatchmakerRepository(DataContext context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
           _context.matchmakers.Remove(_context.matchmakers.ToList().Find(x => x.Id == id));
        }

        public Matchmaker Get(int id)
        {
            return _context.matchmakers.Where(x => x.Id == id).First();
        }

        public List<Matchmaker> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _context.matchmakers.Where(u => u.Name.Contains(text)).ToList();
        }

        public void Post(Matchmaker matchmaker)
        {
            _context.matchmakers.Add(matchmaker);
        }

        public void put(int id, Matchmaker matchmaker)
        {
            int index = _context.matchmakers.ToList().FindIndex(x => x.Id == id);
            _context.matchmakers.ToList()[index] = matchmaker;
        }
    }
}
