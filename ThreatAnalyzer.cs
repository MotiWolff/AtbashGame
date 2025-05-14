using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    internal class SeverityReporter

    {
        public void Severity(string text, int score)
        {
            switch (score)
            {
                case <= 5:
                    text = text + "\n***WARNING***";
                    break;
                case <= 10:
                    text = text + "\n***DANGER!***";
                    break;
                case <= 15:
                    text = text + "\n***“ULTRA ALERT!***";
                    break;
                default:
                    Console.WriteLine("Invalid score");
                    break;
            }
            Console.WriteLine(text + " " + Convert.ToString(score) + " points");
        }
    }
}
