using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingDay6
{
    internal class Journalist //: ISubscriber
    {
        //void ISubscriber.Notify()
        //{
        //    Console.WriteLine("jornalist subscribed sccessfully");
        //}

        public void PlayerAddNotify(PlayerAddedEventArgs data)
        {
            Console.WriteLine($"hi jornalist there are" +
                $" a plyer added on the club and his name is : {data.Name} and time {data.Time}");
        }
    }
}
