using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserServices
    {
        List<User> Get();
        User? Get(int id);
        User? Get(string name);
        int AddUser(UserForCreateDto userDto);
        UserModel? VerifyCredentials(UserCredentialsDto credentials);
    }
}
