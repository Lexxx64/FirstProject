int a = 3;
int b = 2;
int c = 10;
int d = 24;

int max = a;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
if ( d > max ) max = d;

Console.Write("max = ");
Console.WriteLine(max);