using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

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
           // if 
           // {
           //     throw new Exception("Ungültiges Zeichen");
           // }
           // else
            //   {
            //    this.autor = autor;

           // }
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
    }
}
