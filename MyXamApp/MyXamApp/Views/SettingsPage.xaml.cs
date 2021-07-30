
using MyXamApp.Models;
using MyXamApp.ViewModels;
using Syncfusion.XForms.DataForm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamApp.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class SettingsPage : ContentPage
   {
      public SettingsPage()
      {
         InitializeComponent();
         BindingContext = new SettingsViewModel();

         var stackLayout = new StackLayout
         {
            Spacing = 0,
         };

         var labels = new[] { "ACCOUNT", "NOTIFICATIONS", "SUPPORT" };
         foreach (var label in labels)
         {
            var labelControl = new Label
            {
               Text = label,
            };
            stackLayout.Children.Add(labelControl);
            var boxView = new BoxView
            {
               Color = Color.Azure,
               BackgroundColor = Color.Gray,
            };
            stackLayout.Children.Add(boxView);

            switch (label)
            {
               case "ACCOUNT":
                  var dataForm = new SfDataForm();
                  dataForm.DataObject = new SettingsInfo();
                  dataForm.VerticalOptions = LayoutOptions.FillAndExpand;
                  dataForm.HorizontalOptions = LayoutOptions.FillAndExpand;
                  stackLayout.Children.Add(dataForm);
                  break;

               default:
                  break;
            }

         }
         Content = stackLayout;
      }
   }
}