class Program {
    static void Main (string[] args) {
        int alphabet = int.Parse(Console.ReadLine());
        int digits = int.Parse(Console.ReadLine());
        
        int count = 0;
        string lastCode = new string('A', alphabet) + new string('0', digits);
        int maxProduct  = (alphabet*26) + (digits*10);
        
        string items = Console.ReadLine();
        IDictionary<string, string> itemsID = new Dictionary<string, string>();
        itemsID.Add(lastCode, items);

        while(true) {
        items =  Console.ReadLine();
        
        if(items == "Stop") {
            break;
        }

        if(count >= maxProduct) {
        count = 0;
        lastCode = new string('A', alphabet) + new string('0', digits);
        maxProduct  = (alphabet*26) + (digits*10);
        continue;
        }

        string code = NextCode(lastCode, alphabet, digits);
        itemsID.Add(code, items);
        lastCode = code;
        }

        string itemsCode = Console.ReadLine();
    }

    static string NextCode(string code, int alphabet, int digits)
    {
        char[] codeArray = code.ToCharArray();
        int lastIndex = alphabet + digits - 1;

        for (int i = lastIndex; i >= 0; i--)
        {
            char c = codeArray[i];

            if (char.IsDigit(c))
            {
                if (c == '9')
                {
                    codeArray[i] = '0';

                    if (i == 0)
                    {
                        return null;
                    }
                }
                else
                {
                    codeArray[i] = (char)(c + 1);
                    break;
                }
            }
            else if (char.IsLetter(c))
            {
                if (c == 'Z')
                {
                    codeArray[i] = 'A';
                }
                else
                {
                    codeArray[i] = (char)(c + 1);
                    break;
                }
            }
        }
        return new string(codeArray);
    }
}