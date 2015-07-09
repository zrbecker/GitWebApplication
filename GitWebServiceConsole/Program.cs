using GitWebServiceConsole.GitWebService;
using System;

namespace GitWebServiceConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var client = new GitWebServiceClient())
            {
                int number = client.GetNumber();
                Console.WriteLine(number);
                Console.ReadKey(true);
            }
        }
    }
}