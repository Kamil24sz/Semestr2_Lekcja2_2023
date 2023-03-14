using Semestr2_Lekcja2_2023.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestr2_Lekcja2_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //jak stworzyć nowego użytkownika?
            Uzytkownik user1 = new Uzytkownik();

            //przypisywanie właściwości
            user1.Login = "Paweł";
            user1.Haslo = "Haslo123";
            user1.Email = "pawel@gmail.com";
            user1.Wiek = 21;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Uzytkownik user2 = new Uzytkownik();
            user2.Login = "Kamil";
            user2.Haslo = "12345";
            user2.Email = "kamil123@gmail.com";
            user2.Wiek = 22;

            
            if (textBox1.Text == user2.Login && textBox2.Text == user2.Haslo)
            {
                MessageBox.Show($"{user2.PrzedstawSie()}","Zalogowano poprawnie");
            }
            else
            {
                MessageBox.Show("Login, lub hasło są nieprawidłowe");
            }
        }
    }
}
