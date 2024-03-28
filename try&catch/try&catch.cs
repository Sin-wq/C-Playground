namespace try_catch;
public class InvalidAgeException : Exception{
    public InvalidAgeException(string message) : base(message){}
}
public class TryCatch
{
    static void Main(string[] args)
    {
        try{
            int age;
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            if (age < 18){
                throw new InvalidAgeException("Must be 18");
            }
        }catch(InvalidAgeException ex){
            Console.WriteLine(ex.Message);
        }
        
    }
}
