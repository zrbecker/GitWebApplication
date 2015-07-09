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
                var task1 = client.CreateGitRepositoryAsync("TestRepository");
                var task2 = client.CreateGitRepositoryAsync(string.Format("Test{0}", Guid.NewGuid().ToString()));

                task1.Wait();
                task2.Wait();
                
                Console.WriteLine(string.Format("{0} - \"{1}\"", task1.Result.Status.ToString(), task1.Result.ErrorMessage));
                Console.WriteLine(string.Format("{0} - \"{1}\"", task2.Result.Status.ToString(), task2.Result.ErrorMessage));

                Console.WriteLine(client.CreateGitRepository("TestRepository"));
                Console.WriteLine("Done");
                Console.ReadKey(true);
            }
        }
    }
}