class Program {
    static void Main (string[] args) {
        int alphabet = int.Parse(Console.ReadLine());
        int digits = int.Parse(Console.ReadLine());
        
        string lastCode = new string('A', alphabet) + new string('0', digits);
        int maxProduct  = (alphabet*26) + (digits*10);
        string items = Console.ReadLine();
        
        /*while(true) {
        string items =  Console.ReadLine();
        if(items == "Stop") {
            break;
        }
        }

        string itemsCode = Console.ReadLine();*/
    }

    static int Numbers(int num, int now) {
        if(now == 0) {
        
        if(num < 9) {num += 1;}
        
        else if(num == 9) {num = 0;}
        }
        return num;
    }
    /*static string Items(string items) {

    }*/
}