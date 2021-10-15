using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public class Calculo : ICalculo
    {
        public int anos(DateTime data)
        {
            return DateTime.Now.Subtract(data).Days / 365;
        }

        public int dias(int anos, DateTime data)
        {
            DateTime form = data.AddYears(anos);
            int dia = 0;
            for (int i = 1; i <= 365; i++)
            {
                if (form.AddDays(i) == System.DateTime.Now)
                {
                    dia = i;
                    break;
                }
                else if (form.AddDays(i) >= System.DateTime.Now)
                {
                    dia = i - 1;
                    break;
                }
            }
            return dia;
        }

        public int meses(DateTime data)
        {
            int Meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (data.AddMonths(i) == System.DateTime.Now)
                {
                    Meses = i;
                    break;
                }
                else if (data.AddMonths(i) >= System.DateTime.Now)
                {
                    Meses = i - 1;
                    break;
                }
            }
            return Meses;
        }
    }
}
