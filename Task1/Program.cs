/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

//Создаём массив случайных чисел от 1 до 999 из заданного кол-ва элементов
int [] CreateRandomArray(int NumElements) {
    Random rnd = new Random();
    int [] randArray = new int [NumElements];
    for (int i = 0; i < NumElements; i++) {
        randArray [i] = rnd.Next(0, 1000);
    }
    return randArray;
}

//Считаем кол-во чётных чисел в массиве
int ShowEvenElements(int[] targetArray) {
    int evenElements = 0;
    for (int i = 0; i < targetArray.Length; i++) {
        if (targetArray[i] % 2 == 0) evenElements++;
    }
    return evenElements;
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

int arrayElementsQty = GetNumber("Сколько элементов должно быть в массиве? ");
int [] numArray = CreateRandomArray(arrayElementsQty);
Console.WriteLine (PrintArray(numArray));
Console.Write($"Чётных чисел в массиве: {ShowEvenElements(numArray)}");


