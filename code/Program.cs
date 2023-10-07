Console.WriteLine("------------------------------------------");
Console.WriteLine("Input the binary value you want converted!");
Console.WriteLine("------------------------------------------");
string UserInput = Console.ReadLine();
if (UserInput != null && UserInput.Length < 9){
    ConversionMethod(UserInput);
    }
else{
    Console.WriteLine("Binary has a max value of 8 digits.");
}
static void ConversionMethod(string UserInput){
    int DecimalValue = Convert.ToInt32(UserInput);
    DecimalValue = Convert.ToInt32(DecimalValue.ToString(), 2);
    Console.WriteLine($"Your binary value is equal to {DecimalValue} as a decimal!");
}
/*static void QuestionMethod(){
    Console.WriteLine("Do you want to convert again? Y/N");
    string response = Console.ReadLine().ToUpper();
    bool loopYesNo = true;
    while (loopYesNo == true){
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
*/
