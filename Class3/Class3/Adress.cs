using System;

namespace @Class3
{
    public class Adress
    {
        private string country;
        private string city;

        public Adress()
        {
            this.country = "Ukraine";
            this.city = "Kerson";
        }
        public Adress(string country, string city)
        {
            this.country = country;
            this.city = city;
        }
        public string toString()
        {
            return
                "Country:" + this.country + "\n" +
                "City:" + this.city + "\n";
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }

}
