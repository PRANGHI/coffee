using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] num=Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);
            int money,count=0;
           int x=num[0];
            money=x;
            int p=num[1];
            int cutoff;         
            while(x>1)
            {
                count++;
             money=money*count;
            cutoff=Math.Abs((x*p/100));
            x=x-cutoff;                
            }
            Console.Write(money);
            
        }
    }
}
