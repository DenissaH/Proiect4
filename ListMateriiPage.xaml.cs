using Proiect4.Models;
namespace Proiect4;

public partial class ListMateriiPage : ContentPage
{
	public ListMateriiPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.MateriiDatabase.GetProfesoriAsync();
    }

    async void OnMateriiAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MateriiPage
        {
            BindingContext = new Materii()
        });
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new MateriiPage
            {
                BindingContext = e.SelectedItem as Materii
            });
        }
    }
}