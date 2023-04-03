using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Count.MaxLength = 9;
        }

        private void Change_OnClick(object sender, RoutedEventArgs e)
        {
            if (Count.Text != "")
            {
                var margin = int.Parse(Count.Text);
                Rectangle.RenderTransform = new RotateTransform(margin);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Count_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
                e.Handled = true;
        }

        private void Count_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!Char.IsDigit(e.Text,0))
                e.Handled = true;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
