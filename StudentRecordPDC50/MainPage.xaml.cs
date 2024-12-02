using StudentRecordPDC50.Services; // Make sure to import the necessary namespace
using System.Net.Http.Json;
using StudentRecordPDC50.Model;
using StudentRecordPDC50.View;

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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Input Error", "Please enter both username and password.", "OK");
                return;
            }
            // Admin credentials
            const string adminUsername = "admin";
            const string adminPassword = "password123";

            // Check if credentials match Admin
            if (username == adminUsername && password == adminPassword)
            {
                await Shell.Current.GoToAsync("//UserPage");
                return;
            }

            //New Function
            try
            {
                // Call the LoginAsync method from the UserService to send login credentials to the server
                var loginResponse = await _userService.LoginAsync(username, password);

                // Check if login was successful
                if (loginResponse?.Message == "Login successful")
                {
                    // Get the student data from the login response
                    var user = loginResponse.User;

                    // Redirect to the StudentPage and pass the student data
                    var studentPage = new StudentPage();

                    // Set the student data to be displayed
                    studentPage.SetStudentData(user.Idno, user.Name, user.Gender, user.College, user.Course, user.Yearlevel);

                    await Navigation.PushAsync(studentPage);
                }
                else
                {
                    // Show error message if login fails
                    await DisplayAlert("Login Failed", loginResponse?.Message ?? "Unknown error", "OK");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (network issues, etc.)
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }
    }
}