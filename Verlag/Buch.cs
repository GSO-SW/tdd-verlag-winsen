using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;
        private string isbn10;
       
        public Buch(string autor, string titel, int auflage)
        {
            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException("die Auflage muss ein Wert über 0 haben");

            } else
            {
                this.auflage = auflage;
            }


            this.autor = autor;
            this.titel = titel;
        }

        public Buch(string autor, string titel)
        {
            char[] unerlaubtezeichen = {'#', ';', '§', '%',};

            if (autor.Any(c => unerlaubtezeichen.Contains(c))|| String.IsNullOrEmpty(autor))
            {
                throw new ArgumentException("Unerlaubtes Zeichen im Autorenfeld");
            }
            
  
            this.titel = titel;
            this.auflage = 1;
        }
         
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Titel
        {
            get { return titel; }
        }

        public int Auflage
        {
            get { return auflage; }

            set 
            {
                
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("die Auflage muss ein Wert über 0 haben");
                }
                else
                {
                    auflage = value;

                }
            }
        }

        public string ISBN
        {
            get { return isbn; }

            set
            { isbn = value; }
        }

        public string ISBN10
        {
            get { return isbn10; }
            set { isbn10 = value; }
        }

    }
}
