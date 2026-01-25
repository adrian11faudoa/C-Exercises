# C# Course 

### Console Write, Convert Data Types
    Console.WriteLine("Hello World!");
    string textAge = "23";
    int age = Convert.ToInt32(textAge);
    Console.WriteLine(age);


### Data Types: Int - Long - Double - Float(Single) - Decimal
    - The 'L' is to tell the compiler to threat the variable as Int64
    long bigNumber2 = -90000000L;
    string textBigNumber = "-90000000";

    - When converting the 'L' is not need it, because the Convert.ToInt64 is makeing the variable an Int64
    long bigNumber = Convert.ToInt64(textBigNumber);
    Console.WriteLine(bigNumber);


    - The 'D' is to tell the compiler to threat the variable as Double
    double neg2 = -55.2D;
    string textNegative = "55.2";

    - When converting the 'D' is not need it, because the Convert.ToDouble is makeing the variable a Double
    double neg = Convert.ToDouble(textNegative);
    Console.WriteLine(neg);


    - The 'F' is to tell the compiler to threat the variable as Float
    float precision2 = 5.000001F;
    string textPrecision = "5.000001";
    
    - When converting the 'F' is not need it, because the Convert.ToSingle is makeing the variable a Single or Float
    float precision = Convert.ToSingle(textPrecision);
    Console.WriteLine(precision);
    
    
    - The 'M' is to tell the compiler to threat the variable as Decimal
    decimal money2 = 14.99M;
    string textMoney = "14.99";
    
    - When converting the 'M' is not need it, because the Convert.ToDecimal is makeing the variable a Decimal
    decimal money = Convert.ToDecimal(textMoney);
    Console.WriteLine(money);


### Data Types: String - Char
    string name = "Aba";
    char letter = 'a';

    Console.Write("Your name is ");
    Console.Write(name);

    Console.WriteLine();
    Console.WriteLine(letter);


### Data Type: Boolean 
    bool value = true;
    bool isMale = true;
    Console.WriteLine(isMale); //Prints True
    isMale = false;
    Console.WriteLine(isMale); //Prints False


### Operators: + - * /
    //int age = 23
    age++;
    age = age + 1;
    age += 1;
    age--;
    age -= 1;
    age *= 2;

    age /= 2; //Result = 2 (Incorrect)
    - it needs to have a Data Type of Double to represent the correct value
    double age4 = 44;
    age4 /= 10; //Result = 4.4 (Correct)

    //string name = "Aba"
    name += " is programming!";
    //name -= " is programming!"; would throw an Error

    //char letter = 'a';
    //letter += 'b'; would add the two unicode values together 

    int i = 0;
    Console.WriteLine(i++); //Prints 0
    Console.WriteLine(i); //Prints 1
    Console.WriteLine(++i); //Prints 2

    - Remainder %
    int firstNum = 10;
    int secNum = 3;
    Console.WriteLine(firstNum % secNum); //Result = 1


### Var Keyword
    var age3 = 23; //Int32
    var bigNumber3 = -90000000L; //Int64
    var neg3 = -55.2D; //Double
    var precision3 = 5.000001F; //Single
    var money3 = 14.99M; //Decimal
    var name2 = "Aba"; //String
    var letter2 = 'a'; //Char


### Const Keyword
    const int vat = 20;
    //vat = 10; throws an error

    int balance = 1000;

    Console.WriteLine(balance * (vat/100D));

    const double percentage = vat / 100D;
    Console.WriteLine(balance * percentage);


### Odd - Even Exercise
    int num1 = 10;
    int num2 = 2;
    int remainder = num1 % num2;
    Console.WriteLine(remainder); //Result 0

    num1 = 11;
    remainder = num1 % num2;
    Console.WriteLine(remainder); //Result 1


### Console Input - Output
    Console.Write("Enter your name: ");
    string name3 = Console.ReadLine();

    Console.Write("Enter your age: ");
    string ageInput = Console.ReadLine(); //Console.ReadLine() can't be an Int
    int age2 = Convert.ToInt32(ageInput);

    //Same as
    int age5 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Your name is " + name3 + " and your age is " + age5);


### if Statement == > >= < <= != || &&
    if (age5 < 0 || age > 150) //OR
    {   Console.WriteLine("Invalid Age!");  }
    else
    {
        if (age5 >= 18 && age5 <= 25) //AND
        {   Console.WriteLine("You are between 18 and 25"); }
        else if (age5 >= 26)
        {   Console.WriteLine("You are 26 or Older");   }
    }

    Console.Write("Enter the first number: ");
    int numA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int numB = Convert.ToInt32(Console.ReadLine());

    int result = numA * numB;

    Console.Write("Value of " + numA + " x " + numB + ": ");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (result == answer)
    {   Console.WriteLine("Well Done!");    }
    else
    {   Console.WriteLine("Wrong Answer!"); }


### Switch Statements
    Console.Write("Enter a day of the week: ");
    int day = Convert.ToInt32(Console.ReadLine());

    /*
    if (day == 1)
    {   Console.WriteLine("Mon");   }
    else if (day == 2)
    {   Console.WriteLine("Tue");   }
    */

    switch (day)
    {
        case 1: Console.WriteLine("Mon");
            break;
        case 2: Console.WriteLine("Tue");
            break;
        case 3: Console.WriteLine("Wen");
            break;
        case 4: Console.WriteLine("Thu");
            break;
        case 5: Console.WriteLine("Fri");
            break;
        case 6: Console.WriteLine("Sat");
            break;
        case 7: Console.WriteLine("Sun");
            break;
        default: Console.WriteLine("Invalid, enter a value between 1 and 7");
            break;
    }


### For Loop
    Console.Write("What do you want to repeat?");
    string message = Console.ReadLine();

    Console.Write("And how many times do you want to repeat it?");
    int loopCounter = Convert.ToInt32(Console.ReadLine());

    if (loopCounter <= 0)
    {   Console.WriteLine("Sorry, please enter a value above 0");   }
    else
    {   for (int i = 0; i < loopCounter; i++)
        {   Console.WriteLine(message); }
    }
                
    /*
    for (int i = 0; i <= 10; i += 2)
    {   Console.WriteLine(i);   }
    */


### While Loop




