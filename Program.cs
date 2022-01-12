int[] array = new int[] {1, 42, 4, 452, 70, 69, 80, 741, 82, 91, 92 };
var str = string.Join(" ", array);
Console.WriteLine(str);
 for(int i=0; i<=9; i++) {
   if(array[i]%2 == 0) {
    Console.Write("{0} ", array[i]);}
}