char[,] abc = {
    { '-', 'A', 'B', 'C', 'D', 'E', 'F' },
    { 'G', 'H', 'I', 'J', 'K', 'L', 'M' },
    { 'N', 'O', 'P', 'Q', 'R', 'S', 'T' },
    { 'U', 'V', 'W', 'X', 'Y', 'Z', '-' }
    };
string alphabet = "";

for (int i = 0; i < abc.GetLength(0); i++)
    {
        for (int j = 0; j < abc.GetLength(1); j++)
        {
            alphabet = alphabet + abc[i,j];
        }
    }

Console.WriteLine(alphabet);