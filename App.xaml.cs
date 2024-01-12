using System;
using Proiect4.Data;
using System.IO;

namespace Proiect4;

public partial class App : Application
{
    static EleviDatabase elevidatabase;
    static ProfesoriDatabase profidatabase;
    static MateriiDatabase materiidatabase;

    public static EleviDatabase EleviDatabase
    {
        get
        {
            if (elevidatabase == null)
            {
                elevidatabase = new EleviDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Elevi.db3"));
            }
            return elevidatabase;
        }
    }
    public static ProfesoriDatabase ProfesoriDatabase
    {
        get
        {
            if (profidatabase == null)
            {
                profidatabase = new ProfesoriDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Profi.db3"));
            }
            return profidatabase;
        }
    }
    public static MateriiDatabase MateriiDatabase
    {
        get
        {
            if (materiidatabase == null)
            {
                materiidatabase = new MateriiDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Materii.db3"));
            }
            return materiidatabase;
        }
    }

    public App()
	{
		InitializeComponent();
        
        MainPage = new AppShell();
	}
}
