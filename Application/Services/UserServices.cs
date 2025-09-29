using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public List<User> Get()
        {
            return _userRepository.Get();
        }
        
        public User? Get(int id)
        {
            return _userRepository.Get(id);
        }

        public User? Get(string name)
        {
            return _userRepository.Get(name);
        }

        public int AddUser(UserForCreateDto userDto)
        {
            var user = new User()
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Username = userDto.Username,
                Password = userDto.Password
            };

            return _userRepository.Add(user).Id;
        }

        public UserModel? VerifyCredentials(UserCredentialsDto credentials)
        {
            User? user = Get(credentials.Username);
            if (user != null && user.Password == credentials.Password)
            {
                return new UserModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Role = user.Role,
                };
            }
            return null;
        }
    }
}
