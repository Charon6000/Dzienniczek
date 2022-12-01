using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;


namespace Dzienniczek
{
    /// <summary>
    /// Logika interakcji dla klasy Dodaj_Klase.xaml
    /// </summary>
    public partial class Dodaj_Klase : Window
    {
        public Dodaj_Klase()
        {
            InitializeComponent();
        }

        private void Gotowebtn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            Data.szkoly.schools[Data.index].klasy.Add(new Klasa(idtxt.Text, Int32.Parse(liczba_uczniowtxt.Text), rand));
            Data.szkoly.schools[Data.index].ilosc_klas++;
            Data.wind.Szkoly.Items.Refresh();
            Data.wind.Klasy.Items.Refresh();
            Data.wind.Uczniowie.Items.Refresh();
            Data.wind.Klasy.Items.Add(idtxt.Text);
            File.WriteAllText(Data.path, JsonConvert.SerializeObject(Data.szkoly));
            this.Close();
        }

        private void liczba_uczniowtxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
