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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ware_house.DatabaseContext;
using Ware_house.classes;
using Ware_house.Models.TestModel;

namespace Ware_house
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //initial Database:
            using (var ctx=new WarehouseContext())
            {
                StudentAddress studentAddress1 = new StudentAddress
                {
                    Address1 = "Texas",

                };
                StudentAddress studentAddress2 = new StudentAddress
                {
                    Address1 = "Tehran",

                };
                List<StudentAddress> studentAddresses = new List<StudentAddress>();
                studentAddresses.Add(studentAddress1);
                studentAddresses.Add(studentAddress2);

                ctx.Students.Add(new Student { StudentName = "Ali",Address = studentAddresses });

                ctx.Users.Add(new User {ID =1, Name="Hamed",Family="Bahmanyar", Password="1234",Address="esfahan"});
                //ctx.Users.Add(new User { ID=1,Name="ali",Family="Ahmadian", Password="1234",Address="tehran"});
                ctx.SaveChanges();
            }
        }
    }
}
