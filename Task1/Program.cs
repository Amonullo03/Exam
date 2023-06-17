int FindMinimum(int a, int b, int c, int d)
{
    if (a < b && a < c && a < d)
    {
        System.Console.WriteLine($" {a} is smallest");
    }
    else if(b<a && b<c && b<d){
        System.Console.WriteLine($" {b} is smallest");
    }
        else if(c<a && c<b && c<d){
        System.Console.WriteLine($" {c} is smallest");
    }
        else if(d<a && d<b && d<c){
        System.Console.WriteLine($" {d} is smallest");
    }
    return a;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindMinimum(a,b,c,d));
