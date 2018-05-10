using System;
using static System.Console;
using System.Collections;
class Main_Class
{
    enum search_id { name, surname, phone, age, avarage, group };
    public static Student New_Student()
    {
        Student temp = new Student();
        WriteLine("Enter Name: ");
        temp.Name = ReadLine();
        WriteLine("Enter Surname: ");
        temp.Surname = ReadLine();
        WriteLine("Enter Age: ");
        for (; ; )
        {
            try
            {
                temp.Age = Int32.Parse(ReadLine());
            }
            catch (FormatException)
            {
                WriteLine("You entered wrong symbol!\nPlease enter Age:");
                continue;
            }
            break;
        }
        WriteLine("Enter Phone: ");
        temp.Phone = ReadLine();
        WriteLine("Enter Avarage: ");
        for (; ; )
        {
            try
            {
                temp.Avarage = float.Parse(ReadLine());
            }
            catch (FormatException)
            {
                WriteLine("You entered wrong symbol!\nPlease enter Avarage:");
                continue;
            }
            break;
        }
        WriteLine("Enter Group: ");
        temp.Number_of_group = ReadLine();
        return temp;
    }
    public static void Remove(ArrayList group)
    {
        string request;
        ConsoleKeyInfo keyInfo;
        Write("Enter Surname: ");
        request = ReadLine();
        Clear();
        foreach (Student item in group)
        {
            if (item.Surname.ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Surname.ToUpperInvariant()))
            {
                WriteLine(item);
                WriteLine("\nDelete this Student? y/n");
                keyInfo = ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    group.Remove(item);
                    Clear();
                    break;
                }
            }
            Clear();
        }
    }
    public static void Search(ArrayList group)
    {
        ConsoleKeyInfo keyInfo;
        string request;
        string[] menu_strings = { "  Search by Name", "  Search by Surname", "  Search by Phone", "  Search by Age", "  Search by Avarage", "  Search by Group" };
        int s = Menu.Menu_meth(menu_strings, "Search menu:", menu_strings.Length);
        switch (s)
        {
            case (int)search_id.name:
                Clear();
                Write("Enter Your request: ");
                request = ReadLine();
                Clear();
                foreach (Student item in group)
                {
                    if (item.Name.ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Name.ToUpperInvariant()))
                    {
                        item.Print();
                        WriteLine("\n");
                    }
                }
                Write("Press any key to continue");
                keyInfo = ReadKey(true);
                Clear();
                break;
            case (int)search_id.surname:
                Clear();
                WriteLine("Enter Your request: ");
                request = ReadLine();
                Clear();
                foreach (Student item in group)
                {
                    if (item.Surname.ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Surname.ToUpperInvariant()))
                    {
                        item.Print();
                        WriteLine("\n");
                    }
                }
                Write("Press any key to continue");
                keyInfo = ReadKey(true);
                Clear();
                break;
            case (int)search_id.age:
                Clear();
                WriteLine("Enter Your request: ");
                request = ReadLine();
                Clear();
                foreach (Student item in group)
                {
                    if (item.Age.ToString().ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Age.ToString().ToUpperInvariant()))
                    {
                        item.Print();
                        WriteLine("\n");
                    }
                }
                Write("Press any key to continue");
                keyInfo = ReadKey(true);
                Clear();
                break;
            case (int)search_id.avarage:
                Clear();
                WriteLine("Enter Your request: ");
                request = ReadLine();
                Clear();
                foreach (Student item in group)
                {
                    if (item.Avarage.ToString().ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Avarage.ToString().ToUpperInvariant()))
                    {
                        item.Print();
                        WriteLine("\n");
                    }
                }
                Write("Press any key to continue");
                keyInfo = ReadKey(true);
                Clear();
                break;
            case (int)search_id.group:
                Clear();
                WriteLine("Enter Your request: ");
                request = ReadLine();
                Clear();
                foreach (Student item in group)
                {
                    if (item.Number_of_group.ToString().ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Number_of_group.ToString().ToUpperInvariant()))
                    {
                        item.Print();
                        WriteLine("\n");
                    }
                }
                Write("Press any key to continue");
                keyInfo = ReadKey(true);
                Clear();
                break;
            case (int)search_id.phone:
                Clear();
                WriteLine("Enter Your request: ");
                request = ReadLine();
                Clear();
                foreach (Student item in group)
                {
                    if (item.Phone.ToString().ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Phone.ToString().ToUpperInvariant()))
                    {
                        item.Print();
                        WriteLine("\n");
                    }
                }
                Write("Press any key to continue");
                keyInfo = ReadKey(true);
                Clear();
                break;

        }
    }
    public static void Edit(ArrayList group)
    {
        string request;
        ConsoleKeyInfo keyInfo;
        Write("Enter Surname: ");
        request = ReadLine();
        Clear();
        foreach (Student item in group)
        {
            if (item.Surname.ToUpperInvariant().Contains(request.ToUpperInvariant()) || request.ToUpperInvariant().Contains(item.Surname.ToUpperInvariant()))
            {
                WriteLine(item);
                WriteLine("\nEdit this Student? y/n");
                keyInfo = ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    Title = "Edit menu";
                    Clear();
                    WriteLine("Do You want to edit Name?  y/n");
                    keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Clear();
                        WriteLine("Please enter new Name:");
                        item.Name = ReadLine();
                    }
                    Clear();
                    WriteLine("Do You want to edit Surname?  y/n");
                    keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Clear();
                        WriteLine("Please enter new Surname:");
                        item.Surname = ReadLine();
                    }
                    Clear();
                    WriteLine("Do You want to edit Age?  y/n");
                    keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        for (; ; )
                        {
                            try
                            {
                                Clear();
                                WriteLine("Please enter new Age:");
                                item.Age = Int32.Parse(ReadLine());
                            }
                            catch (FormatException)
                            {
                                WriteLine("You entered wrong symbol!\nPlease enter Age:");
                                continue;
                            }
                            break;
                        }
                    }
                    Clear();
                    WriteLine("Do You want to edit Phone?  y/n");
                    keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Clear();
                        WriteLine("Please enter new Phone:");
                        item.Phone = ReadLine();
                    }
                    Clear();
                    WriteLine("Do You want to edit Avarage?  y/n");
                    keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        for (; ; )
                        {
                            try
                            {
                                Clear();
                                WriteLine("Please enter new Avarage:");
                                item.Avarage = float.Parse(ReadLine());
                            }
                            catch (FormatException)
                            {
                                WriteLine("You entered wrong symbol!\nPlease enter Avarage:");
                                continue;
                            }
                            break;
                        }
                    }
                    Clear();
                    WriteLine("Do You want to edit Number of group?  y/n");
                    keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y)
                    {
                        Clear();
                        WriteLine("Please enter new Number of grou:");
                        item.Number_of_group = ReadLine();
                    }
                    Clear();
                }
            }
            Clear();
        }
    }
}