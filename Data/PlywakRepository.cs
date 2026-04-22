using Domain;
using S3_Lab5.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class PlywakRepository : IPlywacyRepository
    {
        private readonly BDZawodnicy db;

        public PlywakRepository(BDZawodnicy context)
        {
            db = context;
        }

        public void Dodaj(Plywak plywak)
        {
            db.Plywacy.Add(plywak);
            db.SaveChanges();
        }

        public void Edytuj(Plywak plywak)
        {
            db.Plywacy.Update(plywak);
            db.SaveChanges();
        }

        public Plywak PobierzPoId(int id)
        {
            return db.Plywacy.Find(id);
        }

        public IEnumerable<Plywak> PobierzWszystkich()
        {
            return db.Plywacy.ToList();
        }

        public void Usun(int id)
        {
            var plywak = db.Plywacy.Find(id);
            if (plywak != null)
            {
                db.Plywacy.Remove(plywak);
                db.SaveChanges();
            }
        }
    }
}