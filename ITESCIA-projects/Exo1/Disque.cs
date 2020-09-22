using System;
namespace ITESCIA_projects.Exo1
{
    public class Disque : Article
    {
        protected string Label;
        public string MonLabel
        {
            get { return Label; }
            set { Label = value; }
        }
        public Disque(string Label, string Designation, double Prix) : base(Designation, Prix) { this.MonLabel = Label; }


        public void Ecouter()
        {
            Console.WriteLine("Label : " + Label);
        }
    }
}
