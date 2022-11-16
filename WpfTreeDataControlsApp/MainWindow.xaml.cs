using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTreeDataControlsApp
{
    class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }
        public string? Company { set; get; }
        public bool Married { set; get; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>()
            {
                new(){Name = "Sam", Age = 27, Company = "Microsoft"},
                new(){Name = "Tim", Age = 32, Company = "Google"},
                new(){Name = "Joe", Age = 44, Company = "Amazone"},
            };

            DataGridCheckBoxColumn col = new();
            col.Header = "В браке";
            //col.Binding = 

            dataGrid.Columns.Add(col);

            ProgressBar progbar = new ProgressBar();
            //progbar.IsIndeterminate = false;
            progbar.Orientation = Orientation.Horizontal;
            progbar.Width = 150;
            progbar.Height = 15;
            //Duration duration = new Duration(TimeSpan.FromSeconds(10));
            //DoubleAnimation doubleanimation = new DoubleAnimation(100.0, duration);
            //progbar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);

            stack.Children.Add(progbar);

            for(var i = progbar.Maximum; i < progbar.Maximum; i++)
            {
                
                //Thread.Sleep(100);
            }    

            //dataGrid.ItemsSource = users;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(sender is Slider slider) 
            {
                slider.SelectionEnd = slider.Value;
            }
        }
    }
}
