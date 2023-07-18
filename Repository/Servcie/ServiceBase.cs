using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Servcie
{
    public class ServiceBase<T> where T : class
    {
        DbSet<T> _dbSet;
        PetShop2023DBContext _context;
        public ServiceBase()
        {
            _context = new PetShop2023DBContext();
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public bool Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Remove(T entity)
        {
           
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            
            
        }
        public bool Update(T entity)
        {

            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
            return true;

        }
        public List<T> SearchByKeyword(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }
    }

}
