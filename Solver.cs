using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tmds.DBus.Protocol;

namespace AvaloniaCalc
{
    public class Solver : ISolve
    {
        public List<string> numberList = new List<string>();

        public string wholeThing = "", WT = "";

        public double wholeDouble;

        public string operators = "";

        public void Accumulate(string s)
        {
            wholeThing += s;
        }
        public void Clear()
        {
            wholeThing = "";
        }

        // i could only get it to do an operation on 2 numbers at most i am so sorry :(
        public double Solve()
        {
            foreach (char c in wholeThing)
            {
                switch (c)
                {
                    case '+':
                        double firstNumAdd = double.Parse(wholeThing.Substring(0, wholeThing.IndexOf("+")));
                        double secondNumAdd = double.Parse(wholeThing.Substring(wholeThing.IndexOf("+") + 1));

                        wholeDouble = firstNumAdd + secondNumAdd;
                        break;
                    case '-':
                        double firstNumSub = double.Parse(wholeThing.Substring(0, wholeThing.IndexOf("-")));
                        double secondNumSub = double.Parse(wholeThing.Substring(wholeThing.IndexOf("-") + 1));

                        wholeDouble = firstNumSub - secondNumSub;
                        break;
                    case '*':
                        double firstNumMult = double.Parse(wholeThing.Substring(0, wholeThing.IndexOf("*")));
                        double secondNumMult = double.Parse(wholeThing.Substring(wholeThing.IndexOf("*") + 1));

                        wholeDouble = firstNumMult * secondNumMult;
                        break;
                    case '/':
                        double firstNumDiv = double.Parse(wholeThing.Substring(0, wholeThing.IndexOf("/")));
                        double secondNumDiv = double.Parse(wholeThing.Substring(wholeThing.IndexOf("/") + 1));

                        wholeDouble = firstNumDiv / secondNumDiv;
                        break;
                    case '%':
                        double firstNumMod = double.Parse(wholeThing.Substring(0, wholeThing.IndexOf("%")));
                        double secondNumMod = double.Parse(wholeThing.Substring(wholeThing.IndexOf("%") + 1));

                        wholeDouble = firstNumMod % secondNumMod;
                        break;
                }
            }

            return 0;
        }
    }
}
