using System;
using System.Collections.Generic;
namespace Bo_Han_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileUtil fileIO = new FileUtil();
            List<string> stocksWritten = new List<string>();

            //Write stock state to csv file
            stocksWritten.Add("1, 151.1, GOOGLE, Google Inc");
            stocksWritten.Add("2, 200.1, IBM, IBM Inc");
            stocksWritten.Add("3, 35.2, INTEL, Intel Holdings");
            stocksWritten.Add("4, 100, STATE STREET, State Street Inc");
            stocksWritten.Add("5, 15.1, AMAZON, Amazon Inc");
            stocksWritten.Add("6, 75.2, ORACLE, Oracle Corporation");
            stocksWritten.Add("7, 30, FACEBOOK, Facebook Inc");
            stocksWritten.Add("8, 230, TWITTER, Twitter Inc");
            stocksWritten.Add("9, 50, INSTAGRAM, Instagram Inc");
            stocksWritten.Add("10, 90, SAP, SAP Inc");
            fileIO.WriteAll("stock", stocksWritten);

            //Read from csv file, and store the stocks in the List
            List<string> stocksRead = fileIO.ReadAll("stock");
            List<Stock> stocks = new List<Stock>();
            char delimiter = ',';
            foreach(string stock in stocksRead) {
                string[] values = stock.Split(delimiter);
                Stock s = new Stock(Int32.Parse(values[0]), Double.Parse(values[1]), values[2], values[3]);
                stocks.Add(s);
            }

            //Set the random number and print the state of each stock
            Random random = new Random();
            int randomNum = 0;
            foreach (Stock s in stocks) {
                randomNum = random.Next(-100, 100);
                Console.WriteLine(s.ToString());
                Console.WriteLine("set the price " + randomNum + " percent change, and after change the price for the stock is: ");
                s.Update(randomNum);
                Console.WriteLine(s.ToString());
                Console.WriteLine("\r\n");
            }

        }
    }
}
