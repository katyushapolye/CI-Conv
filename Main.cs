using System;
using System.Threading;
using System.Text;
using JsonObjects;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string FileAdress;
            string OutPutAdress;
            Console.ForegroundColor = ConsoleColor.Red;
            if (args.Length == 0 || args.Length > 2)
            {
                Console.WriteLine("Incorret Arguments Were Passed, Type -h to see Usage");
                Thread.Sleep(1000);
                return;
            }
            if (args[0] == "-h" || args[0] == "-help")
            {
                //Show Help
                Console.WriteLine("Help.txt", Environment.NewLine);
                Thread.Sleep(1000);
                return;
                

            }
            FileAdress = args[0];
            OutPutAdress = args[1];


            //Debugging
            Console.WriteLine(FileAdress);
            ePistolariumObject ePistolariumObject = new ePistolariumObject(FileAdress, Encoding.UTF8);
            Console.WriteLine(FileAdress);
            Console.WriteLine(ePistolariumObject.Network.links[0]);
            Console.WriteLine(ePistolariumObject.RawJson);
            ePistolariumObject.ToCSV(ref OutPutAdress,false);
            



        }

    }


   
}








