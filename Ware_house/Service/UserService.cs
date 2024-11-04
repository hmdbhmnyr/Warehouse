using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ware_house.classes;
using Ware_house.DatabaseContext;
using Ware_house.Models.TestModel;
using Ware_house.Schemas;

namespace Ware_house.Service
{
    public class UserService
    {
        WarehouseContext _context = new WarehouseContext();
        public Result SaveUser(UserModel user)
        {
            Result result = new Result();
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }catch(Exception ex)
            {
                result.hasError = true;
                result.errorMessage = ex.Message;
            }
            result.hasError = false;
            result.successMessage = "User saved in DB";
            return result;
        }
    }
}
