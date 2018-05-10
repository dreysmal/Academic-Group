using System;
using System.Collections;
using System.IO;
using System.Text;
using static System.Console;

enum Menu_show { Show, Name, Surname, Age, Phone, Avarage, Group, Exit }
class Academy_Group : ICloneable, IEnumerable, IEnumerator
{
    ArrayList group = new ArrayList();
    public void Add()
    {
        group.Add(Main_Class.New_Student());
    }
    public void Remove()
    {
        Main_Class.Remove(group);
    }
    public void Edit()
    {
        Main_Class.Edit(group);
    }
    public void Print()
    {
        ConsoleKeyInfo key;
        foreach (Student item in group)
        {
            item.Print();
            WriteLine();
        }
        key = ReadKey(true);
        Clear();
    }
    public void Sort()
    {
        Clear();
            string[] menu_strings_show = { "  Show all students", "  Sort by Name", "  Sort by Surname", "  Sort by Age", "  Sort by Phone", "  Sort by Avarage", "  Sort by Group", "  Return to main menu" };
            int w = Menu.Menu_meth(menu_strings_show, "View menu", menu_strings_show.Length);
            switch (w)
            {
                case (int)Menu_show.Show:
                    Clear();
                    ConsoleKeyInfo key;
                    foreach (Student item in group)
                    {
                        item.Print();
                        WriteLine();
                    }
                    key = ReadKey(true);
                    Clear();
                    break;
                case (int)Menu_show.Name:
                    Clear();
                    group.Sort(new Student.Namecomparer());
                    Clear();
                    break;
                case (int)Menu_show.Group:
                    Clear();
                    group.Sort(new Student.Groupcomparer());
                    Clear();
                    break;
                case (int)Menu_show.Phone:
                    Clear();
                    group.Sort(new Student.Phonecomparer());
                    Clear();
                    break;
                case (int)Menu_show.Age:
                    Clear();
                    group.Sort(new Student.Agecomparer());
                    Clear();
                    break;
                case (int)Menu_show.Avarage:
                    Clear();
                    group.Sort(new Student.Avaragecomparer());
                    Clear();
                    break;
                default:
                    Clear();
                    group.Sort();
                    Clear();
                    break;
        }
    }
    public void Copy()
    {

    }
    public void Save()
    {
        using (FileStream fs = new FileStream("group.txt", FileMode.Create))
        {
            using (StreamWriter strr = new StreamWriter(fs, Encoding.Unicode))
            {
                foreach (Student item in group)
                {
                    strr.WriteLine(item.Name);
                    strr.WriteLine(item.Surname);
                    strr.WriteLine(item.Age);
                    strr.WriteLine(item.Phone);
                    strr.WriteLine(item.Avarage);
                    strr.WriteLine(item.Number_of_group);
                }
            }
        }   
    }
    public void Load()
    {
        ArrayList temp = new ArrayList();
        using (FileStream fs = new FileStream("group.txt", FileMode.Open))
        {
            using (StreamReader strr = new StreamReader(fs, Encoding.Unicode))
            {
                string input;
                while ((input = strr.ReadLine())!=null)
                {
                    Student temp_s = new Student
                    {
                        Name = input,
                        Surname = strr.ReadLine(),
                        Age = Int32.Parse(strr.ReadLine()),
                        Phone = strr.ReadLine(),
                        Avarage = float.Parse(strr.ReadLine()),
                        Number_of_group = strr.ReadLine()
                    };
                    temp.Add(temp_s);
                }
            }
        }
        group = temp;
    }
    public void Search()
    {
       Main_Class.Search(group);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        for (int i = 0; i < group.Count; i++)
        {
            yield return group[i];
        }
    }
    int position = -1;
    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
    public Student Current
    {
        get
        {
            try
            {
                return (Student)group[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
    bool IEnumerator.MoveNext()
    {
        position++;
        return (position < group.Count);
    }

    void IEnumerator.Reset()
    {
        position = -1;
    }

    public object Clone()
    {
        Academy_Group temp = new Academy_Group();
        for (int i = 0; i < this.group.Count; i++)
        {
            Student temp_st = new Student
            {
                Name = (group[i] as Student).Name,
                Surname = (group[i] as Student).Surname,
                Age = (group[i] as Student).Age,
                Phone = (group[i] as Student).Phone,
                Avarage = (group[i] as Student).Avarage,
                Number_of_group = (group[i] as Student).Number_of_group
            };
            temp.group.Add(temp_st); 
        }
        return temp;
    }
}