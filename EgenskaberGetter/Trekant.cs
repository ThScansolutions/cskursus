namespace EgenskaberGetter
{
    class Trekant
    {
        public double Grundlinje  { get; private set; }
        public double Højde { get; private set; }

        public Trekant(double grundlinje, double højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        private double areal;

        public double Areal
        {
            get
            {
                this.areal = this.Grundlinje * this.Højde * 0.5;
                return areal;
            }
           
        }
        public static Trekant Trekant_10_10()
        {
            Trekant t = new Trekant(10, 10);
            return t;
        }
                     
    }
}
