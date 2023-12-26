Console.WriteLine("Введите строку:");

string myString = Console.ReadLine();
int n = myString.Length - 1;
bool check = false;
for (int i=0; i < (myString.Length /2); i++){
    if (myString[i] == myString[n]) {check = true; n--;}
    else {check = false; break;}
}
if (check) {
    Console.WriteLine("Да, вы ввели палиндром!");
}
else {
    Console.WriteLine("Упс... Ошибочка!");
}