using pract12_trpo.Data.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace pract12_trpo.Classes.Validations
{
    public class LoginValidation : ValidationRule
    {
        public static bool IsUnique(string inputString)
        {

            foreach (User user in UsersService.Users)
            {
                if (user.UserName == inputString)
                    return false;
            }

            return true;
        }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            var inputString = value.ToString();

            if (value == null)
            {
                return new ValidationResult(false, "Значение не может быть пустым");
            }
            if (value == string.Empty)
            {
                return new ValidationResult(false, "Значение не может быть пустым");
            }
            if (inputString.Length < 5)
            {
                return new ValidationResult(false, $"Строка должна содержать минимум 3 символа");
            }
            if (inputString.Length > 255)
            {
                return new ValidationResult(false, $"Строка должна содержать не более 255 символов");
            }
            if (!IsUnique(inputString))
            {
                return new ValidationResult(false, $"Логин не уникальный");
            }

            return ValidationResult.ValidResult;
        }
    }
}
