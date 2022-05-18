using System;
using Zambia_Police_Service.WEB;
using Zambia_Police_Service_Repository.DALL.Interfaces;

namespace Zambia_Police_Service_Implementation.DALL.Implementations
{
    public class GenericImplementation : IService
    {
        private readonly Zambia_Police_ServiceContext _context;

        public GenericImplementation(Zambia_Police_ServiceContext context)
        {
            _context = context;
        }
        public PoliceUsers AddUser(PoliceUsers model)
        {

            PoliceUsers users = new PoliceUsers();

            Random random = new Random();
            int UsersNumber = random.Next(000000000, 999999999);

            users.UserFullName = model.UserFullName;
            users.UserLocation = model.UserLocation;
            users.UserEmailAddress = model.UserEmailAddress;
            users.UserNumber = UsersNumber;
            var result = _context.PoliceUsers.Find(users.UserNumber == UsersNumber);

            if(result != null)
            {
     
                int UsersNumber2 = random.Next(000000000, 999999999);
                users.UserNumber = UsersNumber2;
            }

            _context.Add(users);
            _context.SaveChanges();

            return users;
            
            
        }
    }
}
