using StudentRecordPDC50.ViewModel;
namespace StudentRecordPDC50.View;


public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();
        BindingContext = new UserViewModel();
    }
    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        // Navigate to the main page (replace MainPage with your actual main page name)
        await Navigation.PushAsync(new MainPage());
    }
}