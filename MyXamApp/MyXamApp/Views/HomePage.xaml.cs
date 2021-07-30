using System.Collections.Generic;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamApp.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class HomePage : ContentPage
   {
      public HomePage()
      {
         InitializeComponent();
         var data = new List<Person>()
         {
                new Person { Name = "David", Height = 180 },
                new Person { Name = "Michael", Height = 170 },
                new Person { Name = "Steve", Height = 160 },
                new Person { Name = "Joel", Height = 182 }
         };
         var chart = new SfChart { };

         //Initializing primary axis
         CategoryAxis primaryAxis = new CategoryAxis();
         primaryAxis.Title.Text = "Name";
         chart.PrimaryAxis = primaryAxis;

         //Initializing secondary Axis
         NumericalAxis secondaryAxis = new NumericalAxis();
         secondaryAxis.Title.Text = "Height (in cm)";
         chart.SecondaryAxis = secondaryAxis;

         //Initializing column series
         ColumnSeries series = new ColumnSeries();
         series.ItemsSource = data;
         //series.SetBinding(ChartSeries.ItemsSourceProperty, "Data");

         series.XBindingPath = "Name";
         series.YBindingPath = "Height";
         chart.Series.Add(series);

         var stackLayout = new StackLayout
         {
            Spacing = 0,
         };
         stackLayout.Children.Add(chart);
         Content = stackLayout;
      }
   }

   public class Person
   {
      public string Name { get; set; }

      public double Height { get; set; }
   }
}