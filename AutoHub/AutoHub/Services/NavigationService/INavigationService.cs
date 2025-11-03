using System;
using System.Collections.Generic;
namespace AutoHub.Services.NavigationService
{
    public interface INavigationService
    {
        Task GoToLoginAsync();
        Task GoToRegisterAsync();
        Task GoToForgotPasswordAsync();
        Task GoToCatalogAsync();
        Task GoBackAsync();

    }
}
