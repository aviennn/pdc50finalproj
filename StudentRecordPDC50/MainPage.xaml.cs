using StudentRecordPDC50.Services; // Make sure to import the necessary namespace

namespace StudentRecordPDC50
{
    public partial class MainPage : ContentPage
    {
        private readonly UserService _userService; // Declare the _userService field

        public MainPage()
        {
            InitializeComponent();
            _userService = new UserService(); // Initialize the _userService
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text?.Trim();
            string password = PasswordEntry.Text?.Trim();

            // Admin credentials
            const string adminUsername = "admin";
            const string adminPassword = "password123";

            // Check if credentials match Admin
            if (username == adminUsername && password == adminPassword)
            {
                await Shell.Current.GoToAsync("//UserPage");
                return;
            }


            // Show error for invalid credentials
            await DisplayAlert("Login Failed", "Invalid credentials. Please try again.", "OK");
        }
    }
}
