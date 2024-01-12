using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect4.Models;
//using CloudKit;

namespace Proiect4.Data
{
    public class EleviDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public EleviDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Elevi>().Wait(); // Asigură-te că tabela Elevi este creată
        }

        public Task<List<Elevi>> GetEleviAsync()
        {
            return _database.Table<Elevi>().ToListAsync();
        }

        public Task<Elevi> GetEleviAsync(int id)
        {
            return _database.Table<Elevi>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveEleviAsync(Elevi slist)
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
        public async Task<int> DeleteEleviAsync(Elevi elevi)
        {
            if (elevi.Id != 0)
            {
                return await _database.DeleteAsync(elevi);
            }
            else
            {
                // Tratați cazul în care obiectul Elevi nu are o cheie primară validă
                // În acest caz, puteți arunca o excepție, afișa un mesaj de eroare sau
                // gestionați în alt mod situația.
                return -1; // Sau orice alt cod care semnalează o problemă la ștergere.
            }
        }
        internal Task SaveEleviiListAsync(Profesori slist)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteEleviListAsync(Profesori slist)
        {
            throw new NotImplementedException();
        }
        internal async Task<IEnumerable<Elevi>> GetEleviDatabaseAsync()
        {
            try
            {
                // implementați codul pentru a obține lista de elevi
                return await _database.Table<Elevi>().ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare în timpul obținerii listei de elevi: {ex.Message}");
                return Enumerable.Empty<Elevi>();
            }
        }
        public Task<List<Elevi>> GetEleviByClasaAsync(ClasaEnum clasa)
        {
            return _database.Table<Elevi>().Where(e => e.Clasa == clasa).ToListAsync();
        }

    }
}
