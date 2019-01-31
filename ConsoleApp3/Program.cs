using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside Ontario = new Countryside();
            Ontario.run();
        }
        class Village
        {
            public static int numberofvillages = 0;
            public Village nextvillage;
            public Village previousvillage;
            public string Villagename;
            public bool isAstrildeHere = false;
            public Village()
            { Village.numberofvillages++; }
        }
        class Countryside
        {
            public Village Maple;

            public Village Toronto;
            public Village Ajax;
            public Village Head;
            public Village Tail;
            public Village Temp;
            public void run()
            {
                this.MapInitializer();
                this.LookForAstrilde();
            }
            public void MapInitializer()
            {
                Maple = new Village();
                Maple.Villagename = "Maple";
                Maple.previousvillage = null;
                Maple.isAstrildeHere = true;
                Toronto = new Village();
                Toronto.Villagename = "Toronto";
                Toronto.previousvillage = null;
                Ajax = new Village();
                Ajax.Villagename = "Ajax";
                Ajax.nextvillage = null;
                Ajax.previousvillage = Toronto;
                /*Ajax.isAstrildeHere = true*/





            }
            public void LookForAstrilde()
            {
                Head = Maple;
                if (Head.isAstrildeHere)
                {
                    Console.WriteLine("Yeah! Astrilde is in " + Head.Villagename);
                }
                //while(true)
                //{

                //}
            }
        }
    }
}