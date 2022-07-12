using Microsoft.Maui.Platform;

namespace VersalityApp.Views;

public partial class TeachingPlan : ContentPage
{
    public TeachingPlan()
    {
        InitializeComponent();
       

      
    }

   
}



//    void ModifySearch()
//    {
//        Microsoft.Maui.Handlers.SearchBarHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
//        {
//#if ANDROID
//            handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());

//#elif iOS
//            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
//#elif WINDOWS
//            handler.PlatformView.FontWeight = Microsoft.UI.Text.FontWeights.Thin;
//#endif
//        });
//    }
