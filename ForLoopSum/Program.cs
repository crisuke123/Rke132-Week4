
int Sum = 0 ;  

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"i ={i}");
    Console.WriteLine($"Current total:{Sum}");
    Sum = Sum + i ;
}
Console.WriteLine($"Final total {Sum}");