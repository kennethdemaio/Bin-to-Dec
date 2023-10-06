myMethod();
question();
static void myMethod() {
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Input the binary value you want converted!");
    Console.WriteLine("------------------------------------------");

    int binaryVal = Convert.ToInt32((Console.ReadLine()));
    int decimalVal = Convert.ToInt32(binaryVal.ToString(), 2);
    Console.WriteLine($"Your binary value is equal to {decimalVal} as a decimal!");
}
static void question() {
    Console.WriteLine("Do you want to convert again? Y/N");
    string response = Console.ReadLine().ToUpper();
    bool loopYesNo = true;
    while (loopYesNo == true) {
        if (response == "Y"){
            myMethod();
            question();
        }
        else if (response == "N"){
            Console.WriteLine("Have a nice day");
            Environment.Exit(0);
        }
        else{
                Console.WriteLine("Please type a valid response");
                question();
        }
    }
}

