

using System.Net;
using System.Text.Json.Nodes;
using WeatherAPI;
using Newtonsoft.Json;

string appIdKey = File.ReadAllText("key.txt").ToString();
// You need to register on the site openweathermap.org and get the key in the section "My API keys". 
string url = $"https://api.openweathermap.org/data/2.5/weather?lat=44.58&lon=33.5224&units=metric&appid={appIdKey}";


HttpWebRequest resquest = (HttpWebRequest)WebRequest.Create(url);

HttpWebResponse response = (HttpWebResponse)resquest.GetResponse();

string rezult;
using (StreamReader str = new StreamReader(response.GetResponseStream()))
{
    rezult = str.ReadToEnd();
}

 Weather weather = JsonConvert.DeserializeObject<Weather>(rezult);

Console.WriteLine($" Whether in {weather.Name} : {weather.Main.Temp} degrees Celcius, feels like {weather.Main.Feels_like}; wind speed {weather.Wind.Speed} ");