using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjects
{
    class CheckPower
    {
        public static bool IsYAPowerOfX(int x, int y)
        {
            if(x >= 0 && y >= 0)
            {
                var logY = Math.Log(y);
                var logX = Math.Log(x);

                double floatingPointDivisionResult = logY / logX;                
                int floorOfFloatingPointDivisionResult = (int)floatingPointDivisionResult;
                var diff = floatingPointDivisionResult - floorOfFloatingPointDivisionResult;
                Console.WriteLine(string.Format("Floating point division result: {0}. Integer division result: {1}", floatingPointDivisionResult, floorOfFloatingPointDivisionResult));
                if(diff == 0)
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
