using BlazorApp.Models;
using System.Threading.Tasks;

namespace BlazorApp.Services
{

    public interface IAuthenticationService
    {
        User User { get; }
        Task Initialize();
        Task Login(string username, string password);
        Task Logout();
    }

}
