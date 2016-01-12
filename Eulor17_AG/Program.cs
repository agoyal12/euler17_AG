using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulor17_AG
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfLettersInNosTillHund ;
            sumOfLettersInNosTillHund = calcUnits() + calcTeens() + calcTens() + calcHundreds() + calcThousands();

            //Console.WriteLine(calcUnits());
            //Console.WriteLine(calcTeens());
            //Console.WriteLine(calcTys());
            
            Console.WriteLine(sumOfLettersInNosTillHund); //54351 -83151 - 95886
            Console.ReadLine();
        }

          static int calcUnits()
        {
            //1-9
            int valueUnits = 3 + 3 + 5 + 4 + 4 + 3 + 5 + 5 + 4; //count of letters in 1-9
            return valueUnits;
        }
        static int calcTeens()
        {
            //10-19
            int valueTeens = 3 + 6 + 6 + 8 + 8 + 7 + 7 + 9 + 8 + 8; //count of letters in 10-19
            return valueTeens;
        }
        static int calcTys()
        {
            //20,30.. will be excluded in grand sum as calcTens include all
            int valueTys = 6 + 6 + 5 + 5 + 5 + 7 + 6 + 6; //count of letters in 20,30,..,90
            return valueTys;
        }
        static int calcTens()
        {
            //20-99
            int valueTens = (calcUnits() * 8) + (calcTys() * 10); //count of letters in : (1-9 in 20,30,..90 )8 times + (20,30,..90 each 10 times)
            return valueTens;
        }
        static int calcHundreds()
        {
            //100-999
            int valueHundreds = 7 * 900 + 3 * 891 + calcUnits() * 100 + calcUnits() * 9 + calcTeens() * 9 + calcTens() * 9;
            //count of letters in : 'hundred' + 'and' + 1-9 in hundredth place of 100,200,300... + 1-9 in units place like 101,102,103..109 + 10-19 in 100,200,300...+ 20-99 in 100,200,300...
            return valueHundreds;
        }
        static int calcThousands()
        {
            //1000
            int valueThousands = 3 + 8; //count of letters in "ONE THOUSAND"
            return valueThousands;
        }
    
    }
}
