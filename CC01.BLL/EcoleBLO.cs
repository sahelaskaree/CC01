using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.DAL;

namespace CC01.BLL
{
    public class EcoleBLO
    {
        EcoleDAO ecoleRepo;
        public EcoleBLO(string dbFolder)
        {
            ecoleRepo = new EcoleDAO(dbFolder);
        }
        public void CreateEcole(Ecole ecole)
        {
            ecoleRepo.Add(ecole);
        }

        public void DeleteProduct(Ecole ecole)
        {
            ecoleRepo.Remove(ecole);
        }


        public IEnumerable<Ecole> GetAllProducts()
        {
            return ecoleRepo.Find();
        }


        public IEnumerable<Ecole> GetByPostalCode(string postalCode)
        {
            return ecoleRepo.Find(x => x.PostalCode == postalCode);
        }

        public IEnumerable<Ecole> GetBy(Func<Ecole, bool> predicate)
        {
            return ecoleRepo.Find(predicate);
        }

        public void EditEcole(Ecole oldEcole, Ecole newEcole)
        {
            ecoleRepo.Set(oldEcole, newEcole);
        }
    }
}
}
