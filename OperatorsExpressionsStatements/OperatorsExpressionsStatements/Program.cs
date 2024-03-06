using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* https://youtu.be/0QUgvfuKvWU?t=6975
             * Operators, expressions, and statements are important concepts in C# prammin. Here is a brief explanation of each term:
             * Operators are symbols that perform operations on operands, such as:
             * +, -, *, /, =, ==, &&, etc. For example, in the expression a + b = c, + and = are operators.
             * 
             * Expressions are combinations of operads and operators that can be evaluated to a single value. 
             * For example, a + b and a + b = c are both expressions.
             * Statements are basic units of execution in a program. 
             * They can be declarations, assignments, method calls, control flows, etc. They usually end with a semicolon. 
             * For example, int a = 10; and Console.WriteLine("Hello"); are both statements.
             */

            // Variable Declaration
            int x, y, a, b;

            // Assignment Operator
            x = 3;
            y = 4;
            a = 5; 
            b = 6;

            // Mathematical operators

            // Addition operator
            x = 3 + 4;

            // Subctration operator
            x = 4 - 3;

            // Multiplication Operator
            x = 10 * 5;

            // Division operator
            x = 10 / 5;

            // Order of operations using ()
            x = (x + y) * (a - b);

            // Operators to evaluate values

            // Equality operator
            if (x == 0)
            {
                x = 0;
            }

            // Greator than
            if(x > y)
            {
                x = 1;
            }

            // Lesser than

            if (x < 0)
            {
                x = 2;

            }

            // Greater or Equal
            if (x >= y)
            {
                x = 3;

            }

            // Lesser than or equal
            if (x <= y)
            {
                x = 4;

            }

            /*
             * There are two conditional operators as well, 
             * that can be used to expand / enhance an evaluation...
             * ... and they can br combined together multiple times.
             */

            // Conditional AND Operator
            if ((x > y ) && (a > b ))
            {
                x = 5;
            }

            // Conditional OR Operator
            if ((x > y) || (a > b ))
            {
                x = 6;
            }

            // Also, here´s the in-line conditional operator
            // we learned about before.
            string message = (x == 1) ? "car" : "Boat";

            // Member access and Method invocation Operator
            Console.WriteLine(message);

            // https://youtu.be/0QUgvfuKvWU?t=7503
            // Continue here:

        }
    }
}
