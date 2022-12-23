// семинар 1



// задача 1 (является ли число 1 квадратом от числа 2)
/*
Console.Write("input a first :");
int numer1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a sekond :");
int numer2 = Convert.ToInt32(Console.ReadLine());
int quad2 = numer2*numer2;
if (numer1==quad2)
   Console.Write("Yes!");
else 
   Console.Write("Nou");
*/

// задача2 написать программу которая показывает все целые числа , в промежутке от минус числа numer до числа numer

/*
Console.Write("input numer : ");
int numer = Convert.ToInt32(Console.ReadLine());
int carent = -numer;
while (carent <= numer )
    {
    Console.Write(carent + " " );
    carent = carent + 1 ; } 
*/
// Домашнее задание семинар 1 
// задача первая , напишите программу которая принимает два числа и на выходе выдаёт какое больше а какое меньше
Console.Write("input a first :") ;
int N1 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("input a sekond :") ;
int N2 = Convert.ToInt32(Console.ReadLine()) ;
if (N1<N2)
   Console.Write((N1)+"<"+(N2));
else
   Console.Write((N1)+">"+(N2));
   


