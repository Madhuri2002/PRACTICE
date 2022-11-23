using System;
namespace height
{
  class tower
  {
    public static void main(String[] arg){
    int n=Convert.ToInt32(Console.ReadLine());
    int k=Convert.ToInt32(Console.ReadLine());
    int[] a=new int[n];
    for(int i=0;i<n;i++)
    {
      a[i]=Convert.ToInt32(Console.ReadLine());
    }
      Array.Sort(a);
      int min=a[0]+k;
      int max=a[n-1]-k;
      Console.WriteLine(max-min);
   }
}
