using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSecretToken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The secret token is {Constants.Secret}");
        }
    }
}
