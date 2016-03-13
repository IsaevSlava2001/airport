using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace аэропорт
{
   public class passenger_plane:plane
    {
       public passenger_plane(string name,int MSpeed, int MHigh, int Number_of_seats)
        {
            this.name = name;
            this.MSpeed = MSpeed;
            this.MHigh = MHigh;
            this.number_of_seats = Number_of_seats;
        }
       
    }
}
