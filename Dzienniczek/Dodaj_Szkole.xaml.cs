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
    /// Logika interakcji dla klasy Dodaj_Szkole.xaml
    /// </summary>
    public partial class Dodaj_Szkole : Window
    {
        public Dodaj_Szkole()
        {
            InitializeComponent();
        }

        private void Gotowebtn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            Data.szkoly.schools.Add(new Szkola((Data.szkoly.schools.Count + 1).ToString(), nazwatxt1.Text, Int32.Parse(ilosc_klastxt.Text), Int32.Parse(liczba_uczniowtxt.Text), rand));
            Data.wind.Szkoly.Items.Add(nazwatxt1.Text);
            Data.wind.Szkoly.Items.Refresh();
            Data.wind.Klasy.Items.Refresh();
            Data.wind.Uczniowie.Items.Refresh();
            File.WriteAllText(Data.path, JsonConvert.SerializeObject(Data.szkoly));
            this.Close();
        }

        private void nazwatxt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
