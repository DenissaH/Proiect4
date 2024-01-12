using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proiect4.Models
{
    public class Materii
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Nume { get; set; }
        public string Clasa { get; set; }
        public string Descriere { get; set; }
    }
}
