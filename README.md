int[] array = new int[] {1, 42, 49, 45, 70, 69, 80, 74, 82, 91 }; тут я создал массив из чисел, который придумал сам.

var str = string.Join(" ", array); тут я ввел как отделять друг от друга числа при выводе их в терминал.

Console.WriteLine(str); тут выводится массив.

 for(int i=0; i<=9; i++) {
   if(array[i]%2 == 0) {
    Console.Write("{0} ", array[i]);}
} В этих трёх строчках код рассматривает каждое число массива и определяет выводить или нет и наконец-то выводит новый массив с чётными числами из первоначального, если массив полностью из нечётных чисел, то выводится только первоначальный массив.
