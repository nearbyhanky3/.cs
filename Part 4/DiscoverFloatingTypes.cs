namespace DiscoverFloatingTypes
{
    class None
    {
        public static void none()
        {
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal  : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
            Console.WriteLine("");
            var fNum = 5E2 ;
            Console.WriteLine($"float can be represented using \"e\" notation\n5E2 = {fNum}");
            //5E2 it's mean 5 * 10 ^ 2, so E = 10
        }
    }
}