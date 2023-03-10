// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();				                                                //  очистка консоли
Console.WriteLine("Введите несколько чисел через пробел и в одну строку: ");	//  запрос числа
string? str = Console.ReadLine();                                               //  строковый ввод
string[] nums = str.Split(new char[] { ' ' });                                  //  разбиение по пробелу строки на массив строк

int result = 0;                                                                 //  накопитель положительных чисел
for (int i = 0; i < nums.Length; i++)                                           //  обход цикла по элементам массива
    if (Convert.ToInt32(nums[i]) > 0) result += 1;                              //  проверка на больше нуля
Console.WriteLine($"Число положительных чисел: {result}");                      //  вывод результата на консоль