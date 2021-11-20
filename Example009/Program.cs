// 9. Показать последнюю цифру трёхзначного числа

int LastNum(int a)
{
int res = 0;
res = a % 10 ;                               // забираем от числа последнюю цифру с помощью деления с остатками
return res;
}
Console.WriteLine(LastNum(145));