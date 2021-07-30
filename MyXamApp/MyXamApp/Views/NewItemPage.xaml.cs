using System;
using System.Collections.Generic;
using System.ComponentModel;
using MyXamApp.Models;
using MyXamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamApp.Views
{
   public partial class NewItemPage : ContentPage
   {
      public Item Item { get; set; }

      public NewItemPage()
      {
         InitializeComponent();
         BindingContext = new NewItemViewModel();
      }
   }
}