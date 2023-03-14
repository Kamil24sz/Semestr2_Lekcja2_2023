using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja2_2023.Klasy
{
    public class Uzytkownik
    {
        //właściwości użytkownika
        public string Login;
        public string Haslo;
        public int Wiek;
        public string Email;

        //klasa może też posiadać metody
        public string PrzedstawSie()
        {
            string tekst = $"Użytkownik {Login} ma {Wiek} lat, a jego adres email to {Email}";
            return tekst;
        }

        //public - dostęp do elementów wszędzie
        //internal - dostępność w ramach jednego projektu
        //protected - tak jak prywatny, ale dostępny dla klas pochodnych
        //private - dostęp do elementów tylko wewnątrz klasy
    }
}
