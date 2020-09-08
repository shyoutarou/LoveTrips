using System.Threading.Tasks;
using MvvmCross.ViewModels;
using LoveTrips.Core.Services;
using LoveTrips.Core.Model.App;
using MvvmCross.Navigation;
using LoveTrips.Core.Interfaces.Services;
using MvvmCross.Commands;

namespace LoveTrips.Core.ViewModels
{
    public class TipViewModel : BaseViewModel
    {
        private readonly ICalculationService _calculationService;
        private readonly IDialogService _dialogService;

        public TipViewModel(ICalculationService calculationService,
            IMvxNavigationService mvxNavigationService,
            IDialogService dialogService)
            : base(mvxNavigationService)
        {
            _calculationService = calculationService;
            _dialogService = dialogService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            SubTotal = 100;
            Generosity = 10;
            Recalcuate();
        }

        public MvxCommand LogOutCommand
        { get { return new MvxCommand(() => NavigationService.Navigate<LoginViewModel>() ); } }

        public void Init(int parameters)
        {
            
            _dialogService.ShowAlertAsync("No internet available", "Love Trips says...", "OK");
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);

                Recalcuate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);

                Recalcuate();
            }
        }

        private double _tip;
        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        private void Recalcuate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        }
    }
}
