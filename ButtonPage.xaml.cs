using Proiect4.Models;
namespace Proiect4;

public partial class ButtonPage : ContentPage
{ 
    public ButtonPage()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Elevi)BindingContext;
        await App.EleviDatabase.SaveEleviAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
            var slist = (Elevi)BindingContext;
            await App.EleviDatabase.DeleteEleviAsync(slist);
            await Navigation.PopAsync();
     
    }
}