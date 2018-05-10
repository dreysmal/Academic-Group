using System;
using System.Collections;
using System.Collections.Generic;

class Student : Person, IComparable
{
    protected float? avarage;
    public float? Avarage { get; set; }
    protected string number_of_group;
    public string Number_of_group { get; set; }

    public Student() : base()
    {
        avarage = null;
        number_of_group = "Не задано";
    }
    public Student(string _name, string _surname, int? _age, string _phone, float? _avarage, string _number_of_group):
        base(_name, _surname, _age, _phone)
    {
        avarage = _avarage;
        number_of_group = _number_of_group;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nСредний бал:\t{Avarage}\nНомер группы:\t{Number_of_group}";
    }
    public void Print()
    {
        Console.WriteLine(this);
    }

    int IComparable.CompareTo(object obj)
    {
        if (obj is Student)
        {
            return Surname.CompareTo((obj as Student).Surname);
        }
        throw new NotImplementedException();
    }
 
    public class Namecomparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if(x is Student && y is Student)
            {
                return (x as Student).Name.CompareTo((y as Student).Name);
            }
            throw new NotImplementedException();
        }
    }

    public class Phonecomparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student).Phone.CompareTo((y as Student).Phone);
            }
            throw new NotImplementedException();
        }
    }

    public class Groupcomparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
               return  (x as Student).Number_of_group.CompareTo((y as Student).Number_of_group);
            }
            throw new NotImplementedException();
        }
    }

    public class Agecomparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                if ((x as Student).Age < (y as Student).Age)
                    return -1;
                if ((x as Student).Age > (y as Student).Age)
                    return 1;
                else
                    return 0;
            }
            throw new NotImplementedException();
        }
    }
    public class Avaragecomparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                if ((x as Student).Avarage < (y as Student).Avarage)
                    return -1;
                if ((x as Student).Avarage > (y as Student).Avarage)
                    return 1;
                else
                    return 0;
            }
            throw new NotImplementedException();
        }
    }

}