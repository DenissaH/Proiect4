using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proiect4.Models
{
    public class Elevi
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public ProfilEnum Profil { get; set; }
        public ClasaEnum Clasa { get; set; }
        public string NumeComplet => $"{Nume} {Prenume}";
    }
    public enum ProfilEnum
    {
        
        Mateinfo,
        StiinteleNaturii,
        StiinteSociale,
        Filologie
    }
    public enum ClasaEnum
    {
        [Display(Name = "Clasa a IX-a")]
        IX,
        [Display(Name = "Clasa a X-a")]
        X,
        [Display(Name = "Clasa a XI-a")]
        XI,
        [Display(Name = "Clasa a XII-a")]
        XII
    }
}
