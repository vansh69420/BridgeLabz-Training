class Program
{
    static void Main()
    {
        StudentDbUtility.GetAllStudents();

        StudentDbUtility.InsertStudent(107, "Rahul", 91, 2);
        StudentDbUtility.UpdateMarks(101, 98);
        StudentDbUtility.DeleteStudent(105);

        StudentDbUtility.GetAllStudents();
    }
}
