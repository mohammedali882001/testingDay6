using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingDay6
{
    internal class Magazine
    {
        public void NewPlayerJoin(PlayerAddedEventArgs data)
        {
            Console.WriteLine($"new player login and his name : {data.Name} and time {data.Time}");
        }
    }
}
