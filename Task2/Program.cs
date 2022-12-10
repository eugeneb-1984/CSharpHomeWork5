/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

//Создаём массив случайных чисел от -999 до 999 из заданного кол-ва элементов
int [] CreateRandomArray(int NumElements) {
    Random rnd = new Random();
    int [] randArray = new int [NumElements];
    for (int i = 0; i < NumElements; i++) {
        randArray [i] = rnd.Next(-1000, 1000);
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

//считаем сумму элементов на нечётных позициях
int SumUnevenElements(int[] targetArray) {
    int sumUneven = 0;
    for (int i = 1; i < targetArray.Length; i +=2) {
        sumUneven += targetArray[i];
    }
    return sumUneven;
}

int numElements = GetNumber("Сколько элементов будет в массиве? ");
int [] randArray = CreateRandomArray(numElements);
Console.WriteLine(PrintArray(randArray));
Console.WriteLine($"Сумма нечётных элементов массива: {SumUnevenElements(randArray)}");
