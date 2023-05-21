class Program {
    static void Main (string[] args) {
        int alphabet = int.Parse(Console.ReadLine());

        int digits = int.Parse(Console.ReadLine());

        string lastCode = new string('A', alphabet) + new string('0', digits);


        int maximumProduct = (alphabet * 26) * (digits * 10);
        int count = 0;
        
        string items = Console.ReadLine();
        IDictionary<string, string> itemsID = new Dictionary<string, string>();
        itemsID.Add(lastCode, items);

        
    }
}