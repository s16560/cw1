﻿using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode) {

                string html = await result.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z0-9]+@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);

                MatchCollection matches = regex.Matches(html);

                foreach (var m in matches) {
                    Console.WriteLine(m);
                }

            }

            //JS Promise async/await
            //Java Future
            //C# Task async/await
            Console.WriteLine("test zmiana 3");
            Console.WriteLine("koniec programu");
        }
    }
}
