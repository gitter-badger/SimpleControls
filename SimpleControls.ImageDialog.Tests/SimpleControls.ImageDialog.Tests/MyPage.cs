using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace SimpleControls.ImageDialog.Tests
{
    public class MyPage : ContentPage
    {
        public MyPage()
        {


            Content = new StackLayout
            {
                Children = {
					new Label { Text = "Hello ContentPage" },
                    new Image() { Source = ImageSource.FromFile("icon.png")}
				}
            };

            ShowDialogs();
        }

        private async void ShowDialogs()
        {
            var imageDialogService = DependencyService.Get<IImageDialog>();
            await imageDialogService.Display("My Image", ImageSource.FromFile("icon.png"));
            await imageDialogService.Display("My Image", ImageSource.FromUri(new Uri("http://xamarin.com/content/images/pages/branding/assets/xamagon.png")));
        }
    }
}
