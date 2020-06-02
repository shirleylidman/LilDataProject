using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using LilDataProject.Models;
using Javax.Security.Auth;
using Xamarin.Essentials;
using Android.Locations;

namespace LilDataProject
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        LilDataProject.Models.IData data = new UserData();
        private LilDataProject.User _user;
        private string username;
        private string userage;
        private string useremail;
        private string useraddress;
        private string userphonenumber;
        

        public MainPageViewModel()
        {

            NotesCollection = new ObservableCollection<User>();

            ShowUser1Command = new Command(() =>
            {

                var userinfo = new User
                {
                    Name = UserName,
                    Email = UserEmail,
                    Age = UserAge,
                    Address = UserAddress,
                    PhoneNumber = UserPhoneNumber
                };

                NotesCollection.Add(userinfo);
                username = string.Empty;

                ///_user = data.GetUser(1);

                ///username = _user.Name;
                ///userage = _user.Age;
                ///useremail = _user.Email;
                ///useraddress = _user.Address;
                ///userphonenumber = _user.PhoneNumber;
            },
            () => !string.IsNullOrEmpty(UserName, UserEmail, UserAge, UserAddress, UserPhoneNumber));

        }

        public Command ShowUser1Command
        {
            get;
        }


        public ObservableCollection<User> NotesCollection
        {
            get;
        }


        public string UserName
        {
            get => username;
            set
            {
                if (username != value)
                {
                    username = value;
                    var args = new PropertyChangedEventArgs(nameof(UserName));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserAge
        {
            get => userage;
            set
            {
                if (userage != value)
                {
                    userage = value;
                    var args = new PropertyChangedEventArgs(nameof(UserAge));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserEmail
        {
            get => useremail;
            set
            {
                if (useremail!= value)
                {
                    useremail= value;
                    var args = new PropertyChangedEventArgs(nameof(UserEmail));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserAddress
        {
            get => useraddress;
            set
            {
                if (useraddress!= value)
                {
                    useraddress= value;
                    var args = new PropertyChangedEventArgs(nameof(UserAddress));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        public string UserPhoneNumber
        {
            get => userphonenumber;
            set
            {
                if (userphonenumber!= value)
                {
                    userphonenumber = value;
                    var args = new PropertyChangedEventArgs(nameof(UserPhoneNumber));

                    PropertyChanged?.Invoke(this, args);
                    ShowUser1Command.ChangeCanExecute();
                }
            }
        }

        

    }

  
}
   
