using Proiect4.Models;
namespace Proiect4;

public partial class MateriiPage : ContentPage
{
	public MateriiPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Materii)BindingContext;
        await App.MateriiDatabase.SaveMateriiAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Materii)BindingContext;
        await App.MateriiDatabase.DeleteMateriiAsync(slist);
        await Navigation.PopAsync();
    }
}