using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;


namespace LilDataProject
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
     

        public MainPageViewModel()
        {
            ShowUser1Command = new Command(async () => await Application.Current.MainPage.Navigation.PopAsync());
            ShowUser2Command = new Command(async () => await Application.Current.MainPage.Navigation.PopAsync());

        }

        public Command ShowUser1Command
        {
            get;
        }

        public Command ShowUser2Command
        {
            get;
        }

        string username;
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

        string userage;
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

        string useremail;
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

        string useradress;
        public string UserAdress
        {
            get => useradress;
            set
            {
                if (useradress!= value)
                {
                    useradress= value;
                    var args = new PropertyChangedEventArgs(nameof(UserAdress));

                    PropertyChanged?.Invoke(this, args);
                }
            }
        }

        string userphonenumber;
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

        public event PropertyChangedEventHandler PropertyChanged;
        

    }
}
   
