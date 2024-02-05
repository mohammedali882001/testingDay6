using System.Threading.Channels;

namespace testingDay6
{
    internal class Program
    {
        delegate bool MyDelegate(int item);

        static bool isPositive(int x)
        {
            return x > 0;
        }

        static bool isEven(int x)
        {
            return x %2== 0;
        }
        #region Trying to simulate delegate
        //public static void FilterPositave(IEnumerable<int> list)
        //  {
        //      foreach (int i in list)
        //      {
        //          if(isPositive(i))
        //              Console.WriteLine(i);
        //      }
        //  }

        //public static void FilterPositave(IEnumerable<int> list,int typeOfCheck)
        //{
        //    foreach (int i in list)
        //    {
        //        if (typeOfCheck==0)
        //           isPositive(i);
        //        ////////CW
        //        if (typeOfCheck == 1)
        //            //isOdd(i)
        //            ////
        //            ///وهكذا
        //    }
        //}

        //public static void Filter(IEnumerable<int> list, ICheckable checkable)
        //{
        //    foreach (int i in list)
        //    {
        //        if (checkable.Check(i))
        //            Console.WriteLine(i);
        //    }
        //} 
        #endregion


        static void Filter(IEnumerable<int> list,MyDelegate dell)
        {
            foreach (int i in list)
            {
                if (dell(i))
                    Console.WriteLine(i);
            }
        }

        static void Filter2(IEnumerable<int> list, Predicate<int> dell)
        {
            foreach (int i in list)
            {
                if (dell(i))
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            #region sinulate Delegate
            //List<int> list = new List<int>()
            //{ 
            //    1, 2, -3, -4, 5,-6, -7, 8, 9, -10,
            //};
            //foreach (int i in list) {
            //    Console.WriteLine(i);
            //}
            // PositiveChecakble p=new PositiveChecakble();
            // Filter(list,p);
            //Filter(list); 
            #endregion

            #region Delegate
            //List<int> list = new List<int>()
            //{
            //    1, 2, -3, -4, 5,-6, -7, 8, 9, -10,
            //};

            //MyDelegate del1 = new MyDelegate(isPositive);
            //MyDelegate del2 = new MyDelegate(isEven);

            // Filter(list, del1);
            // Filter(list, del2);

            //bool flag = del1.Invoke(5);
            //bool flag2 = del1(-5);
            //Console.WriteLine(flag2);

            //MyDelegate del3 = new MyDelegate(Helper.isOdd);
            //Filter(list, del3);

            //Helper helper = new Helper() {ID=1 };
            //Helper helper2 = new Helper() {  ID=2 };
            //MyDelegate del4 = new MyDelegate(helper.isNegative);
            //Filter(list, del4);
            //MyDelegate del5 = helper2.isNegative;//== new MyDelegate(helper2.isNegative);
            //Filter(list, del5);
            //Filter(list, isEven);
            //Filter(list, new MyDelegate(isEven));


            //bool flag3 = del4(-5);
            //Console.WriteLine(flag3);
            //bool flag4 = del5(-5);
            //Console.WriteLine(flag4);



            //Filter(list, 
            //    delegate (int item)
            //    {
            //        return item > 0;
            //    }

            //);

            //Filter(list , item => item<0);

            //Filter2 (list , item => item<0);

            //Func<double> d = () => 1.02;
            //Console.WriteLine(d);

            //Func<int,string>dd =  x => x.ToString();
            //Console.WriteLine(dd(10));

            //Action<int> a = x => Console.WriteLine(x);
            //a(10);

            //Action b = () => Console.WriteLine("leo");
            //b();

            //Predicate<int> dell = isPositive;
            //dell += isEven;
            //dell -= isPositive;
            //Console.WriteLine(dell(5)); 
            #endregion

            SportsClub alAhly = new SportsClub() { Name="Alahly"};
           

            Journalist journalist = new Journalist();
            Magazine magazine = new Magazine();
            Journalist journalist1 = new Journalist();
            // alAhly.AddSubscriber(journalist);
            alAhly.PlayerAdded += journalist.PlayerAddNotify;
            //alAhly.PlayerAdded -= journalist.PlayerAddNotify;

            alAhly.PlayerAdded += magazine.NewPlayerJoin;
            //alAhly.PlayerAdded = null;//journalist1.PlayerAddNotify;
            alAhly.AddPlayer("mohammed Ali");
            alAhly.Display();

        }
    }
}
