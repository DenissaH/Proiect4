using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect4.Models;
using System.Collections;

namespace Proiect4.Data
{
    public class ProfesoriDatabase
    {
        
        readonly SQLiteAsyncConnection _database;
        public ProfesoriDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Profesori>().Wait();
        }
        public Task<List<Profesori>> GetProfesoriAsync()
        {
            return _database.Table<Profesori>().ToListAsync();
        }
        public Task<Profesori> GetProfesoriAsync(int id)
        {
            return _database.Table<Profesori>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveProfesoriAsync(Profesori slist)
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

        public Task<int> DeleteProfesoriAsync(Profesori slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
