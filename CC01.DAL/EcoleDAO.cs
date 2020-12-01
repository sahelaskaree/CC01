using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BO;
using Newtonsoft.Json;
using System.Data; 

namespace CC01.DAL
{
    class EcoleDAO
    {
        public EcoleDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    ecoles = JsonConvert.DeserializeObject<List<Ecole>>(json);
                }
            }
            if (ecoles == null)
            {
                ecoles = new List<Ecole>();
            }
        }

        public void Set(Ecole oldEcole, Ecole newEcole)
        {
            var oldIndex = ecoles.IndexOf(oldEcole);
            var newIndex = ecoles.IndexOf(newEcole);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The school doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This school reference already exists !");
            ecoles[oldIndex] = newEcole;
            Save();
        }

        public void Add(Ecole ecole)
        {
            var index = ecoles.IndexOf(ecole);
            if (index >= 0)
                throw new DuplicateNameException("This school reference already exists !");
            ecoles.Add(ecole);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(ecoles);
                sw.WriteLine(json);
            }
        }

        public void Remove(Ecole ecole)
        {
            ecoles.Remove(ecole);
            Save();
        }

        public IEnumerable<Ecole> Find()
        {
            return new List<Ecole>(ecoles);
        }

        public IEnumerable<Ecole> Find(Func<Ecole, bool> predicate)
        {
            return new List<Ecole>(ecoles.Where(predicate).ToArray());
        }

    }
}
}
