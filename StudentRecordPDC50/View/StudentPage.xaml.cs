using StudentRecordPDC50.ViewModel;

namespace StudentRecordPDC50.View
{
    public partial class StudentPage : ContentPage
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        // This method will be called after login to update the StudentPage with the student data
        public void SetStudentData(string idno, string name, string gender, string college, string course, string yearlevel)
        {
            // Set the binding context (StudentViewModel) to pass the data
            var studentViewModel = (StudentViewModel)BindingContext;

            studentViewModel.Idno = idno;
            studentViewModel.Name = name;
            studentViewModel.Gender = gender;
            studentViewModel.College = college;
            studentViewModel.Course = course;
            studentViewModel.Yearlevel = yearlevel;
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Navigate to the main page (replace MainPage with your actual main page name)
            await Navigation.PushAsync(new MainPage());
        }
    }
}