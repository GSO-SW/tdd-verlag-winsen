namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;
        private string isbn10;
        private string isbn13;

        public Buch(string autor, string titel, int auflage)
        {
            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException("die Auflage muss ein Wert über 0 haben");

            }
            else
            {
                this.auflage = auflage;
            }


            this.autor = autor;
            this.titel = titel;
        }

        public Buch(string autor, string titel)
        {
            char[] unerlaubtezeichen = { '#', ';', '§', '%', };

            if (autor.Any(c => unerlaubtezeichen.Contains(c)) || String.IsNullOrEmpty(autor))
            {
                throw new ArgumentException("Unerlaubtes Zeichen im Autorenfeld");
            }
            else
            {
                this.autor = autor;
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
            {
                isbn = value;
            }
        }

        public string ISBN10
        {
            get { return isbn10; }
            set { isbn10 = value; }
        }

        public string ISBN13
        {
            get
            {
                string result = "";
                for (int i = 0; i < isbn.Length; i++)
                {
                    if (isbn[i] != '-')
                    {
                        result = result + isbn[i];
                    }
                }

                return result;
            }

            set
            {
                isbn13 = value;
            }
        }
    }
}
