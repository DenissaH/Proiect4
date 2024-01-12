using System;
using SQLite;
using System.Diagnostics;
using Proiect4.Models;

namespace Proiect4;

public partial class ProfiPage : ContentPage
{
	public ProfiPage()
	{
		InitializeComponent();
        BindingContext = new Profesori();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Profesori)BindingContext;
        await App.ProfesoriDatabase.SaveProfesoriAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Profesori)BindingContext;
        await App.ProfesoriDatabase.DeleteProfesoriAsync(slist);
        await Navigation.PopAsync();
    }
}