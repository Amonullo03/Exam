int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
for (int i=0; i<n; i++)
{
    arr[i]= Convert.ToInt32(Console.ReadLine());
    
}
int min=0;
for (int i = 1; i<n; i++){
    if(arr[i-1]<arr[i]){
        min = arr[i-1];
    }
}
int max=0;
for (int i = 1; i<n; i++){
    if(arr[i-1]<arr[i]){
        max = arr[i];
    }
}
for (int i=min; i<=max; i++){
    System.Console.WriteLine(arr[i]);
}