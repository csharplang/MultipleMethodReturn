using System;

namespace MultiMethodParameters
{
    public class Helper
    {
        public Tuple<string, string> TwoParaeter()
        {
            var _Tuple = Tuple.Create("Microsoft", "Apple");
            return _Tuple;
        }

        public Tuple<Int64, Int64, Int64, Int64> Caculation(Int64 Item1, Int64 Item2)
        {
            if (Item1 > Item2)
                return Tuple.Create(Item1 + Item2, Item1 - Item2, Item1 * Item2, Item1 / Item2);
            return Tuple.Create(Item1 + Item2, Item2 - Item1, Item1 * Item2, Item2 / Item1);
        }

    }
}
