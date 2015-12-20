using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ItemArrayRecurser
{
    public class ItemArray
    {
        public string Recurse_Round1(string[] strings)
        {
            var output = new StringBuilder();

            foreach (var s in strings)
            {
                output.Append(s);
            }

            return output.ToString();
        }

        public string Recurse_Round2(object[] objectArray)
        {
            var output = new StringBuilder();
            var total = 0;

            foreach (var obj in objectArray)
            { 
                if (obj is int)
                {
                    total = objectArray.OfType<int>().Sum();
                }
                else
                {
                    output.Append(obj);
                }
            }

            return total != 0 ? total.ToString() : output.ToString();
        }
        public string Recurse_Round3(object[] objectArray)
        {
            var output = new StringBuilder();
            var total = 0;

            foreach (var obj in objectArray)
            {
                if (obj is int)
                {
                    total = objectArray.OfType<int>().Sum();
                }
                else
                {
                    output.Append(obj);
                }
            }

//            return total != 0 ? total.ToString() : output.ToString();
            return "I don't know how";
        }
    }
}
