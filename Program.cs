/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 30, 2022
* Assignment CIS214 Week 4 GP - System Generated Exceptions
*
* Main application (program) class.
* In this application we will demonstrate the use of exception handling to
* properly process and handle a system-generated exception, allowing the program
* to continue operating after an exception is thrown by the system.
\******************************************************************************/

public class SystemExceptionDemo
{
    // Demonstrate throwing an exception when a division by zero error occurs
    public static int Quotient(int numerator, int denominator)
    {
        return numerator / denominator;
    }

    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "Jason D'Oyley - Week 4 GP - System Generated Exceptions"
        );

        bool cont = true; // loop control variable

        do
        {
            try
            {
                Console.Write("Please enter an integer numerator: ");
                string? val = Console.ReadLine();
                int numerator = Convert.ToInt32(val);

                Console.Write("Please enter an integer denominator: ");
                val = Console.ReadLine();
                int denominator = Convert.ToInt32(val);

                int res = Quotient(numerator, denominator);
                Console.WriteLine(
                    "\nResult: {0} / {1} = {2}", numerator, denominator, res
                );

                cont = false;
            }
            catch (FormatException e)
            {
                // Print the exception that was caught
                Console.WriteLine("\nException: {0}", e);

                // Discard the input so the user can try again
                Console.WriteLine(
                    "You must enter integers. Please try again."
                );
            }
            catch (DivideByZeroException e)
            {
                // Print the exception that was caught
                Console.WriteLine("\nException: {0}", e);

                // Discard the input so the user can try again
                Console.WriteLine(
                    "Zero is an invalid denominator. Please try again."
                );
            }

        } while (cont);

        // Now demonstrate what happens without exception handling
        Console.WriteLine(
            "Here's what would have happened with no Exception Handling:\n"
        );
        Console.Write("Please enter an integer numerator: ");
        string? val2 = Console.ReadLine();
        int numerator2 = Convert.ToInt32(val2);

        Console.Write("Please enter an integer denominator: ");
        val2 = Console.ReadLine();
        int denominator2 = Convert.ToInt32(val2);
        int res2 = Quotient(numerator2, denominator2);

        // With invalid input, this line will not be reached
        Console.WriteLine(
            "\nResult: {0} / {1} = {2}", numerator2, denominator2, res2
        );
    }
}
