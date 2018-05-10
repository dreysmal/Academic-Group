using static System.Console;

namespace Academy_group_list_Cs
{
    class Program
    {
        enum Menu_id { New, Show, Remove, Edit, Search, Copy, Exit}
        static void Main(string[] args)
        {
            Academy_Group SPU_1621 = new Academy_Group();
            SPU_1621.Load();
            while (true)
            {
                string[] menu_strings = { "  Add new student", "  Show students", "  Remove student", "  Edit student", "  Search student", "  Copy Group", "  Exit" };
                int s = Menu.Menu_meth(menu_strings, "Academy Group", menu_strings.Length);
                switch (s)
                {
                    case (int)Menu_id.New:
                        Clear();
                        SPU_1621.Add();
                        Clear();
                        break;
                    case (int)Menu_id.Show:
                        SPU_1621.Sort();
                        break;
                    case (int)Menu_id.Remove:
                        Clear();
                        SPU_1621.Remove();
                        break;
                    case (int)Menu_id.Edit:
                        Clear();
                        SPU_1621.Edit();
                        break;
                    case (int)Menu_id.Search:
                        Clear();
                        SPU_1621.Search();
                        break;
                    case (int)Menu_id.Copy:
                        Clear();
                        Academy_Group group_clone = (Academy_Group)SPU_1621.Clone();
                        WriteLine("You cloned Your Group! Delete any student from Your previous group:\n");
                        SPU_1621.Remove();
                        WriteLine("Launch 'Show' to see Your old group'\n");
                        SPU_1621.Sort();
                        SPU_1621 = (Academy_Group)group_clone.Clone();
                        WriteLine("Now Your previous Group restored! Launch 'Show'\n");
                        break;
                    default:
                        Clear();
                        WriteLine("Bye");
                        SPU_1621.Save();
                        return;
                }
            }
        }
    }
}
