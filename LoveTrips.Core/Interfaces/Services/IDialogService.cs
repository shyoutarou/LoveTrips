using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonText);
    }
}
