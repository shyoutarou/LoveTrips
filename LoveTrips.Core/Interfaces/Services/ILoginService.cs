using System;
using System.Collections.Generic;
using System.Text;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface ILoginService
    {
        bool IsAuthenticated { get; }

        bool Login();

        bool Login(string userName, string password, string scope);

        bool Login(string userName, string password);
    }
}
