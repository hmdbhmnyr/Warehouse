using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ware_house.classes;
using Ware_house.Schemas;

namespace Ware_house.Validations
{
    public class UserValidation
    {
        public ValidationResult CheckUser(UserModel user)
        {
            ValidationResult validationResult = new ValidationResult();
            validationResult.hasError = true;
            if (!CheckNationId(user.Nationcode))
            {
                validationResult.errorMessage = "کد ملی صحیح نیست";
                return validationResult;
            }
            if (!CheckPostalCode(user.PostalCode))
            {
                validationResult.errorMessage = "کد پستی صحیح نیست";
                return validationResult;
            }

            validationResult.hasError = false;
            validationResult.errorMessage = string.Empty;
            validationResult.successMessage = "passed";

            return validationResult;
        }
        public bool CheckNationId(string nationID)
        {
            return true;
        }
        public bool CheckPostalCode(string postalCode)
        {
            return true;
        }
    }
}
