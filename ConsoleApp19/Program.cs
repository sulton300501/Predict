namespace ConsoleApp19
{
    internal class Program
    {



        public delegate TResult Func<in item1, in item2, out TResult>(item1 arg, item2 arg2);

        static void Main(string[] args)
        {





            Action myDekegate = () =>
            {
                int sum2 = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum2 += i;
                }

                Console.WriteLine(sum2);



            };


            Action<int> myDeke = delegate (int x)
            {

                int sum = 0;
                for (int i = 0; i < x; i++)
                {
                    sum += i;
                }

                Console.WriteLine(sum);


            };



            Predicate<Tuple<int, int, int>> isUchburchak = isTriangle;

            Tuple<int,int,int> x = new Tuple<int,int,int>(3,4,5);

            Console.WriteLine(isUchburchak(x));
        }

        static bool isTriangle(Tuple<int, int, int> myTuple)
        {
            if (Math.Pow(myTuple.Item1, 2) + Math.Pow(myTuple.Item2, 2) == Math.Pow(myTuple.Item3, 2))
            {
                return true;
            }
            return false;

        }






        static void Add()
        {
            Console.WriteLine("Mening methodim ishlayapti...");
        }

        static int Add2()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }
            return sum;
        }





    }
}


