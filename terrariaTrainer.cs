using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace DEMO 
{
    class Program
    {
        public static int offset =0x3E4;

        public static int baseNum = 0;
        

        static void Main(string[] args)
        {
            string val;
            Console.Write("Please input base value found in cheat engine (include 0x at the start)");
            val = Console.ReadLine();
            baseNum = Convert.ToInt32(val , 16);
            VAMemory vam = new VAMemory("Terraria");
            int local = vam.ReadInt32((IntPtr)baseNum+offset);
            
            while(true)
            {
                
                vam.WriteInt32((IntPtr)baseNum+offset, 999);
                Thread.Sleep(100);
            }
            


        }
    }

}




