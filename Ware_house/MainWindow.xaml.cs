﻿using System;
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
                ctx.Users.Add(new User { Name = "Hamed", Password="1234" });
                ctx.SaveChanges();
            }
        }
    }
}
