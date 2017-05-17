using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Objects
{
    public class Admin
    {
        private readonly ILogger _logger;

        public Admin(ILogger logger)
        {
            _logger = logger;
        }

        public void AddUser(string userName, int userLevel)
        {
            //business logic elided
            _logger.Log($"User {userName} added with User Level {userLevel}");
        }

        //To Simulate a call to AddUser which fails for some reason...
        public void AddUser(string userName, int userLevel, string errorMessage)
        {
            try
            {
                //business logic elided
                throw new Exception(errorMessage);
            }
            catch (Exception e)
            {
                _logger.Log(e.Message, 1);
            }
        }
    }
}
