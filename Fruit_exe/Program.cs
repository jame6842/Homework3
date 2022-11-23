class Program
{
    static void Main(string[] args)
    {
        Queue<char> fruit = new Queue<char>();
        Queue<int> each_fruit = new Queue<int>();
        while(true) {
            char fruit_cal = char.Parse(Console.ReadLine());
            if(fruit_cal == 'S'||fruit_cal == 'M'||fruit_cal == 'L' ){
                fruit.Push(fruit_cal);
            }
            else break;
        }
        for(int i = 0 ; i<fruit.GetLength(); i++){
            if (fruit.Get(i) == 'L'){
                fruit.Push('M');
                fruit.Push('M');
            }
            else if (fruit.Get(i) == 'M'){
                fruit.Push('S');
                fruit.Push('S');
                fruit.Push('S');
            } 
        }
        for(int i = 0 ; i<fruit.GetLength(); i++){
            if (fruit.Get(i) == 'S'){
                each_fruit.Push(3);
            }
            else if (fruit.Get(i) == 'M'){
                each_fruit.Push(2);
            }
            else if (fruit.Get(i) == 'L'){
                each_fruit.Push(1);
            }
        }
        for (int i = 0 ; i<each_fruit.GetLength();i++){
            Console.Write(each_fruit.Get(i));
        }
    }
}