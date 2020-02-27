using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11
{
    public class Theatre
    {
        public int Id { get; set; }
        public string Direction { get; set; }
        public DayOfWeek Day_Of_Week { get; set; }
        public byte Quantity_Of_Seats { get; set; } 
        public Theatre(int id, string dir, DayOfWeek day, byte quan)
        {
            this.Id = id;
            this.Direction = dir;
            this.Day_Of_Week = day;
            this.Quantity_Of_Seats = quan;
        }
    }
}
