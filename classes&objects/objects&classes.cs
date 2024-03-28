using System;
namespace classesnobjects{
	class RegularClass{
		public RegularClass(int x, int y){
			System.Console.WriteLine(x+y);
		}
	}
    abstract class AbsExample{
	    abstract public void force();
    }
    partial class ParExample:AbsExample{
        public override void force(){
            Console.WriteLine("abstract method inside ParExample");
        }
        public void FirstPar(){
            Console.WriteLine("from FirstPar method");
        }
    }
    partial class ParExample{
        public void SecondPar(){
            Console.WriteLine("from SecondPar method");
        }
    }
    sealed class SealExample : AbsExample{
        public override void force(){
            Console.WriteLine("abstract method inside seal example");
        }
        public void Message(){
            Console.WriteLine("from sealed method");
        }
    }
    static class StaticExample{
        public static void Message(){
            Console.WriteLine("from static method");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            classesnobjects.RegularClass reqExample = new RegularClass (5,15);
            ParExample parExample = new ParExample();
            parExample.FirstPar();
            parExample.SecondPar();
            parExample.force();
            SealExample sealExample = new SealExample();
            sealExample.Message();
            sealExample.force();
            StaticExample.Message();
        }
    }
}
