using System;

internal class Person
{
    protected string name;
    public string Name { get; set; }
    protected string surname;
    public string Surname { get; set; }
    protected int? age;
    public int? Age
    {
        get
        {
            return age;
        }
        set
        {
            if(value >=0 && value <=105)
            {
                age = value;
            }
            else
            {
                age = null;
            }
        }
    }
    protected string phone;
    public string Phone { get; set; }

    public override string ToString()
    {
        return $"Имя:\t\t{Name}\nФамилия:\t{Surname}\nВозраст:\t{Age}\nТелефон:\t{Phone}";
    }

    public Person() : this("Не задано", "Не задано", null, "Не задано") { }
    
    public Person(string _name, string _surname, int? _age, string _phone)
    {
        name = _name;
        surname = _surname;
        age = _age;
        phone = _phone;
    }

    public void Print()
    {
        Console.WriteLine(this);
    }
}