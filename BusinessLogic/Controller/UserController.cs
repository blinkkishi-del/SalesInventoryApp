using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class UserController
    {
        private UserRepository userRepository; 

        public UserController() 
        { 
            userRepository = new UserRepository(); 
        } 

        public UserModel Login(string username, string password) 
        { 
            return userRepository.ValidateUser(username, password); 
        } 
    } 
} 