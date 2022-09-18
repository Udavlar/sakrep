int N=int.Parse(Console.ReadLine());
if (N < 0)  
    N =-N; 
int B = -N;
while (B<=N)
{
    Console.WriteLine(B);
    B++;
}