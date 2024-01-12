using Proiect4.Models;
namespace Proiect4;

public partial class ListEleviPage : ContentPage
{
	public ListEleviPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.EleviDatabase.GetEleviAsync();
    }

    async void OnEleviAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ButtonPage
        {
            BindingContext = new Elevi()
        });
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ButtonPage
            {
                BindingContext = e.SelectedItem as Elevi
            });
        }
    }

}