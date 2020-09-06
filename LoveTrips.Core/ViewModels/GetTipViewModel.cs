using LoveTrips.Core.Model;
using LoveTrips.Core.Services;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace LoveTrips.Core.ViewModels
{
    public class GetTipViewModel : MvxViewModel
    {
        private readonly ITipService _tipDataService;

        public GetTipViewModel(ITipService tipService)
        {
            _tipDataService = tipService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            _subTotal = 100;
            _generosity = 10;
            Recalcuate();
        }

        double _subTotal;

        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalcuate();
            }
        }

        int _generosity;

        public int Generosity
        {
            get { return _generosity; }
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalcuate();
            }
        }

        double _tip;

        public double Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        void Recalcuate()
        {
            Tip tip = new Tip() { subTotal = SubTotal, generosity = Generosity };
            Tip = _tipDataService.NormalTipAmount(tip);
        }

    }
}
