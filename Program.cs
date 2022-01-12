int[] array = new int[] {1, 42, 49, 45, 70, 69, 80, 74, 82, 91 };
var str = string.Join(" ", array);
Console.WriteLine(str);
 for(int i=0; i<=9; i++) {
   if(array[i]%2 == 0) {
    Console.Write("{0} ", array[i]);}
}
