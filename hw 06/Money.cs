using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClass
{
    public class Money
    {
        public int Euro { get; set; }
        public int Cent
        {
            get
            {
                return Cent;
            }
            set
            {
                Cent = value;
                if(Cent >= 100)
                {
                    Cent -= 100;
                    Euro++;
                }
            }
        }

        public double GetTotal()
        {
            return Euro+ Cent/100;
        }
    }

    public class Product : Money
    {
        public void DecreasePrice(int eur, int cent = 0)
        {
            try
            {
                if (Euro < eur || Cent < cent) throw new ArgumentException();
                Euro -= eur;
                Cent -= cent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
