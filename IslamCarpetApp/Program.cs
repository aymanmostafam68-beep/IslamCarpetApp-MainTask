
    Console.WriteLine("Welcome to Islam Carpet Cleaning services");
    Console.WriteLine("Charges:");
    Console.WriteLine("$25 per small:");
    Console.WriteLine("$35 per Large:");
    Console.WriteLine("sales Tax rate is 6%:");
    Console.WriteLine("Estimates are valid for 30 days:");
    Console.WriteLine("-----------------------------------------");

    double PriceSmall = 25;
    double PriceLarge = 35;
    double Totalarge = 0;
    double TotalSmall = 0;

    bool start= true;

    while (start)
    {
        Console.WriteLine("Please select the carpet room size NO# : ");

        List<string> list = new List<string>()
         { "1-large room: 35$","2-Small room: 25$"};
        foreach (string Types in list)
        {

            Console.WriteLine(Types);
        }
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            switch (result)
            {
                case 1:
                    Console.WriteLine("you select the Large size");
                    Console.WriteLine("How Many :");
                    if (int.TryParse(Console.ReadLine(), out int _countLarge))
                    {

                        Totalarge += _countLarge;
                        Console.WriteLine($"{_countLarge} Large carpet added.");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine("-----------------------------------------");

                    }

                    break;


                case 2:
                    Console.WriteLine("you select the Small size");
                    Console.WriteLine("How Many :");
                    if (int.TryParse(Console.ReadLine(), out int _countSmall))
                    {
                        TotalSmall += _countSmall;
                        Console.WriteLine($"{_countSmall} Small carpet added.");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine("-----------------------------------------");

                    }
                    break;

                default:
                    Console.WriteLine("Invalid selection");
                    Console.WriteLine("please select 1 for large Or 2 for small");
                    Console.WriteLine("-----------------------------------------");

                    break;
            }
        }


        double total = ((Totalarge * PriceLarge) + (TotalSmall * PriceSmall));

        Console.WriteLine("========= Final Bill =========");
        Console.WriteLine($"Large carpets: {Totalarge} x {PriceLarge:C} = {(Totalarge * PriceLarge):C}");
        Console.WriteLine($"Small carpets: {TotalSmall} x {PriceSmall:C} = {(TotalSmall * PriceSmall):C}");
        Console.WriteLine($"Cost: {total:C}");
        Console.WriteLine($"Tax: {(total * 0.06):C}");
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"TOTAL: {total + (total * 0.06):C}");
        Console.WriteLine("-------------------------------");

    Console.WriteLine("do you select add new service?,y - n");

    char response =Convert.ToChar(Console.ReadLine().ToLower());
    if (response=='y')
    {
        start = true; 
    }
    else
    {
        start = false;
        Console.WriteLine("Thanks for your shopping..");

    }
}








