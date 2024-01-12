using Proiect4.Models;
namespace Proiect4;


public partial class ListProfiPage : ContentPage
{
	public ListProfiPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        listView.ItemsSource = await App.ProfesoriDatabase.GetProfesoriAsync();
    }

    async void OnProfesoriAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfiPage
        {
            BindingContext = new Profesori()
        });
    }

    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ProfiPage
            {
                BindingContext = e.SelectedItem as Profesori
            });
        }

    }
}