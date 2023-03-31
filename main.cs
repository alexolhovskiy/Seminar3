/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

Alex Olhovskiy
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    //5-digit palindrome
    Console.WriteLine("Enter 5-digit number");
    int num=Convert.ToInt32(Console.ReadLine());
    if((num>100000)|(num<10000))
    {
        Console.WriteLine("Error! Check your enter!");
    }
    else
    {
        if(((num/10000)==(num%10))&&((num%10000/1000)==(num%100/10)))
        {
            Console.WriteLine("Yes! This number is palindrome");
        }
        else
        {
            Console.WriteLine("No! This number is not palindrome");
        }
    }
    
    //Distance between 2 3D-points
    double R=0;
    int [,]p_arr=new int [2,3];
    string str="xyz";
    for(int i=0;i<2;i++)
    {
        Console.WriteLine("Enter your point "+(i+1));
        for(int j=0;j<3;j++)
        {
            Console.WriteLine("Enter "+str[j]);
            p_arr[i,j]=Convert.ToInt32(Console.ReadLine());
        }
    }
    for(int j=0;j<3;j++)
    {
        R+=(p_arr[0,j]-p_arr[1,j])*(p_arr[0,j]-p_arr[1,j]);
    }
    Console.WriteLine("Distance is "+Math.Sqrt(R));
    
    
    //array of cubes
    Console.WriteLine("Enter your number");
    num=Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int[]arr=new int[num];
    for(int i=0;i<num;i++)
    {
        arr[i]=(i+1)*(i+1)*(i+1);
    }
    for(int i=0;i<num;i++)
    {
        Console.Write(""+arr[i]);
        if(i<(num-1))
        {
            Console.Write(",");
        }
    }
  }
}