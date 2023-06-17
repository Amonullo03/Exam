int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
for (int i=0; i<n; i++)
{
    arr[i]= Convert.ToInt32(Console.ReadLine());
    
}
foreach (int item in arr){
    System.Console.WriteLine(item);
}