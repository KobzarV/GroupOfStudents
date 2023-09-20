using GroupsOfStudents;


class Program
{
    static void Main(string[] args)
    {
        Group gr1 = new Group();
        Group gr2 = new Group();
        Group gr3 = new Group(gr1);
        Group gr4 = new Group();
        gr1.EditGroup("Group 1", "121");
        gr1.GroupInfo();
        gr1.AddStudent(new Studentns.Student("new","Student","1"));
        gr1.AddStudent(new Studentns.Student("new2", "Stu", "1"));
        gr1.DeleteBadStudent();
        gr1.GroupInfo();
        gr1.DeleteStudents();
        gr1.GroupInfo();

        gr1.TransferStudent(gr1.GetStudent(7), gr2);
        gr2.GroupInfo();
        gr3.GroupInfo();
        gr3.GetStudent(0).EditStudent();
        gr3.GetStudent(0).Info();

        gr4.EditGroupStudent(gr3.GetStudent(0));
    }
}