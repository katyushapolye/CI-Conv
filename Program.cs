using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using JsonObjects;


namespace ConvIC_1._0_Alpha
{
    static class Program 
    {
        //fix the file create adress <<--
        //add sucess or failure feedback <<--

        public static string FileAdress;
        public static string SaveFileAdress;
       
        
        


        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConvIC());
            

        }

         public static bool RunCovIC(bool IsWeighted) //set parameter for diferent databases, and explict cast the class when performing object calls, or just handle each request diferently
                                //Maybe modify the Json's classes to have an convert function
        {
            ePistolariumObject ePistolariumObject = new ePistolariumObject(FileAdress,Encoding.UTF8);
            ePistolariumObject.ToCSV(ref SaveFileAdress,true,CarryWeigh:IsWeighted);
            return true;
        }
    }
}
