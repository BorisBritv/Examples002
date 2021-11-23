// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.


bool Kratnost(int b, int n)
{
    return (b % n == 0);
}
Console.WriteLine(Kratnost(10,4));

int Ostatok(bool Kratnost,int b, int n)
{
     if(Kratnost !=true) return b % n;
     else return -1;
}
Console.WriteLine(Ostatok(Kratnost(10,4),10,4));






//14. Найти третью цифру числа или сообщить, что её нет





//15. Дано число. Проверить кратно ли оно 7 и 23

// bool a(int A,int B,int C)
// {
//     return C%A==0 && C%B==0;
// }

// Console.WriteLine(a(7,23,161));

// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

// bool A(int B)
// {
//     return (B==6 || B==7);
// }

// Console.WriteLine(A(4));

//17. По двум заданным числам проверять является ли одно квадратом другого

//   bool a (int A,int B)
//   {
//       return  A*A==B || B*B==A;
//   }

//  Console.WriteLine(a(6,36));

