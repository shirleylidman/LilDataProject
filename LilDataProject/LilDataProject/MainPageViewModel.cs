using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using LilDataProject.Models;
using Javax.Security.Auth;

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
            _user = data.GetUser(1);
            _user = data.GetUser(2);

            username = _user.Name;
            userage = _user.Age;
            useremail = _user.Email;
            useraddress = _user.Address;
            userphonenumber = _user.PhoneNumber;

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
                }
            }
        }

        public string UserAdress
        {
            get => useraddress;
            set
            {
                if (useraddress!= value)
                {
                    useraddress= value;
                    var args = new PropertyChangedEventArgs(nameof(UserAdress));

                    PropertyChanged?.Invoke(this, args);
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
                }
            }
        }

        

    }

  
}
   
