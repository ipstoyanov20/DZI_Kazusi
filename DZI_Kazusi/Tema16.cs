using System.Globalization;

public class Tema16
{
    public void Run()
    {
        int age = int.Parse(Console.ReadLine());
        float washingMachinePrice = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int presentPrice = int.Parse(Console.ReadLine());
        int savings = 0;
        int moneyFromPresents = 0;
        int bonus = 0;
        for (int i = 1; i <= age; i++) {
            if (i % 2 == 0)
            {
                bonus += 10;
                savings += bonus;
                savings -= 1;
            }
            else {
                moneyFromPresents += presentPrice;
            }
        }
        var allMoney = savings + moneyFromPresents;
        if (allMoney >= washingMachinePrice) 
            Console.WriteLine("Yes! {0}", (allMoney - washingMachinePrice).ToString("F2",CultureInfo.InvariantCulture));
        else
            Console.WriteLine("No! {0}", (washingMachinePrice - allMoney).ToString("F2",CultureInfo.InvariantCulture));
    
    }
    
}