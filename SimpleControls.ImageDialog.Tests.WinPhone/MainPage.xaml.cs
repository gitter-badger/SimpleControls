using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SimpleControls.ImageDialog.Tests.WinPhone.Resources;

namespace SimpleControls.ImageDialog.Tests.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            global::Xamarin.Forms.Forms.Init();
            SimpleControls.ImageDialog.WinPhone.ImageDialogImplementation.Init();

            LoadApplication(new SimpleControls.ImageDialog.Tests.App());
        }
    }
}