using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class JumpingStatement
    {

        //break
        //continue
        //return
        //goto


        bool isDashboardLoaded = false;
      

        public void BreakStatementDemo()
        {



            int i;
            for ( i = 1; i <= 10; i++)
            {

                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.WriteLine("The value of i=" + i);
        }

        public void LoadDashboardInfoFromDB()
        {
            if(isDashboardLoaded ==true)
            {
                return;
            }


            Console.WriteLine("This is loading data from DB");

            ///

            ///

            ///

            ///

            //

            //
            //


        }

        public void DemoOfGotoStatement()
        {
            goto Gottothelinenumber10;

            Console.WriteLine("This will not executive");
            



            Gottothelinenumber10:

            Console.WriteLine("This will executive");
        }


    }
}
