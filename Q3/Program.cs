class Program {
    static void Main() {
        int alphabet = int.Parse(Console.ReadLine());

        int digits = int.Parse(Console.ReadLine());

        string lastCode = new string('A', alphabet) + new string('0', digits);


        int maxProduct = (alphabet * 26) * (digits * 10);
        int count = 0;
        
        string items = Console.ReadLine();
        IDictionary<string, string> itemsID = new Dictionary<string, string>();
        itemsID.Add(lastCode, items);

        while (true)
        {
            items = Console.ReadLine();

            if (items.ToLower() == "stop")
            {
                break;
            }

            if (count >= maxProduct)
            {
                count = 0;
                lastCode = new string('A', alphabet) + new string('0', digits);
                itemsID.Add(lastCode, items);
                continue;
            }

            string code = NextCode(lastCode, alphabet, digits);
            itemsID.Add(code, items);
            lastCode = code;
        }

        string searchCode = Console.ReadLine();

        bool found = false;
        foreach (KeyValuePair<string, string> kvp in itemsID)
        {
            if (searchCode == kvp.Key)
            {
                Console.WriteLine(kvp.Value);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not found!");
        }
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