using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace OpenWeatherApp
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        String APIKey = "2e181335bb0621000eeaaa8b4d9cd6ce";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=es", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherCont.root Info = JsonConvert.DeserializeObject<WeatherCont.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                labTemperature.Text = Info.main.temp.ToString() + " °C";
                labHumidity.Text = Info.main.humidity.ToString() + " habs";
                labWindSpeed.Text = Info.wind.speed.ToString() + " m/s";
                labPressure.Text = Info.main.pressure.ToString() + " Pa";
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getWeather();
            }
            catch(Exception)
            {
                MessageBox.Show("No se encontro la ciudad");
            }

        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }
    }
}
