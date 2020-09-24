using System;
namespace ITESCIA_projects.Exo1
{
    public class Broche : Livre
    {
        public Broche(string Isbn, int NbPages, string Designation, double Prix) : base(Isbn, NbPages, Designation, Prix) { }
    }
}
