using System.Threading.Tasks;
using MvvmCross.ViewModels;
using LoveTrips.Core.Services;
using LoveTrips.Core.Model.App;
using MvvmCross.Navigation;
using LoveTrips.Core.Interfaces.Services;

namespace LoveTrips.Core.ViewModels
{
    public class TipViewModel : BaseViewModel
    {
        private readonly ICalculationService _calculationService;

        public TipViewModel(ICalculationService calculationService,
            IMvxNavigationService mvxNavigationService)
            : base(mvxNavigationService)
        {
            _calculationService = calculationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            SubTotal = 100;
            Generosity = 10;
            Recalcuate();
        }


        public void Init(int parameters)
        {
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
