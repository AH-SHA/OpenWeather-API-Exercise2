// See https://aka.ms/new-console-template for more information




using Newtonsoft.Json.Linq;
using OpenWeather_API_Exercise2;


class Program
{
    
    
    private static void Main(string[] args)
    {
        
         
        
        WeatherAPI.WeatherAPIResult();

                    
    }



        //////////////////////////  UNUSED    CODE   //////////////////////////////////////////////

        #region
        //var zipFor = JArray.Parse(response2).ToString();
        ////////////////

        //var zipForecast = zipFor["weather"][3]["description"];
        //JObject obj = JObject.Parse(json);
        //New Code to consider -->  string description = (string)obj["weather"][0]["description"];
        //New Code to consider -->  string description = root.GetProperty("weather")[0].GetProperty("description").GetString();

        //Console.WriteLine($"The weather forecast is: {zipForecast}");


        //Trying to call other info from the API

        //JObject formatResponse = JObject.Parse(response2);

        //var zipResult2 = formatResponse["weather"]["description"];


        //Console.WriteLine($"The forecast is calling for: {zipResult2}");

        //JObject formattedResponse = JObject.Parse(response);

        //var temp = formattedResponse["list"][0]["main"]["temp"];

        //Console.WriteLine($"Current Temp: {temp["main"]["temp"]}");


        //Code to use to convert Temp to Celsisus
        //// Fahrenheit to Celsius conversion calculator
        ////1. Get user input
        //Console.WriteLine("");
        //Console.WriteLine("*******Celsius Conversion*******");
        //Console.WriteLine("Enter Fahrenheit temperature:");

        ////2. Convert user's input from string into 'double' format, so it works as a parameter in the Method's calculations
        //double userFahren = double.Parse(Console.ReadLine());

        ////3. Call the static method created in the class,by using the "Class'sType.StaticProperty = value " syntax
        ////The Method was created within a Class (static Class) in the Project File

        ////4. Store the Method's result in a variable also used in the method.
        ////The variable used in the Method's parameter, was created from the user's input. It also used in the Method's scope.
        //var celsiusAnswer = TempConverter.ConvertFahrenToCel(userFahren);

        ////5. Print the answer to the console
        //Console.WriteLine($"{celsiusAnswer} degrees Celsius");

        //Code from class
        //public static class OpenWeatherMapAPI
        //{
        //    public static void GetUserTemp()
        //    {
        //        //open our appsettings file and grab all the json text
        //        var appsettingsText = File.ReadAllText("appsettings.json");

        //        //parse the appsettings json text into an object so we can grab the api key
        //        var apiKey = JObject.Parse(appsettingsText)["key"].ToString();

        //        //ask the user for their zip code for the url you will create below
        //        Console.WriteLine("Enter ZIP:");

        //        //Store the zip code
        //        var zip = Console.ReadLine();

        //        //build the url from where the api call will come from
        //        var url = $"https://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={apiKey}&units=imperial";

        //        //create an httpclient - this is what will make our api call
        //        var client = new HttpClient();

        //        //api call - send a get request to the url and get back a string of json
        //        var response = client.GetStringAsync(url).Result;

        //        //parse the string of json into an obj so we can index it like an array
        //        var weatherObj = JObject.Parse(response);

        //        //use which parts of the object you need
        //        Console.WriteLine($"Current Temp: {weatherObj["main"]["temp"]}");
        //        Console.WriteLine($"Feels Like: {weatherObj["main"]["feels_like"]}");
        //    }
        //}


        #endregion



    }


















          