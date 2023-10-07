bool RunProgram = true;
while (RunProgram){
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Input the binary value you want converted!");
    Console.WriteLine("------------------------------------------");
    string UserInput = Console.ReadLine();
    if (int.TryParse(UserInput, out int number) && UserInput != null && UserInput.Length < 9){
        ConversionMethod(UserInput);
    }
    else{
        Console.WriteLine("Invalud input");
    }
    static void ConversionMethod(string UserInput){
        int DecimalValue = Convert.ToInt32(UserInput);
        DecimalValue = Convert.ToInt32(DecimalValue.ToString(), 2);
        Console.WriteLine($"Your binary value is equal to {DecimalValue} as a decimal!");
    }
    bool Question = true;
    while (Question)
    {
        Console.WriteLine("Do you want to convert again? Y/N");
        string response = Console.ReadLine().ToUpper();
        if (response == "Y") {
            RunProgram = true;
            Question = false;
        }
        else if (response == "N") {
            RunProgram = false;
            Question = false;
            Console.WriteLine("Have a wonderful day!");
            Environment.Exit(0);
        }
        else {
            Console.WriteLine("Please input a valid response");
            Question = true;
        }
    }
}
