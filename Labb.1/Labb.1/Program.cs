class Program
{
    static void Main(string[] args)
    {
        string stringToTest = Console.ReadLine();
        string onlyNumbersString = string.Empty;
        long totalCombinationSum = 0;

        foreach (char c in stringToTest)
        {
            if (char.IsDigit(c))
            {
                onlyNumbersString += c;
            }
        }

        //for (int i = 0; i < stringToTest.Length; i++) 
        //{
        //    if (Char.IsDigit(stringToTest[i]))
        //        onlyNumbersString += stringToTest[i];
        //}
        //if (onlyNumbersString.Length > 0)
        //    totalCombinationSum = int.Parse(onlyNumbersString);
        //Console.WriteLine($"Extracted Number: {totalCombinationSum}");

        for (int i = 0; i < onlyNumbersString.Length; i++)
        {
            for (int j = i + 1; j < onlyNumbersString.Length; j++)
            {
                if (onlyNumbersString[i] == onlyNumbersString[j])
                {
                    string comboString = onlyNumbersString.Substring(i, j - i + 1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(comboString);
                    totalCombinationSum += Convert.ToInt64(comboString);
                }

            }
        }
        Console.WriteLine(totalCombinationSum);
    }
}

