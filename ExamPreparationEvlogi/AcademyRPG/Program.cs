using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyRPG
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new ExtendedEngine();
        }

        static void Main(string[] args)
        {
            //var sw = new Strea mWriter("../../output.txt");
            //using (sw)
            //{
                //Console.SetOut(sw);


                Engine engine = GetEngineInstance();

                string command = Console.ReadLine();
                while (command != "end")
                {
                    engine.ExecuteCommand(command);
                    command = Console.ReadLine();
                }
            //}


        }
    }
}
