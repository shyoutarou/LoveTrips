using LoveTrips.Core.Interfaces.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace LoveTrips.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ILoginService _loginService;

        public LoginViewModel(ILoginService loginService, 
            IMvxNavigationService mvxNavigationService) : base(mvxNavigationService)
        {
            _loginService = loginService;

            Username = "TestUser";
            Password = "YouCantSeeMe";
            IsLoading = false;
        }

        public MvxCommand LogInCommand
        { get { return new MvxCommand(() => NavigationService.Navigate<TipViewModel>()); } }

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                SetProperty(ref _username, value);
                RaisePropertyChanged(() => Username);
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                SetProperty(ref _password, value);
                RaisePropertyChanged(() => Password);
            }
        }

        private bool _isLoading;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }

            set
            {
                SetProperty(ref _isLoading, value);
            }
        }

        private IMvxCommand _loginCommand;
        public virtual IMvxCommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new MvxCommand(AttemptLogin, CanExecuteLogin);
                return _loginCommand;
            }
        }

        private void AttemptLogin()
        {
            if (_loginService.Login(Username, Password))
            {
                NavigationService.Navigate<MainViewModel>();
            }
            else
            {
                //DialogService.ShowAlertAsync("We were unable to log you in!", "Login Failed", "OK");
            }
        }

        private bool CanExecuteLogin()
        {
            return (!string.IsNullOrEmpty(Username) || !string.IsNullOrWhiteSpace(Username))
                   && (!string.IsNullOrEmpty(Password) || !string.IsNullOrWhiteSpace(Password));
        }
    }
}
