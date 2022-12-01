using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Dzienniczek.MainWindow;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Dzienniczek
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    /// 
    public static class Data
    {
        public static ListaSzkol szkoly = new ListaSzkol();
        public static int index;
        public static int indexk;
        public static MainWindow wind;
        public static string path = @"C:\Users\huber\source\repos\Dzienniczek\ZapisSzkol.txt";
    }

    public class ListaSzkol
    {
        public List<Szkola> schools { get; set; }

        public ListaSzkol()
        {
            this.schools = new List<Szkola>();
        }
    }

    public class Klasa
    {
        public List<Uczen> uczniowie { get; set; }
        public int liczba_uczniow { get; set; }
        public int srednia_inteligencja { get; set; }
        public int srednia_sila { get; set; }
        public float proc_chlopow { get; set; }
        public string id { get; set; }
        public Random rand { get; set; }

        //Konstruktor klasy Klasa nadający zmiennym wartości
        public Klasa(string id, int liczba_uczniow, Random rand)
        {
            this.rand = rand;
            int losoj_plec = 0;
            plec los = plec.chlop;
            this.id = id;
            this.uczniowie = new List<Uczen>();
            proc_chlopow = 0;
            //przypisywanie uczniom informacji
            for (int j = 0; j < liczba_uczniow; j++)
            {
                losoj_plec = rand.Next() % 2;
                los = losoj_plec == 1 ? plec.chlop : plec.baba;
                this.uczniowie.Add(new Uczen(Imie(rand, (int)los), Nazwisko(rand, (int)los), (int)los, rand.Next() % 10, rand.Next() % 10, "u" + (j + 1).ToString() + "k" + (this.id).ToString(), rand));
                this.liczba_uczniow++;
                srednia_inteligencja += uczniowie[j].inteligencja;
                srednia_sila += uczniowie[j].sila;

                if (uczniowie[j].plec == (int)plec.chlop)
                    proc_chlopow++;
            }
            foreach (Uczen uc in uczniowie)
            {
                srednia_inteligencja += uc.inteligencja;
                srednia_sila += uc.sila;
                //proc_chlopow += uc.plec == 1 ? 0:1;
            }
            proc_chlopow = (proc_chlopow / liczba_uczniow) * 100;
            srednia_inteligencja /= liczba_uczniow != 0 ? liczba_uczniow : 1;
            srednia_sila /= liczba_uczniow != 0 ? liczba_uczniow : 1;
        }

        string Imie(Random rand, int plec)
        {
            if (plec == 0)
            {
                List<string> ImionaM = new List<string>();
                ImionaM.Add("Andrzej");
                ImionaM.Add("Bartosz");
                ImionaM.Add("Czarek");
                ImionaM.Add("Daniel");
                ImionaM.Add("Edward");
                ImionaM.Add("Franciszek");
                ImionaM.Add("Hubert");
                ImionaM.Add("Igor");
                ImionaM.Add("Jarosław");
                int a = rand.Next();
                return ImionaM[a % ImionaM.Count];
            }
            else
            {
                List<string> ImionaM = new List<string>();
                ImionaM.Add("Anna");
                ImionaM.Add("Barbara");
                ImionaM.Add("Celina");
                ImionaM.Add("Dagmara");
                ImionaM.Add("Ewelina");
                ImionaM.Add("Felicja");
                ImionaM.Add("Helga");
                ImionaM.Add("Iza");
                ImionaM.Add("Jadwiga");
                int a = rand.Next();
                return ImionaM[a % ImionaM.Count];
            }
        }

        string Nazwisko(Random rand, int plec)
        {
            if (plec == 0)
            {
                List<string> Nazwisko = new List<string>();
                Nazwisko.Add("Oloszewski");
                Nazwisko.Add("Nowacki");
                Nazwisko.Add("Komiński");
                Nazwisko.Add("Romański");
                Nazwisko.Add("Krakowski");
                Nazwisko.Add("Rybicki");
                Nazwisko.Add("Dmowski");
                Nazwisko.Add("Kołodzijski");
                Nazwisko.Add("Rumuński");
                int a = rand.Next();
                return Nazwisko[a % Nazwisko.Count];
            }
            else
            {
                List<string> Nazwisko = new List<string>();
                Nazwisko.Add("Oloszewska");
                Nazwisko.Add("Nowacka");
                Nazwisko.Add("Komińska");
                Nazwisko.Add("Romańska");
                Nazwisko.Add("Krakowska");
                Nazwisko.Add("Rybicka");
                Nazwisko.Add("Dmowska");
                Nazwisko.Add("Kołodzijska");
                Nazwisko.Add("Rumuńska");
                int a = rand.Next();
                return Nazwisko[a % Nazwisko.Count];
            }
        }
    }

    public class Uczen
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int plec { get; set; }
        public int inteligencja { get; set; }
        public int sila { get; set; }
        public string id { get; set; }

        //Konstruktor klasy Uczen nadający zmiennym wartości
        public Uczen(string imie, string nazwisko, int plec, int inteligencja, int sila, string id, Random rand)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.inteligencja = inteligencja;
            this.sila = sila;
            this.id = id;
        }
            public void UstawImie(string zmiena)
        {
            this.imie = zmiena;
        }
    }

    public class Szkola
    {
        public List<Klasa> klasy { get; set; }
        public int ilosc_klas { get; set; }
        public string nazwa { get; set; }
        public string id { get; set; }
        public int srednia_inteligencja { get; set; }
        public int srednia_sila { get; set; }

        //Konstruktor klasy Szkola nadający zmiennym wartości
        public Szkola(string id,string nazwa, int ilosc_klas, int ilosc_uczniow, Random rand)
        {
            //definiowanie tablicy klas
            this.klasy = new List<Klasa>();
            this.nazwa = nazwa;
            this.id = id;
            this.ilosc_klas = ilosc_klas;

            //przypisywanie klasom informacji
            for (int i = 0; i < ilosc_klas; i++)
            {
                //tworzenie klasy
                klasy.Add(new Klasa((i + "a"), ilosc_uczniow, rand));
            }

            foreach (Klasa klasa in klasy)
            {
                srednia_sila += klasa.srednia_sila;
                srednia_inteligencja += klasa.srednia_inteligencja;
            }
            srednia_inteligencja /= klasy.Count != 0 ? klasy.Count : 1;
            srednia_sila /= klasy.Count != 0 ? klasy.Count : 1;
        }

        //funkcja wypisująca uczniów wszystkich klasy w szkole
        public void Wypisz()
        {
            for (int k = 0; k < klasy.Count; k++)
            {
                for (int i = 0; i < klasy[k].uczniowie.Count; i++)
                {
                    //Wypisanie ucznia
                    Console.WriteLine("id " + klasy[k].uczniowie[i].id + " klasa " + k + " szkola" + 1 + " sila " + klasy[k].uczniowie[i].sila + " inteligencja " + klasy[k].uczniowie[i].inteligencja + " plec " + klasy[k].uczniowie[i].plec + "imie i nazwisko " + klasy[k].uczniowie[i].imie + " " + klasy[k].uczniowie[i].nazwisko);
                }
                Console.WriteLine("srednia sila " + klasy[k].srednia_sila + " srednia inteligencja " + klasy[k].srednia_inteligencja + " proc chłopaków w klasie " + klasy[k].proc_chlopow);
            }
            Console.WriteLine("srednia inteligencja w szkole " + srednia_inteligencja + " srednia sila w szkole " + srednia_sila);
        }
    }

    public partial class MainWindow : Window
    {
        public List<Szkola> szkoly { get; set; }

        public int nr_szkoly = 0;
        public int nr_klasy = 0;
        public int nr_ucznia = 0;

        public MainWindow()
        {
            InitializeComponent();
            string fs = File.ReadAllText(Data.path);
            Data.szkoly = JsonConvert.DeserializeObject<ListaSzkol>(fs);
            foreach (Szkola szkola in Data.szkoly.schools)
            {
                Szkoly.Items.Add(szkola.nazwa);
            }
        }

        public enum plec
        {
            chlop,
            baba
        }

        private void Szkoly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Klasy.Items.Clear();
            Text.Text = "";
            
                for (int i = 0; i < Data.szkoly.schools[Szkoly.SelectedIndex].ilosc_klas; i++)
                    Klasy.Items.Add(Data.szkoly.schools[Szkoly.SelectedIndex].klasy[i].id);
           

            Text.Text = "\nNazwa: " + Data.szkoly.schools[Szkoly.SelectedIndex].nazwa + "\nSrednia inteligencja: " + Data.szkoly.schools[Szkoly.SelectedIndex].srednia_inteligencja + "\nSrednia sila: " + Data.szkoly.schools[Szkoly.SelectedIndex].srednia_sila + "\n ilosc klas: " + Data.szkoly.schools[Szkoly.SelectedIndex].ilosc_klas;
        }

        private void Klasy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Klasy.SelectedIndex < 0)
                return;

            Uczniowie.Items.Clear();
            Text.Text = "";
            for (int i = 0; i < Data.szkoly.schools[Szkoly.SelectedIndex].klasy[Klasy.SelectedIndex].uczniowie.Count; i++)
            {
                Uczniowie.Items.Add(Data.szkoly.schools[Szkoly.SelectedIndex].klasy[Klasy.SelectedIndex].uczniowie[i].imie + " " + Data.szkoly.schools[Szkoly.SelectedIndex].klasy[Klasy.SelectedIndex].uczniowie[i].nazwisko);
            }

            Klasa kl = Data.szkoly.schools[Szkoly.SelectedIndex].klasy[Klasy.SelectedIndex];
            Text.Text = "Liczba uczniow: " + kl.liczba_uczniow + "\nSrednia sila: " + kl.srednia_sila + "\nSrednia Inteligencja: " + kl.srednia_inteligencja + "\n Proc chłopow: " + kl.proc_chlopow; ;
        }

        private void Uczniowie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Uczniowie.SelectedIndex < 0)
                return;

            Text.Text = "";
            Uczen ucz = Data.szkoly.schools[Szkoly.SelectedIndex].klasy[Klasy.SelectedIndex].uczniowie[Uczniowie.SelectedIndex];
            string plec = ucz.plec == 0 ? "chlop" : "baba";

            Text.Text = "Imie: " + ucz.imie + "\nnazwisko: " + ucz.nazwisko + "\ninteligencja: " + ucz.inteligencja + "\nsila: " + ucz.sila + "\nplec: " + plec;
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddSchool(object sender, RoutedEventArgs e)
        {
            Dodaj_Szkole okno = new Dodaj_Szkole();
            okno.Show();
            Data.index = Szkoly.SelectedIndex >= 0 ? Szkoly.SelectedIndex : 0;
            Data.indexk = Klasy.SelectedIndex >= 0 ? Klasy.SelectedIndex : 0;
            Data.wind = this;
        }

        private void AddClass(object sender, RoutedEventArgs e)
        {
            Dodaj_Klase okno = new Dodaj_Klase();
            okno.Show();
            Data.index = Szkoly.SelectedIndex >= 0 ? Szkoly.SelectedIndex : 0;
            Data.indexk = Klasy.SelectedIndex >= 0 ? Klasy.SelectedIndex : 0;
            Data.wind = this;
        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {
            Dodaj_Ucznia okno = new Dodaj_Ucznia();
            okno.Show();
            Data.index = Szkoly.SelectedIndex >= 0 ? Szkoly.SelectedIndex : 0;
            Data.indexk = Klasy.SelectedIndex >= 0 ? Klasy.SelectedIndex : 0;
            Data.wind = this;
        }
    }
}