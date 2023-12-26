//string myString = @"d:\GeekBrain\CharAndArrays\";
Console.WriteLine("Введите строку, содержащую латинские буквы в верхнем и нижнер регистре:");

string myString = Console.ReadLine();
string outStr = bigToSmollChar(myString);

Console.WriteLine($"Начальная строка: {myString}");
Console.WriteLine($"Конечная строка:  {outStr}");

//____________заглавные в строчные
string bigToSmollChar(string arr)
{
    string smollChar = "abcdefghijklmnopqrstuvwxyz";
    string bigChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string outArr = "";

    for (int i = 0; i < arr.Length; i++)
    {
        char ch = arr[i];
        if (bigChar.IndexOf(ch) >= 0)
        {
            outArr = outArr + smollChar[bigChar.IndexOf(ch)];
        }
        else { outArr = outArr + arr[i]; }
    }
    return outArr;
}