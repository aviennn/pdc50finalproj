﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRecordPDC50.Model;
using StudentRecordPDC50.Services;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace StudentRecordPDC50.ViewModel
{
    public class UserViewModel : BindableObject
    {
        private readonly UserService _userService;
        public ObservableCollection<User> Users { get; set; }
        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
                UpdateEntryField();
            }
        }

        private string _idnoInput;
        public string IdnoInput
        {
            get => _idnoInput;
            set
            {
                _idnoInput = value;
                OnPropertyChanged();
            }
        }

        private string _nameInput;
        public string NameInput
        {
            get => _nameInput;
            set
            {
                _nameInput = value;
                OnPropertyChanged();
            }
        }

        private string _genderInput;
        public string GenderInput
        {
            get => _genderInput;
            set
            {
                _genderInput = value;
                OnPropertyChanged();
            }
        }

        private string _collegeInput;
        public string CollegeInput
        {
            get => _collegeInput;
            set
            {
                _collegeInput = value;
                OnPropertyChanged();
            }
        }

        private string _courseInput;
        public string CourseInput
        {
            get => _courseInput;
            set
            {
                _courseInput = value;
                OnPropertyChanged();
            }
        }

        private string _yearlevelInput;
        public string YearlevelInput
        {
            get => _yearlevelInput;
            set
            {
                _yearlevelInput = value;
                OnPropertyChanged();
            }
        }

        private string _passwordInput;
        public string PasswordInput
        {
            get => _passwordInput;
            set
            {
                _passwordInput = value;
                OnPropertyChanged();
            }
        }

        private void ClearInput()
        {
            IdnoInput = string.Empty;
            NameInput = string.Empty;
            GenderInput = string.Empty;
            CollegeInput = string.Empty;
            CourseInput = string.Empty;
            YearlevelInput = string.Empty;
            PasswordInput = string.Empty;
        }
        public UserViewModel()
        {
            _userService = new UserService();
            Users = new ObservableCollection<User>();
            LoadUserCommand = new Command(async () => await LoadUsers());
            AddUserCommand = new Command(async () => await AddUser());
            DeleteUserCommand = new Command(async () => await DeleteUser());
            UpdateUserCommand = new Command(async () => await UpdateUser());
        }

        public ICommand LoadUserCommand { get; }
        public ICommand AddUserCommand { get; }
        public ICommand DeleteUserCommand { get; }
        public ICommand UpdateUserCommand { get; }


        private async Task LoadUsers()
        {
            var users = await _userService.GetUsersAsync();
            Users.Clear();
            foreach (var user in users)
            {
                Users.Add(user);
            }
        }

        private async Task AddUser()
        {
            if (!string.IsNullOrWhiteSpace(NameInput) && !string.IsNullOrWhiteSpace(GenderInput) &&
                !string.IsNullOrWhiteSpace(CollegeInput) && !string.IsNullOrWhiteSpace(CourseInput) &&
                !string.IsNullOrWhiteSpace(YearlevelInput))
            {
                var newUser = new User
                {
                    Name = NameInput,
                    Gender = GenderInput,
                    College = CollegeInput,
                    Course = CourseInput,
                    Yearlevel = YearlevelInput,
                };
                var result = await _userService.AddUserAsync(newUser);

                if (result.Equals("Success", StringComparison.OrdinalIgnoreCase))
                {
                    await LoadUsers();
                    ClearInput();
                }
            }
        }


        private async Task DeleteUser()
        {
            if (SelectedUser != null)
            {
                var result = await _userService.DeleteUserAsync(SelectedUser.ID);
                await LoadUsers();
            }
        }

        public async Task UpdateUser()
        {
            if (SelectedUser != null)
            {
                SelectedUser.Idno = IdnoInput;
                SelectedUser.Name = NameInput;
                SelectedUser.Gender = GenderInput;
                SelectedUser.College = CollegeInput;
                SelectedUser.Course = CourseInput;
                SelectedUser.Yearlevel = YearlevelInput;
                SelectedUser.Password = PasswordInput;

                var result = await _userService.UpdateUserAsync(SelectedUser);
                await LoadUsers();
            }
        }

        private void UpdateEntryField()
        {
            if (SelectedUser != null)
            {
                IdnoInput = SelectedUser.Idno;
                NameInput = SelectedUser.Name;
                GenderInput = SelectedUser.Gender;
                CollegeInput = SelectedUser.College;
                CourseInput = SelectedUser.Course;
                YearlevelInput = SelectedUser.Yearlevel;
                PasswordInput = SelectedUser.Password;
            }
            else
            {
                ClearInput();
            }

        }
    }
}