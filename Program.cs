// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Console.WriteLine(CalcWeather("-1 2 5 0 0 0 7 -9 -10"));

string CalcWeather (string input)
{
    int[] massByDigitFromInput = Array.ConvertAll(input.Split(' '), int.Parse);

    int positive = 0;
    int zeroFill = 0;
    int negative = 0;

    foreach (int digit in massByDigitFromInput)
    {
        if(digit < 0)
        { negative++; }
        else if (digit > 0)
            { positive++; }
        else { zeroFill++; }

        
    }
    return "выше нуля: " + positive.ToString() + ", ниже нуля: " + negative.ToString() + "равна нулю: " + zeroFill.ToString();
}*/

//144044
//1134351681

Console.WriteLine(ProcessingInputLines("1000,2000,3000,4000,5000,6000,7000,8000","0,5,10,15,20,25,0,5"));

int ProcessingInputLines(string payments, string discounts)
{
    int result = 0;

    string[] paymentsMass = payments.Split(',');
    string[] discountsMass = discounts.Split(',');

    int[] paymentsInts = Array.ConvertAll(paymentsMass, int.Parse);
    int[] discountsInts = Array.ConvertAll(discountsMass, int.Parse);

    for(int i = 0; i < paymentsInts.Count(); i++)
    {
        double disc = 0;
        if (discountsInts[i] != 0)
        {
            disc = (paymentsInts[i] * discountsInts[i])/100;
            Console.WriteLine("Скидка(disc) = " + disc);
        }
        double summa = Math.Round(paymentsInts[i] - disc);
        Console.WriteLine("Сумма = " + summa);

        result = result + Convert.ToInt32(summa);
        Console.WriteLine("Общая сумма = " + result + "\n");
    }

    return result;
}