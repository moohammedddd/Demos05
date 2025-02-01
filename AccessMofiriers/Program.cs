namespace AccessMofiriers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Access Modifiers with inheritance
            ///private not inherited
            ///Internal inherited and accessible within the assembly only 
            ///public inherited and accessible inside outside assembly
            ///private protected inherited as private inside assembly
            ///protected inherited as private inside - outside assembly
            ///Internal protected inherited as internal inside assembly and inherited as private outside assembly

            
            Console.WriteLine("Hello, World!");
            TypeA typeA = new TypeA(10,20,30,40,50);
            typeA.A = 15; // valed
            //typeA.B = 10; // invaled // private
           // typeA.C = 15; // invaled // private
            //typeA.D = 15; // invaled // private
            typeA.E = 15; // valied

            Console.WriteLine(typeA.A);
        
            TypeB typeB = new TypeB(50,60,70,80,10,10,20);
            Console.WriteLine(typeA);
            typeB.A = 15;
            //typeB.B = 15; // not valid because it private
            //typeB.C = 15; // protected // private inside typeB only
            //typeB.D = 15; // private protected // private inside typeB only
            typeB.E = 15;
            typeB.F = 15;
            Console.WriteLine(typeB);
            Console.ReadLine();
        }
    }
}
