using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/0QUgvfuKvWU?t=24363

            List<TODO> todos = new List<TODO>
            {
                new TODO { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new TODO { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new TODO { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted },
                new TODO { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted },
                new TODO { Description = "Task 5", EstimatedHours = 6, Status = Status.OnHold },
                new TODO { Description = "Task 6", EstimatedHours = 2, Status = Status.InProgress },
                new TODO { Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted },
                new TODO { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed },
                new TODO { Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress },
                new TODO { Description = "Task 10", EstimatedHours = 4, Status = Status.Completed },
                new TODO { Description = "Task 11", EstimatedHours = 10, Status = Status.InProgress },
            };

            Console.ForegroundColor = ConsoleColor.Green;
           
            PrintAssessment(todos);

            Console.ReadLine();
        }

        private static void PrintAssessment(List<TODO> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.WriteLine($"Task {todo.Description} is not started.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Status.InProgress:
                        Console.WriteLine($"Task {todo.Description} is in progress.");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case Status.OnHold:
                        Console.WriteLine($"Task {todo.Description} is on hold.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case Status.Completed:
                        Console.WriteLine($"Task {todo.Description} is completed.");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case Status.Deleted:
                        Console.WriteLine($"Task {todo.Description} is deleted.");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                }

                Console.WriteLine($"Task {todo.Description} is estimated to take {todo.EstimatedHours} hours.");
            }
        }
    }

    class TODO
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}
