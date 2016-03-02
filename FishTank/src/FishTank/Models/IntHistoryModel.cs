using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTank.Models
{
    public class IntHistoryModel
    {
       

        public IntHistoryModel(DateTime timestamp, int value)
        {
            TimeStamp = timestamp;
            Value = value;
        }

        public DateTime TimeStamp { get; private set; }
        public int Value { get; private set; }
    }
}
