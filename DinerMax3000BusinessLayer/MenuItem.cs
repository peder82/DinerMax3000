using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000.Business
{
    public class MenuItem
    {
        private double _price;

        public string Title{ get; set; }
        public string Description{ get; set; }
        public double Price
        {
            get
            {
                //CDyne.WeatherSoapClient client = new CDyne.WeatherSoapClient();
                //var resultWeather = client.GetCityWeatherByZIP("90102");
                //if (int.Parse(resultWeather.Temperature) > 70)
                //{
                //    return _price*2;
                //}
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("Free items are not allowed...!");
                }
            }
        }


    }
}
