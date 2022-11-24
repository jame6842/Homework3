class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> Flower_bunch = new CircularLinkedList<char>();
        while (true){
        Flower_bunch.Add(Flower_bunch_Input());
        int range = Flower_bunch.GetLength()-1;
        if (Flower_bunch.Get(range) != 'J'&&Flower_bunch.Get(range) != 'O'&&Flower_bunch.Get(range) != 'G'&&Flower_bunch.Get(range) != 'R'){
            Flower_bunch.Remove(range);
            Console.Write("All Flower is ");
            for (int i =0 ;i < Flower_bunch.GetLength();i++){
                Console.Write(Flower_bunch.Get(i));
            }
            break;
        }
        else Flower_bunch = Flower_check(Flower_bunch,range);
        }
    }
    static char Flower_bunch_Input (){
        Console.WriteLine("Input Flower");
        char input;
        char.TryParse(Console.ReadLine(), out input);
        return input;
    }
    static CircularLinkedList<char> Flower_check(CircularLinkedList<char> Flower_bunch,int range){
        if (Flower_bunch.Get(range) == 'G'&&Flower_bunch.GetLength()>=4){
                if (Flower_bunch.Get(range) == Flower_bunch.Get(range-1)&&Flower_bunch.Get(range) == Flower_bunch.Get(range-2)&Flower_bunch.Get(range) == Flower_bunch.Get(range-3)){
                    Console.WriteLine("Invalid Pattern");
                    Flower_bunch.Remove(range);    
                }
                else if (Flower_bunch.Get(range) == Flower_bunch.Get(range-1)&&Flower_bunch.Get(range) == Flower_bunch.Get(range-2)&Flower_bunch.Get(range) == Flower_bunch.Get(0)){
                    Console.WriteLine("Invalid Pattern");
                    Flower_bunch.Remove(range);    
                }
                else if (Flower_bunch.Get(range) == Flower_bunch.Get(range-1)&&Flower_bunch.Get(range) == Flower_bunch.Get(0)&Flower_bunch.Get(range) == Flower_bunch.Get(1)){
                    Console.WriteLine("Invalid Pattern");
                    Flower_bunch.Remove(range);    
                }
                else if (Flower_bunch.Get(range) == Flower_bunch.Get(0)&&Flower_bunch.Get(range) == Flower_bunch.Get(1)&Flower_bunch.Get(range) == Flower_bunch.Get(2)){
                    Console.WriteLine("Invalid Pattern");
                    Flower_bunch.Remove(range);    
                }
            }
        if (Flower_bunch.Get(range-1) == 'R'){
            if(Flower_bunch.Get(range) == Flower_bunch.Get(range-2)){
                Console.WriteLine("Invalid Pattern");
                Flower_bunch.Remove(range);  
            }
        }
        return Flower_bunch;
    }
}