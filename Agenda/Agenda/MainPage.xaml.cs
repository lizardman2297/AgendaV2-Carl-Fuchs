﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Agenda.Resources;

namespace Agenda
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            InitializeComponent();

            // Exemple de code pour la localisation d'ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageVoirInfo.xaml", UriKind.Relative));
        }

        private void btnRdv_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConsultationRDV.xaml", UriKind.Relative));
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageAuthentification.xaml", UriKind.Relative));
        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GestionContact.xaml", UriKind.Relative));
        }

        // Exemple de code pour la conception d'une ApplicationBar localisée
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Définit l'ApplicationBar de la page sur une nouvelle instance d'ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crée un bouton et définit la valeur du texte sur la chaîne localisée issue d'AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crée un nouvel élément de menu avec la chaîne localisée d'AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}