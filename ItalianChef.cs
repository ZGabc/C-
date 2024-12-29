using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ItalianChef : Chef
    {       
        public void MakePasta(string type)
        {
            Console.WriteLine($"Chef makes {type}");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes ChickenAlfredo");
        }

    }
}
