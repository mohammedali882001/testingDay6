using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingDay6
{
    internal class SportsClub
    {
        List<string>players = new List<string>();
        // List<Journalist>journalists = new List<Journalist>();
        //List<ISubscriber> subscribers = new List<ISubscriber>();
        public event Action<PlayerAddedEventArgs> PlayerAdded;
        public string Name {  get; set; }
        public void AddPlayer(string name)
        {
            players.Add(name);
            if (PlayerAdded == null)
                return;
            PlayerAdded(new PlayerAddedEventArgs()
            {
                Name = name,
                Time = 10
            }); ;
            //foreach (ISubscriber subscriber in subscribers)
            //{
            //    subscriber.Notify();
            //}
        }

        //public void AddSubscriber(ISubscriber subscriber)
        //{
        //    subscribers.Add(subscriber);
        //}

        public void Display()
        {
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
