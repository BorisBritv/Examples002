// 12. Удалить вторую цифру трёхзначного числа

// string A(int B)
// {
//     string C = Convert.ToString(B);
//     string res = string.Empty;
//     res = $"{C[0]+ "0"+ C[2]}";
//     return res;
// }

// Console.WriteLine(A(234));


int DeleteNumber(int B)
{
return ((B/100)*100+B%10);                    // сначала нашел первую цифру данного аргумента,потом умножил ее на 100,дальше нашел последнюю цифру аргумента и сложил два получившихся значения.
}
Console.WriteLine(DeleteNumber(499));