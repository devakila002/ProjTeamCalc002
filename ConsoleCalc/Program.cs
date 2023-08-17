public class ConsoleCalc {
    public static void Main(string[] args){
        int result = Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]);
        System.Console.WriteLine("Your result is " + result.ToString());
    }
}
