
List<string> tasks = new List<string>();
bool isRunning = true;

while (isRunning)
    {
        Console.WriteLine("######################## TO DO APP #########################");
        Console.WriteLine("1 <- Add Task #################################");
        Console.WriteLine("----------------------------------------------------------##");
        Console.WriteLine("2 <- View Tasks  ##########################################");

        Console.WriteLine("----------------------------------------------------------##");
        Console.WriteLine("3 <- Mark Task as completed ################################");

        Console.WriteLine("----------------------------------------------------------##");
        Console.WriteLine("4 <- to Exit  ##############################################");
        Console.WriteLine("############################################################");
        Console.WriteLine(" Inter your Option ");
   
    string option = Console.ReadLine();
    switch (option)
    {
        case "1":

            Console.WriteLine(" Add New Task ");

            string NewTask = Console.ReadLine();
            tasks.Add(NewTask);
            Console.WriteLine("Task Added Successfily ");

            break;
        case "2":

            Console.WriteLine(" all Task ");
            if (tasks.Count != 0)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($" {i + 1} - {tasks[i]}");
                }
            }
            else
            {
                Console.WriteLine("Task is empty ");
            }


            break;
        case "3":
            Console.WriteLine(" all Task ");
            if (tasks.Count != 0)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($" {i + 1} - {tasks[i]}");
                }
            }
            else
            {
                Console.WriteLine("Task is empty ");
            }

            Console.WriteLine("enter number of task to mark it as completed ");
            int taskid = int.Parse(Console.ReadLine());
            if (taskid < 0 || taskid < tasks.Count)
            {
                Console.WriteLine("Wrong taask id number");

            }
            else
            {
               string campletedTask = tasks[taskid - 1 ];
                  tasks.RemoveAt(taskid - 1);
                Console.WriteLine($" this Task ({campletedTask}) Marked as completed");

            }





            break;
            case "4":
                Console.WriteLine("Thank you , Godbye");
                isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid Option Try Again ");

                break;
        }
    }

