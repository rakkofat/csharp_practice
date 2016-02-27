// 6 * 21 = 126
// 6 and 21 would be valid 'fangs' for a vampire number as the 
// digits 6, 1, and 2 are present in both the product and multiplicands

// 10 * 11 = 110
// 110 is not a vampire number since there are three 1's in the
// multiplicands, but only two 1's in the product

// This is really ugly...

static class Kata
    {
        public static bool vampire_test(long x, long y)
        {
            var xStr = x.ToString();
            var yStr = y.ToString();
            var numStr = xStr + yStr;
            // string[] xyAry = numStr.Split();
            char[] xyAry = numStr.ToCharArray();
            Array.Sort(xyAry);
            var prodStr = (x * y).ToString();
            // string[] prodAry = prodStr.Split();
            char[] prodAry = prodStr.ToCharArray();
            Array.Sort(prodAry);
            numStr = new string(xyAry);
            prodStr = new string(prodAry);
            return numStr == prodStr;
        }
    }

using System.Linq;

static class Kata
{
    public static bool vampire_test(long x, long y)
    {
        return (x * y).ToString().OrderBy(c => c).SequenceEqual((x.ToString() + y).OrderBy(c => c));
    }
}

using System;
static class Kata{
  public static bool vampire_test(long x, long y){
    long z = x * y;
    char[] arr1 = z.ToString().ToCharArray();
    char[] arr2 = (x.ToString() + y.ToString()).ToCharArray();
    Array.Sort(arr1);
    Array.Sort(arr2);
    return ((new string(arr1)) == (new string(arr2)));
  }
}
