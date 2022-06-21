
namespace FloatingDataTypes
{
    class EntryPoint
    {
        static void Main()
        {
            float someFloatNumber = 21356643246890876543.1546664656132336974f;
            //2.135664E+19 means 2.135664 * 10^19 
            System.Console.WriteLine(someFloatNumber.ToString("f"));

            float radius = 5f;
            float pi = 3.14f;
            float areaOfCircle = pi * radius * radius;

            System.Console.WriteLine(areaOfCircle);

            float fMax = float.MaxValue;
            float fMin = float.MinValue;

            System.Console.WriteLine(fMin.ToString("f"));
            System.Console.WriteLine(fMax.ToString("f"));
            //float has lower precision

            double dVariable = 3.14d;

            double dMax = double.MaxValue;
            double dMin = double.MinValue;

            System.Console.WriteLine(dMax.ToString("f"));
            System.Console.WriteLine(dMin.ToString("f"));

            decimal decMax = 56846.85478563214963251425878965445878789896541235489m;
            decimal decMin = decimal.MinValue;

            System.Console.WriteLine(decMin);
            System.Console.WriteLine(decMax);

            // difference is b/w precision float has 7, double has 15 and decimal has 24 and decimal does not add additional zeros

            System.Console.ReadLine();
        }
    }
}
