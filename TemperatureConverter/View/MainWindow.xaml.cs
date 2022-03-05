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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var valF = double.Parse(textBoxC.Text) * 1.8 + 32;
            var valK = double.Parse(textBoxC.Text) + 273.15;

            textBoxF.Text = $"{Math.Round(valF)}";
            textBoxK.Text = $"{Math.Round(valK)}";
        }

        private void ConvertFanrenheit(object sender, RoutedEventArgs e)
        {
            var valC = (double.Parse(textBoxF.Text) -32) /1.8;
            var valK = (double.Parse(textBoxF.Text) - 32) / 1.8 + 273.15;
            
            textBoxK.Text = $"{Math.Round(valK)}";
            textBoxC.Text = $"{Math.Round(valC)}";
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var valC = double.Parse(textBoxK.Text) -273.15;
            var valF = (double.Parse(textBoxK.Text) -273.15) *1.8 +32;

            textBoxC.Text = $"{Math.Round(valC)}";
            textBoxF.Text = $"{Math.Round(valF)}";
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = slider.Value;
            double Celsius = Math.Round(value - 273.15);
            double far = Math.Round((value - 273.15) * 1.8 + 32);

            textBoxC.Text = $"{Math.Round(Celsius)}";
            textBoxF.Text = $"{Math.Round(far)}";
            textBoxK.Text = $"{Math.Round(value)}";
        }
    }
}
