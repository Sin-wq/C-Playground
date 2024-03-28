namespace Bitwise {
    class Bit {
        public static void Byte(){
            uint a = 0b_100 , b = 0b_101, c = a ^ b;
            Console.WriteLine(Convert.ToString(c,  toBase: 2));
        }
    }
}