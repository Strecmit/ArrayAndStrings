Console.WriteLine("Введите несколько слов:");
string myString = Console.ReadLine();

string[] mySplitString = myString.Split(" ");
string temp = "";
int n = mySplitString.Length - 1;
for (int i = 0; i < (mySplitString.Length / 2); i++)
{
    temp = mySplitString[n];
    mySplitString[n] = mySplitString[i];
    mySplitString[i] = temp;
    n--;
}
Console.WriteLine(string.Join(" ", mySplitString));