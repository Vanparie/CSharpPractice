
//Handling wrong user input


using System;


namespace CSharpPractice

{
    internal class AgeInput
    {
        
        static void Main(string[] args)
        {
            //take user input
            Console.WriteLine("Enter your age: ");

            string userInput = Console.ReadLine();
            int userAge;   //store the number after parsing

            //try to parse the input/ try to parse userInput into an integer

            bool IsValid = int.TryParse(userInput, out userAge);

            if (IsValid)
            {
                //successfully converted
                Console.WriteLine("Your age is: " + userAge);

            }
            else
            {
                //conversion failed
                Console.WriteLine("Invalid input! Please enter numbers only.");
            }

        }
    }
}



//Now: Full Line-by - Line Explanation
//1️⃣ // BONUS CHALLENGE
//🔵 A comment explaining that this program is a special bonus task.

//Comments are for human readers only — the computer ignores them.

//2️⃣ //Handling wrong user input
//🔵 Another comment: describes what this small program is about — validating user input.

//3️⃣ using System;
//🔵 Import the System namespace — which contains important tools like:

//Console.WriteLine()

//Console.ReadLine()

//int

//bool

//Without using System;, you couldn't use those directly.

//4️⃣ namespace CSharpPractice
//🔵 Groups your class inside a Namespace(like a "folder").

//Helps to organize your project and avoid class name conflicts later.

//5️⃣ { ... } — Opening and Closing Namespace
//🔵 Everything inside { }
//belongs to the CSharpPractice namespace.

//6️⃣ internal class AgeInput
//🔵 Declares a Class named AgeInput.

//A class is a blueprint where we group related methods and data together.

//7️⃣ { ... } — Opening and Closing Class
//🔵 Everything inside { }
//belongs to the AgeInput class.

//8️⃣ static void Main(string[] args)
//🔵 This is the Main method — the entry point of the program.

//When you run the program, this function is called first.

//static = no need to create an object to call it.

//void = doesn't return anything.

//string[] args = (optional)command - line arguments (not important for now).

//9️⃣ { ... } — Opening and Closing Main Method
//🔵 Code that should execute goes inside here.

//1️⃣0️⃣ Console.WriteLine("Enter your age: ");
//🔵 Prints the message "Enter your age:" on the console.

//Asks the user for their input.

//1️⃣1️⃣ string userInput = Console.ReadLine();
//🔵 Reads the user's input from the console.

//Always stored as a string — even if they type numbers.

//1️⃣2️⃣ int userAge;
//🔵 Declares a variable named userAge of type integer(int).

//It is empty for now — will be filled only if parsing succeeds.

//1️⃣3️⃣ bool IsValid = int.TryParse(userInput, out userAge);
//🔵 Very important line!

//Tries to convert userInput into an integer.

//If successful:

//IsValid will become true

//userAge will hold the number.

//If unsuccessful(user typed letters or symbols):

//IsValid will become false

//userAge will be zero.

//✅ No crash happens because TryParse is a safe method.

//1️⃣4️⃣ if (IsValid)
//🔵 Checks if the parsing was successful.

//If yes (true), runs the code inside the if block.

//1️⃣5️⃣ { Console.WriteLine("Your age is: " + userAge); }
//🔵 Prints the age nicely if user input was a valid number.

//1️⃣6️⃣ else
//🔵 If parsing failed (IsValid == false), the program moves here.

//1️⃣7️⃣ { Console.WriteLine("Invalid input! Please enter numbers only."); }
//🔵 Displays an error message if the user input was not a number.

//✅ User experience becomes much friendlier and program doesn't crash!

//1️⃣8️⃣ Final
//} — Closing all opened {} (method, class, namespace).
