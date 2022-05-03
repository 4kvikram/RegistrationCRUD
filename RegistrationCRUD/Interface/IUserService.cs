using RegistrationCRUD.Models;
using System.Collections.Generic;

namespace RegistrationCRUD.Interface
{
    public interface IUserService 
    {
        public int AddRegistration(RegistrationViewModel model);
        public List<RegistrationViewModel> GetAllRegistration();
    }
}
