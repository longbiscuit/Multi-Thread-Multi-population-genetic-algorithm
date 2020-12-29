using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    public static class Fitness
    {
        public static double Err;
        //public static double Fit;

       

        /// <summary>
        /// 1.测试函数的误差函数
        /// </summary>
        /// <param name="chrom">parameters</param>
        /// <returns>Error</returns>
        public static double SolveErr(double[] chrom)
        {
            Err = MathTestFunc.TestFunc1(chrom);
            //Err =MathTestFunc.TestFunc2(chrom);
            //Err =MathTestFunc.TestFunc3(chrom);
            //Err = MathTestFunc.TestFunc4(chrom);
            //Err = MathTestFunc.TestFunc5(chrom);
            return Err;
        }




        

    }
}
