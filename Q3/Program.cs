class Program {
    static void Main (string[] args) {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        
        char[] alphabetCode = new char[m];
        int[] numberCode = new int[n];

        for(int i = 0; i<m ;i++) {
            alphabetCode[i] = 'A';
        }

        for(int i = 0; i<n ;i++) {
            numberCode[i] = 0;
        }

       Console.WriteLine("{0}", ); 
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