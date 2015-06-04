## Image Dialog for Xamarin and Windows

Simple cross platform plugin to popup a dialog with a title (optional) and an image.

### Setup
* Available on NuGet: https://www.nuget.org/packages/SimpleControls.ImageDialogs/
* Install into your PCL project and Client projects.

```
install-package SimpleControls.ImageDialogs
```

**Supports**
* Xamarin.Android
* Xamarin.iOS (still to test)
* Xamarin.iOS (x64 Unified) (still to test)
* Windows Phone 8 (Silverlight) (still to test)
* Windows Ptone 8.1 RT (still to test)
* Windows Store 8.1 (still to test)


### API Usage
```C#
var imageDialogService = DependencyService.Get<IImageDialog>();
await imageDialogService.Display("My Image", ImageSource.FromFile("icon.png"));
await imageDialogService.Display(ImageSource.FromFile("icon.png"));
```

#### Contributors
* [Johan du Toit](https://github.com/Johan-dutoit)

#### License
Licensed under main repo license
