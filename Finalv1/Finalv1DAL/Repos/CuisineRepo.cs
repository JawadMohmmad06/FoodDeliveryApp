using Finalv1DAL.Interfaces;
using Finalv1DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalv1DAL.Repos
{
    internal class CuisineRepo : Repo, IRepo<Cuisine, int, bool>
    {
        public bool Create(Cuisine type)
        {
            db.Cuisines.Add(type);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var excui = Get(id);
            db.Cuisines.Remove(excui);
            return db.SaveChanges() > 0;
        }

        public List<Cuisine> Get()
        {
            return db.Cuisines.ToList(); ;
        }

        public Cuisine Get(int id)
        {
            return db.Cuisines.Find(id);
        }

        public bool Update(Cuisine type)
        {
            var excui = Get(type.Id);
            db.Entry(excui).CurrentValues.SetValues(excui);
            return db.SaveChanges() > 0;
        }
    }
}
