/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

//Принимаем число на ввод
int GetNumber(string message) {
    bool isNumber = false;
    int Number = 0;
    while(!isNumber) {
        Console.Write(message);
        string input = Console.ReadLine();
        if(Int32.TryParse(input, out Number)) {
            isNumber = true;
        }
        else {
            Console.WriteLine("Вы ошиблись при вводе. Введите число.");
        }
    }
    return Number;
}

//Создаём массив случайных чисел от 0 до 999 из заданного кол-ва элементов
int [] CreateRandomArray(int NumElements) {
    Random rnd = new Random();
    int [] randArray = new int [NumElements];
    for (int i = 0; i < NumElements; i++) {
        randArray [i] = rnd.Next(0, 1000);
    }
    return randArray;
}

//выводим числа в массиве на экран (для проверки)
string PrintArray (int [] targetArray) {
    int len = targetArray.Length;
    string result = "[";
        for (int i = 0; i < len - 1; i++) {
        result += $"{targetArray[i]}, ";
        }
    result += targetArray[len-1] + "]";
    return result;
}

//выводим разницу max - min элементов массива
void FindMinMaxDiff(int[] targetArray) {
    int min = targetArray[0];
    int max = targetArray[0];
    for (int i = 1; i < targetArray.Length; i++) {
        if (targetArray[i] < min) min = targetArray [i];
        if (targetArray[i] > max) max = targetArray [i];
    }
    int diff = max - min;
    Console.WriteLine($"Максимум: {max}");
    Console.WriteLine($"Минимум: {min}");
    Console.WriteLine($"Разница: {diff}");
}

int numElements = GetNumber("Сколько элементов будет в массиве? ");
int [] randArray = CreateRandomArray(numElements);
Console.WriteLine(PrintArray(randArray));
FindMinMaxDiff(randArray);