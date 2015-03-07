using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RadioButtons.Resources;
using System.Windows.Media;

namespace RadioButtons
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hola mundo");
        }

        private void escogerColor(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            SolidColorBrush brocha = new SolidColorBrush();

            switch (radio.Content.ToString())
            {
                case "Yellow":
                    brocha.Color = Colors.Yellow;
                    rectangulo.Fill = brocha;
                    break;
                case "Blue":
                    brocha.Color = Colors.Blue;
                    rectangulo.Fill = brocha;
                    break;
                default:
                    brocha.Color = Colors.Red;
                    rectangulo.Fill = brocha;
                    break;


            }
        }

        private void escoger(object sender, RoutedEventArgs e)
        {
            CheckBox check = sender as CheckBox;
            SolidColorBrush brocha = new SolidColorBrush();
            if (amarillo.IsChecked==true) {
                brocha.Color = Colors.Yellow;
                rectanguloCombinado.Fill = brocha;
            
            }
            if (azul.IsChecked==true)
            {
                brocha.Color = Colors.Blue;
                rectanguloCombinado.Fill = brocha;

            }
            if (rojo.IsChecked == true)

            {
                brocha.Color = Colors.Red;
                rectanguloCombinado.Fill = brocha;

            }
            if (azul.IsChecked == true && amarillo.IsChecked == true)
            {
                brocha.Color = Colors.Green;
                rectanguloCombinado.Fill = brocha;
            }
            if (azul.IsChecked == true && rojo.IsChecked == true)
            {
                brocha.Color = Colors.Purple;
                rectanguloCombinado.Fill = brocha;
            }
            if (amarillo.IsChecked == true && rojo.IsChecked == true)
            {
                brocha.Color = Colors.Orange;
                rectanguloCombinado.Fill = brocha;
            }
            if (amarillo.IsChecked == false && rojo.IsChecked == false && azul.IsChecked == false)
            {
                brocha.Color = Colors.Black;
                rectanguloCombinado.Fill = brocha;
            }
            
        }
    }
}