using System;
using MyXamApp.Views;
using Xamarin.Forms;

namespace MyXamApp
{
   public partial class AppShell : Xamarin.Forms.Shell
   {
      public AppShell()
      {
         InitializeComponent();
         Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
         Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
         Routing.RegisterRoute(nameof(GimPage), typeof(GimPage));
         Routing.RegisterRoute(nameof(SimPage), typeof(SimPage));
         Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
         Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));

      }

      private async void OnMenuItemClicked(object sender, EventArgs e)
      {
         await Shell.Current.GoToAsync("//LoginPage");
      }
   }
}
