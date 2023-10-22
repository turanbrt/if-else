namespace if_else;

class Program
{
    static void Main(string[] args)
    {
        int time=DateTime.Now.Hour;


        if(time<=12 && time>=6){
            Console.WriteLine("Günaydın.");
        }else if(time>12 && time<18){
            Console.WriteLine("iyi günler");
        }else {
            Console.WriteLine("iyi geceler.");
        }

        string sonuc=time<12 ? "Günaydın":"iyi geceler";
        Console.WriteLine(sonuc);

        sonuc=time>6 && time<12 ? "günaydın": time<18 ?"iyi günler":"iyi geceler";
        Console.WriteLine(sonuc); 



    }
    
}
