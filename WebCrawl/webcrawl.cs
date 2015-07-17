﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WebCrawl
{
    class webcrawl
    {
        private static HttpStatusCode responseStatusCode;
        private static string url;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the url you want to test");
            url = Console.ReadLine();
            //url = "http://www.adityanag.com/asfjgahsf";
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

            try
            {
               
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                responseStatusCode = response.StatusCode;
                Console.Write((int)response.StatusCode);
                Console.ReadKey();

            }

            catch (WebException we)
            {
                responseStatusCode = ((HttpWebResponse)we.Response).StatusCode;
                Console.Write((int)responseStatusCode);
                Console.ReadKey();

            }


            
        }
    }
}
