using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICalculo
    {
        int meses(DateTime data);
        int dias(int anos, DateTime data);
        int anos(DateTime data);
    }
}
