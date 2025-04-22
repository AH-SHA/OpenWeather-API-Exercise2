using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather_API_Exercise2
{
    public static class WeatherAPI
    {
        
        public static void WeatherAPIResult() 
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


                // Invoking the API.JSON code from the Class

                string response = client.GetStringAsync(weatherUrl).Result;

                

                //Best practice to save the result of the parsed API result into its own variable, so that multiple parts of the API can be accessed in different ways

                var infoParse = JObject.Parse(response);

                var zipResult = double.Parse(infoParse["main"]["temp"].ToString());

                var zipCity = infoParse["name"].ToString();

                Console.WriteLine($"The temperature is: {zipResult} degrees Fahrenheit in {zipCity}.");




                // Convert Temp output to Celsius (uses TempCelsius) method

                Console.WriteLine("Would you like the temperature in Celsius? [Type 'y' or 'n'. Then press 'Enter' key.]");
            



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
        } 
    }
}
