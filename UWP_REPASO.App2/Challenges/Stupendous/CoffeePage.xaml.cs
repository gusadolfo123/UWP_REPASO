using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_REPASO.App2.Challenges.Stupendous
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private List<string> Items = new List<string>();

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void RoastButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoastButton.IsChecked.Value)
                Items.Add("Roas");
            else
                Items.Remove("Roas");

            CoffeeText.Text = string.Join(",", Items);
        }

        private void SweetenerButton_Click(object sender, RoutedEventArgs e)
        {
            if (SweetenerButton.IsChecked.Value)
                Items.Add("Sweetener");
            else
                Items.Remove("Sweetener");

            CoffeeText.Text = string.Join(",", Items);
        }

        private void CreamButton_Click(object sender, RoutedEventArgs e)
        {
            if (CreamButton.IsChecked.Value)
                Items.Add("Cream");
            else
                Items.Remove("Cream");

            CoffeeText.Text = string.Join(",", Items);
        }
    }
}
