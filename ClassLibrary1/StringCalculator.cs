using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number.Length == 0) return 0;
            if(!number.Contains(',')&&!number.Contains('\n')) return int.Parse(number);
            int wyn = 0;
            var numbers = number.Split(',','\n');
            foreach (string num in numbers)
            {
                int current_number = int.Parse(num);
                if (current_number < 0) throw new ArgumentOutOfRangeException();
                if(current_number<=1000)
                    wyn += int.Parse(num);
            }
            return wyn;

            throw new ArgumentException();
        }
    }
}
