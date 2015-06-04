using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleControls.ImageDialog
{
    public interface IImageDialog
    {
        Task Display(ImageSource imageSource);

        Task Display(string message, ImageSource imageSource);
    }
}

//public IImageSourceHandler GetHander(ImageSource source)
//        {
//            IImageSourceHandler returnValue = null;
//            if (source is UriImageSource)
//            {
//                returnValue = new ImageLoaderSourceHandler();
//            }
//            else if (source is FileImageSource)
//            {
//                returnValue = new FileImageSourceHandler();
//            }
//            else if (source is StreamImageSource)
//            {
//                returnValue = new StreamImagesourceHandler();
//            }
//            return returnValue;
//        }