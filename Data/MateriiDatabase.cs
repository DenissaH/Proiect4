using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect4.Models;

namespace Proiect4.Data
{
    public class MateriiDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public MateriiDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Materii>().Wait();
        }
        public Task<List<Materii>> GetProfesoriAsync()
        {
            return _database.Table<Materii>().ToListAsync();
        }
        public Task<Materii> GetMateriiAsync(int id)
        {
            return _database.Table<Materii>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveMateriiAsync(Materii slist)
        {
            if (slist.Id != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }

        public Task<int> DeleteMateriiAsync(Materii slist)
        {
            return _database.DeleteAsync(slist);
        }


        internal Task SaveMateriiListAsync(Materii slist)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteMateriiListAsync(Materii slist)
        {
            throw new NotImplementedException();
        }
    }
}
