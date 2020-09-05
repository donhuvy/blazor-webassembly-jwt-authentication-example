using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{

    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
    }

}
