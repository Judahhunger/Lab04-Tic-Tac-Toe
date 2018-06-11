using System;
using System.IO;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

       
        static void CreateGameFile(string path, string[] ArraytoWrite)
        {
            
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
    }
}
