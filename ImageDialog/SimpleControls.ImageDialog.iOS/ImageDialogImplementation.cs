﻿using Foundation;
using SimpleControls.ImageDialog.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(ImageDialogImplementation))]

namespace SimpleControls.ImageDialog.iOS
{
    public class ImageDialogImplementation : IImageDialog
    {
        public static void Init() { }


        public async Task Display(Xamarin.Forms.ImageSource imageSource)
        {
            await Display(null, imageSource);
        }

        public async Task Display(string message, Xamarin.Forms.ImageSource imageSource)
        {
            var handler = GetHandler(imageSource);
            var image = await handler.LoadImageAsync(imageSource);
            if (image != null)
            {
                var view = new UIView();

                if (!string.IsNullOrWhiteSpace(message))
                {
                    var label = new UILabel()
                    {
                        Text = message
                    };
                    view.AddSubview(label);
                }

                var imageView = new UIImageView(image);
                view.AddSubview(imageView);

                var alertView = new UIAlertView();
                alertView.AddSubview(view);
                alertView.Show();
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
