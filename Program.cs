// ПРограмма, которая принимает массив строк
// и затем сама формирует массив из строк, длина которых
// менее 3-х символов. Первоначальный массив вводим с клавы,
// а затем работает алгоритм.

Console.WriteLine("Пожалуйста, укажите, сколько строк будет в вашем массиве строк =>");
int n = int.Parse(Console.ReadLine());
string[] juststring = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент массива отличный от нуля, пожалуйста => ");
    juststring[i] = Console.ReadLine();
}

 Console.WriteLine("Вот какие строки вы ввели: ");

 for (int i = 0; i < n; i++)
{
    Console.Write(juststring[i] + " ");
}
Console.WriteLine();

//хотел сделть два метода: для того, что выше (забор массива у пользователя и его печать), оно прямо так и упаковывается, 
//но почему-то не смог массив упаковать в переменную на выходе - очень странно.
//ну и второй метод для того, что ниже, то есть для отработки условия задачи

string[] lessThreeLettersArray = new string[n];
for (int i = 0; i < juststring.Length; i++)
{
    for (int j = 0; j < lessThreeLettersArray.Length; j++)
    {
        if (juststring[i].Length <= 3)
        lessThreeLettersArray[j] = juststring[i];
        
    }
    Console.Write(lessThreeLettersArray[i] + " ");
}
