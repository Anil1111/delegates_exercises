using System;

namespace FunWithDelegates
{
    public class Thingamabob : IComparable<Thingamabob>
    {
        public int Doohickey { get; set; }
        public string Whatchamacallit { get; set; }

        private static readonly Random RandomGenerator = new Random(DateTime.Now.Millisecond);
        public int CompareTo(Thingamabob other)
        {
            if (RandomGenerator.Next() % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}