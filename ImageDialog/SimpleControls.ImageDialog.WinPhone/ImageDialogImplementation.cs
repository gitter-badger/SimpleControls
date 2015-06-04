using SimpleControls.ImageDialog.WinPhone;
using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: Xamarin.Forms.Dependency(typeof(ImageDialogImplementation))]

namespace SimpleControls.ImageDialog.WinPhone
{
    public class ImageDialogImplementation : IImageDialog
    {
        public static void Init() { }

        public async Task Display(ImageSource imageSource)
        {
            await Display(null, imageSource);
        }

        public async Task Display(string message, ImageSource imageSource)
        {
            var handler = GetHandler(imageSource);
            var windowsImageSource = await handler.LoadImageAsync(imageSource);

            var image = new System.Windows.Controls.Image()
            {
                Source = windowsImageSource
            };

            if (image != null)
            {
                var stackPanel = new StackPanel();

                if (!string.IsNullOrEmpty(message))
                {
                    var label = new System.Windows.Controls.TextBlock()
                    {
                        Text = message
                    };
                    stackPanel.Children.Add(label);
                }
                stackPanel.Children.Add(image);

                var popup = new Popup()
                {
                    Child = stackPanel,
                    IsOpen = true
                };
            }
            else
            {
                throw new ArgumentNullException("Image is null");
            }
        }

        #region Private Methods

        private IImageSourceHandler GetHandler(Xamarin.Forms.ImageSource imageSource)
        {
            IImageSourceHandler returnValue = null;
            if (imageSource is Xamarin.Forms.UriImageSource)
            {
                returnValue = new ImageLoaderSourceHandler();
            }
            else if (imageSource is Xamarin.Forms.FileImageSource)
            {
                returnValue = new FileImageSourceHandler();
            }
            else if (imageSource is Xamarin.Forms.StreamImageSource)
            {
                returnValue = new StreamImagesourceHandler();
            }
            return returnValue;
        }

        #endregion
    }
}
