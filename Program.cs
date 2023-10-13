using System.Text.Json; 

var client = new HttpClient();
client.BaseAddress = new Uri($"https://api.open-meteo.com/v1/");

var response = client.GetAsync($"forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relativehumidity_2m,apparent_temperature,is_day,rain&timeformat=unixtime&timezone=Europe%2FBerlin").Result;
string json = response.Content.ReadAsStringAsync().Result;

var weather = JsonSerializer.Deserialize<Weerbericht>(json);
var current = weather.current;

    


Console.WriteLine($"Temperature: {current.temperature_2m}*c \r\nFeels like: {current.apparent_temperature}*c \r\nHumidity: {current.relativehumidity_2m}% \r\nRainfall: {current.rain}mm");