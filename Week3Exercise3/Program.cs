using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise3
{
    internal class Program
    {
        static void ReverseString(string sInput) //ReverseString method to reverse the inputted string
        {
            string reversedString = ""; //declares and initializes the reversedString variable

            for (int i = sInput.Length - 1; i >= 0; i--) //for loop to create the reverse of the inputted string
            {
                reversedString = reversedString + sInput[i]; //sets the reversedString equal to itself plus the select character from inputted string 
            }

            Console.WriteLine("The reverse of " + sInput + " is " + reversedString); //displays the reversedString variable
        }

        static void CountVowels(string sInput) //method to count the vowels in the inputted string
        {
            int count = 0; //declares and initializes count variable
            string lower = sInput.ToLower(); //converts the inputted string to another string were all the characters are lowercased

            for (int i = 0; i < lower.Length; i++) //a loop that repeats as long as the interation number is less than the input strings length. After the iteration finishes it increases by 1
            {
                switch (lower[i]) //a switch loop that helps determine if the current character is a vowel or not
                {
                    case 'a': //case if the current character is an a
                    case 'e': //case if the current character is an e
                    case 'i': //case if the current character is an i
                    case 'o': //case if the current character is an o
                    case 'u': //case if the current character is an u
                        count++; //adds a 1 to the current vowel count
                        break; //breaks from switch loop
                }
            }

            Console.WriteLine("The number of vowels in the string is: " + count); //displays the total amount of vowels in the string
        }

        static void IsPalindrome(string sInput) //method to check if the inputted string is a palindrome
        {
            bool isPalindrome = true; //declares and initializes a boolean variable

            for (int i = 0; i < sInput.Length;) //for loop to loop through each character of the string
            {
                if (sInput[i] != sInput[sInput.Length - 1]) //if option if the character is not equal to its oppisite character in the string
                {
                    isPalindrome = false; //sets the boolean variable to false
                    break; //breaks from for loop
                }
                else //else option if the character is equal to its oppisite character in the string
                {
                    Console.WriteLine("Result: " + sInput + " is a palindrome."); //displays that the string is a palindrome
                    break; //breaks from for loop
                }
            }

            if (isPalindrome == false) //if function if the boolean veriable is false
            {
                Console.WriteLine("Result: " + sInput + " is not a palindrome."); //displays that the string is not an palindrome
            }
        }

        static void Main(string[] args) //main method
        {
            string userInput = ""; //declares and initializes userInput variable
            int selectionInput; //declares selectionInput variable

            while (userInput != "exit") //while loop that will repeat so long a userInput does not equal "exit"
            {
                Console.WriteLine("Please write a string, or type 'exit' to exit the program: "); //displays text asking for user input
                userInput = Console.ReadLine(); //sets user input to userInput string

                if (userInput == "exit") //if function checking if string is equal to "exit"
                {
                    break; //breaks from while loop
                }

                Console.WriteLine("1. Reverse the string."); //displays text for option 1
                Console.WriteLine("2. Count vowels in the string."); //displays text for option 2
                Console.WriteLine("3. Is the string a palindrome?"); //displays text for option 3
                Console.WriteLine("Please select an option (1/2/3): "); //displays text asking for user input
                selectionInput = Convert.ToInt32(Console.ReadLine()); //converts user input to selectionInput variable

                switch (selectionInput) //switch loop for users input
                {
                    case 1: //case 1 for users input
                        ReverseString(userInput); //calls ReverseString method with users input
                        break; //breaks from switch loop
                    case 2: //case 2 for users input
                        CountVowels(userInput); //calls CountVowels method with users input
                        break; //breaks from switch loop
                    case 3: //case 3 for users input
                        IsPalindrome(userInput);//calls IsPalindrome method with users input
                        break; //breaks from switch loop
                }
            }
        }
    }
}
