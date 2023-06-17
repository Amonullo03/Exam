int n = Convert.ToInt32(Console.ReadLine());
double sum = 0;
for (int i=0; i<=n; i++){
double a= Math.Pow(2, i);
sum=sum+a;
}
System.Console.WriteLine(sum);