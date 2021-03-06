﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_REPASO.App2.Challenges.AdeptlyAdaptive.Models;
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

namespace UWP_REPASO.App2.Challenges.AdeptlyAdaptive
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainAdeptlyAdaptivePage : Page
    {               
        public MainAdeptlyAdaptivePage()
        {
            this.InitializeComponent();            
        }

        private void BtnShowMenu_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }

        private void FinantialItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(FinantialPage));
        }

        private void FoodItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(FoodPage));
        }
    }
}
