
using System;

namespace IntegerDataTypes
{
    class EntryPoint
    {
        static void Main()
        {
            int someInteger = 256;
            // Integer -> 2^32
            int intMax = int.MaxValue;
            int intMin = int.MinValue;

            System.Console.WriteLine(intMax);
            System.Console.WriteLine(intMin);

            uint someUInteger = 5;

            uint uIntMax = uint.MaxValue;
            uint uIntMin = uint.MinValue;

            System.Console.WriteLine(uIntMin);
            System.Console.WriteLine(uIntMax);

            Console.WriteLine(Math.Pow(2, 32));

            byte someByte = 255;

            byte byteMax = byte.MaxValue;
            byte byteMin = byte.MinValue;

            System.Console.WriteLine(byteMin);
            System.Console.WriteLine(byteMax);

            sbyte sByteMax = sbyte.MaxValue;
            sbyte sByteMin = sbyte.MinValue;

            System.Console.WriteLine(sByteMin);
            System.Console.WriteLine(sByteMax);

            long minLong = long.MinValue;
            long maxLong = long.MaxValue;

            Console.WriteLine(minLong);
            Console.WriteLine(maxLong);

            ulong minULong = ulong.MinValue;
            ulong maxULong = ulong.MaxValue;

            Console.WriteLine(minULong);
            Console.WriteLine(maxULong);


            Console.ReadLine();       

        }
    }
}
