using RegistrationCRUD.Database;
using RegistrationCRUD.Entities;
using RegistrationCRUD.Interface;
using RegistrationCRUD.Models;
using System.Collections.Generic;
using System.Linq;

namespace RegistrationCRUD.Service
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public int AddRegistration(RegistrationViewModel model)
        {
            try
            {
                Registration reg = new Registration()
                {
                    Address = model.Address,
                    City = model.City,
                    Dob = model.Dob,
                    Fname = model.Fname,
                    Gender = model.Gender,
                    Id = model.Id,
                    Image = model.Image,
                    Lname = model.Lname,
                    Password = model.Password
                };
                _context.Registrations.Add(reg);
                int i = _context.SaveChanges();
                return i;

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public List<RegistrationViewModel> GetAllRegistration()
        {
            try
            {
                var data = _context.Registrations.Select(x => new RegistrationViewModel()
                {
                    Address = x.Address,
                    City = x.City,
                    Dob = x.Dob,
                    Fname = x.Fname,
                    Gender = x.Gender,
                    Id = x.Id,
                    Image = x.Image,
                    // Password = x.Password,
                    Lname = x.Lname
                }).ToList();
                return data;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
