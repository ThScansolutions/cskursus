namespace EgenskaberAutomatisk
{
    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get
            {
                return efternavn;
            }
            set
            {
                if (value.Length < 3)
                    efternavn = "";
                efternavn = value;
            }
        }

        public string FuldtNavn()
        {
            return $"{this.Fornavn}  {this.Efternavn}";
        }
        public Person()
        {

        }
    }
}
