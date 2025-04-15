// See https://aka.ms/new-console-template for more information




using Newtonsoft.Json.Linq;
using OpenWeather_API_Exercise2;

public class Program
{

    
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a valid US zip code:");

        //Store the zip Code
        var zip = Console.ReadLine();


        if (zip == null)
        {
            Console.WriteLine("Enter a valid US zip code:");
        }
        else
        {

            //Create the HttpClient, which is the first element needed in order to make calls with an API

            var client = new HttpClient();

            // builit-in methods 'File" and "ReadAllText()"  ReadAllText returns a "string" format

            var appsettingsText = File.ReadAllText("appsettings.json");



            //Parse the JSON into an object, so we can grab the value assigned to 'key'

            var apiKey = JObject.Parse(appsettingsText)["key"].ToString();




            // to hide the ApiKey, put it inside an interpolated string
            //To get started using the API, from the API documentation, pick the method you want to use

            //since we have selected the "zip code" method, pmompt the user to enter it and store it in a varibale


            //Build a URL using ThreadExceptionEventArgs HTML where the API call is from
            //then, select the relevt HTML text and enclose it in quotes " " preceded by $
            //replce "appID" in the HTML string with the APIKEy

            //put the variable with the user input into the correct place in the API's HTML string
            //put the variable created to contain the API KEy into the correct place in the API's Html string

            var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?zip={zip}&units=imperial&appid={apiKey}";

            //send "get" request, using the HttpClient.  Send the GET request to the URL created above
            //GetStringAsync is the get request sent to the URl for the weather mapp site

            var response = client.GetStringAsync(weatherUrl).Result;

            //var response2 = client.GetStringAsync(weatherUrl).Result;

            //Best practice to save the result of the parsed API result into its own variable, so that multiple parts of the API can be accessed in different ways

            var infoParse = JObject.Parse(response);


            var zipResult = double.Parse(infoParse["main"]["temp"].ToString());

            var zipCity = infoParse["name"].ToString();

            Console.WriteLine();
            Console.WriteLine($"The temperature is: {zipResult} degrees Fahrenheit in {zipCity}.");

            Console.WriteLine();


            
            // Convert Temp output to Celsius

            Console.WriteLine("Would you like the temperature in Celsius? [Type 'y' or 'n'. Then press 'Enter' key.]");
            Console.WriteLine();

            var celQuestion = (Console.ReadLine()).ToLower();


            if (celQuestion == "n")
            {
                Console.WriteLine("Have a nice weather day!");
            }
            else
            {
                /////double userFahren = double.Parse(Console.ReadLine());
                var celsiusAnswer = TempCelsius.ConvertFahrenToCel(zipResult);


                //    Print the answer to the console
                Console.WriteLine();
                Console.WriteLine($"That is {celsiusAnswer} degrees in Celsius. Have a nice weather day!");
                Console.WriteLine();
            }

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








}









          