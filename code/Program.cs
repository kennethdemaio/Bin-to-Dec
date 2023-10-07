ConversionMethod();
QuestionMethod();
static void ConversionMethod(){
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Input the binary value you want converted!");
    Console.WriteLine("------------------------------------------");

    int binaryValue = Convert.ToInt32((Console.ReadLine()));
    int decimalValue = Convert.ToInt32(binaryValue.ToString(), 2);
    Console.WriteLine($"Your binary value is equal to {decimalValue} as a decimal!");
}
static void QuestionMethod(){
    Console.WriteLine("Do you want to convert again? Y/N");
    string response = Console.ReadLine().ToUpper();
    bool loopYesNo = true;
    while (loopYesNo == true) {
        if (response == "Y"){
            ConversionMethod();
            QuestionMethod();
        }
        else if (response == "N"){
            Console.WriteLine("Have a nice day");
            Environment.Exit(0);
        }
        else{
             Console.WriteLine("Please type a valid response");
             QuestionMethod();
        }
    }
}

