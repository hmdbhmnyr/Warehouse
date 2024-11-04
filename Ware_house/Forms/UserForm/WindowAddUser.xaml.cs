using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Ware_house.classes;
using Ware_house.Service;
using Ware_house.Validations;
using Ware_house.Schemas;
namespace Ware_house.Forms.User
{
    /// <summary>
    /// Interaction logic for WindowAddUser.xaml
    /// </summary>
    public partial class WindowAddUser : Window
    {
        UserService _userService = new UserService();
        UserValidation _userValidation = new UserValidation();
        public WindowAddUser()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            UserModel userModel = new UserModel()
            {
                City = txtCity.Text,
                Nationcode = txtNationCode.Text,

            };
            var validationResult = _userValidation.CheckUser(userModel);
            if (validationResult.hasError)
            {
                MessageBox.Show(validationResult.errorMessage);
                return;
            }

            Result result = _userService.SaveUser(userModel);
            if (!result.hasError)
                MessageBox.Show(result.successMessage);
            else
                MessageBox.Show(result.errorMessage);

        }
    }
}
