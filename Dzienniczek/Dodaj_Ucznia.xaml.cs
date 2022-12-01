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
    /// Logika interakcji dla klasy Dodaj_Ucznia.xaml
    /// </summary>
    public partial class Dodaj_Ucznia : Window
    {
        public Dodaj_Ucznia()
        {
            InitializeComponent();
        }

        private void gotowebtn_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            Data.szkoly.schools[Data.index].klasy[Data.indexk].uczniowie.Add(new Uczen(imietxt.Text, nazwiskotxt.Text, Int32.Parse(plectxt.Text), Int32.Parse(inteligencjatxt.Text), Int32.Parse(silatxt.Text), (Data.szkoly.schools[Data.index].klasy[Data.indexk].uczniowie.Count+1).ToString(), rand));
            Data.szkoly.schools[Data.index].klasy[Data.indexk].liczba_uczniow++;
            Data.wind.Szkoly.Items.Refresh();
            Data.wind.Klasy.Items.Refresh();
            Data.wind.Uczniowie.Items.Refresh();
            Data.wind.Uczniowie.Items.Add(imietxt.Text + " " + nazwiskotxt.Text);
            File.WriteAllText(Data.path, JsonConvert.SerializeObject(Data.szkoly));
            this.Close();
        }

        private void inteligencjatxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
