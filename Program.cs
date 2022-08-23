/*
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее Задали переменные

// Задали переменные 

int num;
int num2;

// Ввод чисел 

Console.Write("Введите первое число: ");

num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

num2 = Convert.ToInt32(Console.ReadLine());

// Условие

if (num>num2){
    Console.WriteLine("max = " + num);
}

else {
    Console.WriteLine("max = " + num2);

}





// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Задали переменные

int num;
int num2;
int num3;
int max = 0;

// Ввод чисел

Console.Write("Введите первое число: ");

num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

num3 = Convert.ToInt32(Console.ReadLine());

// Условие

if (num>num2){
    num = max;
}

else {
    num2 = max;

}

if (num3>max){
    Console.WriteLine(num3);
}

else {
    Console.WriteLine(max);
}




// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Задали переменные

int num;

// Ввод чисел

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

// Проверка на деление на 2 без остатка

if (num % 2 == 0 ){
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Задали переменные

int N;
int num = 1;

// Ввод числа

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

// Условие

while (num<=N ){
    if(num % 2 == 0)
    {
    Console.Write(num + " ");
    }
    num++; 
}


*/