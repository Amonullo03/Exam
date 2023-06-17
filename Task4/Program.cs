int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
for (int i=0; i<n; i++)
{
    arr[i]= Convert.ToInt32(Console.ReadLine());
    
}
Array.Sort(arr);
int cnt=0;
for (int i=1; i<n; i++)
{
    if (arr[i-1]!=arr[i]){
     cnt ++;
    }
}
System.Console.WriteLine(cnt);