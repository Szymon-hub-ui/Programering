int a=10;
int b=20;
BytPlats (ref a, ref b );
Console.WriteLine (a+" "+b);

void BytPlats (ref int a, ref int b) {
    //a:10   b:20
    int c = a;
    a = b;
    b = c;
}