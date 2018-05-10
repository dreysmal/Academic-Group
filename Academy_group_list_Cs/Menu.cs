using System;
using static System.Console;
class Menu
{
    public static int Menu_meth(string[] fields, string title, int quantity_of_strings)
    {
        BackgroundColor = ConsoleColor.White;
        ForegroundColor = ConsoleColor.DarkBlue;
        Title = title;
        WindowWidth = 130;
        WindowHeight = 50;

        string[] menu_strings_updated = new string[quantity_of_strings];
        fields.CopyTo(menu_strings_updated, 0);

        ConsoleKeyInfo keyInfo;
        int count = 0;
        menu_strings_updated[0] = "->" + menu_strings_updated[0];
        foreach (string item in menu_strings_updated)
        {
            WriteLine(item);
        }
        while (true)
        {
            keyInfo = ReadKey(true);
            //////////////////////////
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                return count;
            }
            //////////////////////////
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                count++;
                if (count == quantity_of_strings)
                {
                    count = 0;
                }
                fields.CopyTo(menu_strings_updated, 0);
                menu_strings_updated[count] = "->" + fields[count];
                Clear();
                foreach (string item in menu_strings_updated)
                {
                    WriteLine(item);
                }
            }
            //////////////////////////
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                count--;
                if (count == -1)
                {
                    count = quantity_of_strings - 1;
                }
                fields.CopyTo(menu_strings_updated, 0);
                menu_strings_updated[count] = "->" + fields[count];
                Clear();
                foreach (string item in menu_strings_updated)
                {
                    WriteLine(item);
                }
            }
        }
    }



    public static int Menu_meth(Student[] fields, string title, int quantity_of_strings, int erase_or_edit)
    {
        string erase_edit = null;
        if (erase_or_edit == 1)
        {
            erase_edit = "<>ERASE<>ERASE<>ERASE<>ERASE<>ERASE<>ERASE>\n";
        }
        else
        {
            erase_edit = "<>EDIT<>EDIT<>EDIT<>EDIT<>EDIT<>EDIT>\n";
        }
        BackgroundColor = ConsoleColor.White;
        ForegroundColor = ConsoleColor.DarkBlue;
        Title = title;
        WindowWidth = 130;
        WindowHeight = 50;

        String[] menu_strings_updated = new String[quantity_of_strings];
        for (int i = 0; i < quantity_of_strings; i++)
        {
            menu_strings_updated[i] = fields[i].ToString();
        }

        ConsoleKeyInfo keyInfo;
        int count = 0;
        menu_strings_updated[0] = erase_edit + menu_strings_updated[0];
        foreach (string item in menu_strings_updated)
        {
            WriteLine(item);
        }
        while (true)
        {
            keyInfo = ReadKey(true);
            //////////////////////////
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                return count;
            }
            //////////////////////////
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                count++;
                if (count == quantity_of_strings)
                {
                    count = 0;
                }
                for (int i = 0; i < quantity_of_strings; i++)
                {
                    menu_strings_updated[i] = fields[i].ToString();
                }
                menu_strings_updated[count] = erase_edit + menu_strings_updated[count];
                Clear();
                foreach (string item in menu_strings_updated)
                {
                    WriteLine(item);
                }
            }
            //////////////////////////
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                count--;
                if (count == -1)
                {
                    count = quantity_of_strings - 1;
                }
                for (int i = 0; i < quantity_of_strings; i++)
                {
                    menu_strings_updated[i] = fields[i].ToString();
                }
                menu_strings_updated[count] = erase_edit + menu_strings_updated[count];
                Clear();
                foreach (string item in menu_strings_updated)
                {
                    WriteLine(item);
                }
            }
        }
    }
}
