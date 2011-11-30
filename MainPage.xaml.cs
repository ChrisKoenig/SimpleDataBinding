using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Microsoft.Phone.Controls;

namespace PhoneApp71
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded += (sender, e) =>
            {
                PileOfData p = new PileOfData();
                this.DataContext = p;
            };
        }
    }
}