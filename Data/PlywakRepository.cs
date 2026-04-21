using Domain;
using S3_Lab5.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class PlywakRepository : IPlywacyRepository
    {
        private BDZawodnicy db = new BDZawodnicy();

        void IPlywacyRepository.Dodaj(Plywak plywak)
        {
            throw new NotImplementedException();
        }

        void IPlywacyRepository.Edytuj(Plywak plywak)
        {
            throw new NotImplementedException();
        }

        Plywak IPlywacyRepository.PobierzPoId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Plywak> IPlywacyRepository.PobierzWszystkich()
        {
            return db.Plywacy.ToList();
        }

        void IPlywacyRepository.Usun(int id)
        {
            throw new NotImplementedException();
        }
    }
}
