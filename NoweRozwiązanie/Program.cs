int number = 9983593;
string numberAsString = number.ToString();
char[] payLoad = numberAsString.ToArray();

int payLoad0 = 0;
int payLoad1 = 0;
int payLoad2 = 0;
int payLoad3 = 0;
int payLoad4 = 0;
int payLoad5 = 0;
int payLoad6 = 0;
int payLoad7 = 0;
int payLoad8 = 0;
int payLoad9 = 0;

foreach (char z in payLoad)
{
    if (z == '0')
    {
        payLoad0 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad0.ToString());
    }
    else if (z == '1')
    {
        payLoad1 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad1.ToString());
    }
    else if (z == '2')
    {
        payLoad2 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad2.ToString());
    }
    else if (z == '3')
    {
        payLoad3 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad3.ToString());
    }
    else if (z == '4')
    {
        payLoad4 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad4.ToString());
    }
    else if (z == '5')
    {
        payLoad5 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad5.ToString());
    }
    else if (z == '6')
    {
        payLoad6 += 1;
        Console.WriteLine(z.ToString() + "=>" + payLoad6.ToString());
    }
    else if (z == '7')
    {
        payLoad7 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad7.ToString());
    }
    else if (z == '8')
    {
        payLoad8 +=1;
        Console.WriteLine(z.ToString() + "=>" + payLoad8.ToString());
    }
    else if (z == '9')
    {
        payLoad9 +=1;
        Console.WriteLine(z.ToString() +"=>"+ payLoad9.ToString());
    }
}

Console.WriteLine(payLoad);