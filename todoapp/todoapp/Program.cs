using System;


class Todo
{
    private List<string> myList;

    // Constructor that initializes the List
    public Todo()
    {
        myList = new List<string>();
    }


    public void Add(string element)
    {
        myList.Add(element);
    }

    public void display()
    {
        Console.WriteLine("listID \t List item");
        Console.WriteLine("------ \t ---------");
        for (int i = 0; i < myList.Count; i++)
        {

            Console.WriteLine($"{i} " + "\t " + myList[i]);
        }
        /*   foreach (string item in myList)
           {
               Console.WriteLine(item);
           }*/

    }

    public void removeItem(int id)
    {
        if (id >= 0 && id < myList.Count)
        {
            myList.RemoveAt(id);
            Console.WriteLine($"Item at index {id} removed successfully.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid index provided. No item removed.");
        }
    }

    public void countList()
    {
        int listLength = myList.Count;
        Console.WriteLine($"The length of the list is: {listLength} ");
    }

}






class Program
{
    public static void Main()
    {
        Todo todo = new Todo();
        while (true)
        {
           // Set text color to Red
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---Console To Do List App--");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.Create a list");
            Console.WriteLine("2.Display list");
            Console.WriteLine("3.Remove item from list");
            Console.WriteLine("4.Number of tasks");
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/> Select a choice:");
            Console.ForegroundColor = ConsoleColor.Green;
            var choice = Console.ReadLine();
            Console.WriteLine("\n");
            /*int data = int.Parse(choice);*/

            Console.ForegroundColor = ConsoleColor.Blue;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("/>Add a list item:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string el = Console.ReadLine();
                    todo.Add(el);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Item `{el}` is added");
                    Console.WriteLine("\n");
                    break;

                case "2":
                    Console.WriteLine("Displaying list....");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    todo.display();

                    Console.WriteLine("\n");
                    break;

                case "3":
                    Console.WriteLine("/> Provide an Item Id:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    var input = Console.ReadLine();
                    int id;

                    if (!int.TryParse(input, out _))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not a number.Try again");
                    }
                    else
                    {
                        id = int.Parse(input);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        todo.removeItem(id);
                    }

                    Console.WriteLine("\n");
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Counting items in the list....");
                    todo.countList();
                    Console.WriteLine("\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Input !! please try again");
                    Console.WriteLine("\n");
                    break;
            }


        }
    }
}
