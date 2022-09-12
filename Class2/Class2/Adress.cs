using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @Class2
{
    class Adress
    {
        private string _country;
        private string _city;
        private string _street;
        private int _house;

        public Adress(string country, string city, string street, int house)
        {
            this._country = country;
            this._city = city;
            this._street = street;
            this._house = house;
        }

        public string toString()
        {
            return
                "Country: " + this._country + "\n" +
                "City: " + this._city + "\n" +
                "Street: " + this._street + "\n" +
                "House: " + this._house.ToString() + "\n";
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public int House
        {
            get { return _house; }
            set { _house = value; }
        }
    }
}
