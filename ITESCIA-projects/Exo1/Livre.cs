using System;
namespace ITESCIA_projects.Exo1
{
    public class Livre : Article
    {
        protected string Isbn;
        public string MonIsbn
        {
            get { return Isbn; }
            set { Isbn = value; }
        }
        protected int NbPages;
        public int MonNbPages
        {
            get { return NbPages; }
            set { NbPages = value; }
        }
        public Livre(string Isbn, int NbPages, string Designation, double Prix) : base(Designation, Prix) { this.MonIsbn = Isbn; this.MonNbPages = NbPages; }

    }
}
