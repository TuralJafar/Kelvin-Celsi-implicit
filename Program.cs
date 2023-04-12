 namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Celsius celsius= new Celsius(70);
            Kelvin kelvin= celsius;
            Console.WriteLine(kelvin.kelvinDegree);

        }
    }
   
    }
internal class Celsius
{ public int Degree { get; set; }
    public Celsius(int degree) 
    {
             Degree = degree;
    }
    //public static implicit operator Celsius(Kelvin kelvin)
    //{
    //    return new Celsius(kelvin.kelvinDegree - 273);
    //}
    }
internal class Kelvin
{
        public int kelvinDegree { get; set; }
        public Kelvin(int degree) 
        {
            kelvinDegree= degree;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
        return new Kelvin(celsius.Degree + 273);
        }
 }
  
