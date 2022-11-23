class Program
{
    static void Main(string[] args)
    {

        CircularLinkedList<char> Flower_bunch = new CircularLinkedList<char>();
        while(true){
            Console.WriteLine("InputFlower");
            Flower_bunch.Add(char.Parse(Console.ReadLine()));
            int range = Flower_bunch.GetLength()-1;
            if (Flower_bunch.Get(range) != 'J'&&Flower_bunch.Get(range) != 'G'&&Flower_bunch.Get(range) != 'R'&&Flower_bunch.Get(range) != 'O' ){
                Console.WriteLine("All Flower");
                Flower_bunch.Remove(range);
                for (int i =0; i<Flower_bunch.GetLength(); i++){
                    Console.Write(Flower_bunch.Get(i));
                }
                break;
            }
            else if (Flower_bunch.Get(range) == 'R'){
                    if (Flower_bunch.Get(range-1)==Flower_bunch.Get(0)){
                        Console.WriteLine("Invalid pattern");
                        Flower_bunch.Remove(range);
                    }
            }
            else if (Flower_bunch.Get(range-1) == 'R'){
                    if (Flower_bunch.Get(range) == Flower_bunch.Get(range-2)){
                        Console.WriteLine("Invalid pattern");
                        Flower_bunch.Remove(range);
                    }
            }
            else if(Flower_bunch.GetLength() >=4 ){
                if(Flower_bunch.Get(range)=='G'){
                    if(Flower_bunch.Get(range) == Flower_bunch.Get(range-1) && Flower_bunch.Get(range) ==   Flower_bunch.Get(range-2) && Flower_bunch.Get(range) == Flower_bunch.Get(range-3)){
                        Console.WriteLine("Invalid pattern");
                        Flower_bunch.Remove(range);
                    }
                }
            }
        }
    }
}
        
    
