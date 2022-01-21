﻿using System;
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

namespace Sekretariat_Kacpe_Pawlak
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PracownikK_Checked(object sender, RoutedEventArgs e)
        {
            if (PracownikK.IsChecked == true)
            {
                WysPlecPrac.Content = WysPlecPrac.Content + "\n" + PracownikK.Content;
            }
        }

        private void PracownikM_Checked(object sender, RoutedEventArgs e)
        {
            if (PracownikM.IsChecked == true)
            {
                WysPlecPrac.Content = WysPlecPrac.Content + "\n" + PracownikM.Content;
            }
        }

        private void UczenK_Checked(object sender, RoutedEventArgs e)
        {
            if (UczenK.IsChecked == true)
            {
                WysPlecUcznia.Content = WysPlecUcznia.Content + "\n" + UczenK.Content;
            }
        }

        private void UczenM_Checked(object sender, RoutedEventArgs e)
        {
            if (UczenM.IsChecked == true)
            {
                WysPlecUcznia.Content = WysPlecUcznia.Content + "\n" + UczenM.Content;
            }
        }

        private void NauczycielK_Checked(object sender, RoutedEventArgs e)
        {
            if (NauczycielK.IsChecked == true)
            {
                WysPlecNaucz.Content = WysPlecNaucz.Content + "\n" + NauczycielK.Content;
            }
        }

        private void NauczycielM_Checked(object sender, RoutedEventArgs e)
        {
            if (NauczycielM.IsChecked == true)
            {
                WysPlecNaucz.Content = WysPlecNaucz.Content + "\n" + NauczycielM.Content;
            }
        }

        private void PracownikPrzeslijDane_Click(object sender, RoutedEventArgs e)
        {
            WysImiePrac.Content = WysImiePrac.Content + "\n" + PracownikImie.Text;
            WysDrugieImiePrac.Content = WysDrugieImiePrac.Content + "\n" + PracownikDrugieImie.Text;
            WysNazwPrac.Content = WysNazwPrac.Content + "\n" + PracownikNazwisko.Text;
            WysNazwPanPrac.Content = WysNazwPanPrac.Content + "\n" + PracownikNazwiskoP.Text;
            WysImieOjcaPrac.Content = WysImieOjcaPrac.Content + "\n" + PracownikImieOjca.Text;
            WysImieMatkiPrac.Content = WysImieMatkiPrac.Content + "\n" + PracownikImieMatki.Text;
            WysDataUroPrac.Content = WysDataUroPrac.Content + "\n" + PracownikDataUro.SelectedDate;
            WysPeselPrac.Content = WysPeselPrac.Content + "\n" + PracownikPesel.Text;
            WysEtat.Content = WysEtat.Content + "\n" + PracownikEtat.SelectedItem;
            WysZdjPrac.Content = WysZdjPrac.Content + "\n" + PracownikImie.Text;
            WysStanowisko.Content = WysStanowisko.Content + "\n" + PracownikStanowisko.SelectedItem;
            WysDataZatrPrac.Content = WysDataZatrPrac.Content + "\n" + PracownikDataZatr.SelectedDate;

        }

        private void UczenPrzeslijDane_Click(object sender, RoutedEventArgs e)
        {
            WysImieUcznia.Content = WysImieUcznia.Content + "\n" + UczenImie.Text;
            WysDrugieImieUcznia.Content = WysDrugieImieUcznia.Content + "\n" + UczenDrugieImie.Text;
            WysNazwUcznia.Content = WysNazwUcznia.Content + "\n" + UczenNazwisko.Text;
            WysNazwPanUcznia.Content = WysNazwPanUcznia.Content + "\n" + UczenNazwiskoP.Text;
            WysImieOjcaUcznia.Content = WysImieOjcaUcznia.Content + "\n" + UczenImieOjca.Text;
            WysImieMatkiUcznia.Content = WysImieMatkiUcznia.Content + "\n" + UczenImieMatki.Text;
            WysDataUroUcznia.Content = WysDataUroUcznia.Content + "\n" + UczenDataUro.SelectedDate;
            WysPeselUcznia.Content = WysPeselUcznia.Content + "\n" + UczenPesel.Text;
            WysZdjUcznia.Content = WysZdjNaucz.Content + "\n" + UczenImie.Text;

        }

        private void NauczycielPrzeslijDane_Click(object sender, RoutedEventArgs e)
        {
            WysImieNaucz.Content = WysImieNaucz.Content + "\n" + NauczycielImie.Text; 
            WysDrugieImieNaucz.Content = WysDrugieImieNaucz.Content + "\n" + NauczycielDrugieImie.Text;
            WysNazwNaucz.Content = WysNazwNaucz.Content + "\n" + NauczycielNazwisko.Text;
            WysNazwPanNaucz.Content = WysNazwPanNaucz.Content + "\n" + NauczycielNazwiskoP.Text;
            WysImieOjcaNaucz.Content = WysImieOjcaNaucz.Content + "\n" + NauczycielImieOjca.Text;
            WysImieMatkiNaucz.Content = WysImieMatkiNaucz.Content + "\n" + NauczycielImieMatki.Text;
            WysDataUroNaucz.Content = WysDataUroNaucz.Content + "\n" + NauczycielDataUro.SelectedDate;
            WysPeselNaucz.Content = WysPeselNaucz.Content + "\n" + NauczycielPesel.Text;
            WysWychow.Content = WysEtat.Content + "\n" + NauczycielWychow.SelectedItem;
            WysZdjNaucz.Content = WysZdjNaucz.Content + "\n" + NauczycielImie.Text;
            WysPrzedNaucz.Content = WysStanowisko.Content + "\n" + NauczycielPrzedNaucz.SelectedItem;
            WysDataZatrNaucz.Content = WysDataZatrNaucz.Content + "\n" + NauczycielDataZatr.SelectedDate;
        }
    }
}