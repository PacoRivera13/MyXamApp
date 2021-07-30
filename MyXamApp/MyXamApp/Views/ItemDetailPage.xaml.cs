using System.ComponentModel;
using MyXamApp.ViewModels;
using Xamarin.Forms;

namespace MyXamApp.Views
{
   public partial class ItemDetailPage : ContentPage
   {
      public ItemDetailPage()
      {
         InitializeComponent();
         BindingContext = new ItemDetailViewModel();
      }
   }
}