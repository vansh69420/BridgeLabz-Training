using Microsoft.Data.SqlClient;
using System;

public class StudentDbUtility
{
    /* ================= SELECT ================= */

    public static void GetAllStudents()
    {
        string query = "SELECT * FROM student_records";

        using SqlConnection conn = DatabaseConfig.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(
                $"ID: {reader["student_id"]}, " +
                $"Name: {reader["student_name"]}, " +
                $"Marks: {reader["marks"]}"
            );
        }
    }

    /* ================= INSERT ================= */

    public static void InsertStudent(int id, string name, int marks, int deptId)
    {
        string query = @"
        INSERT INTO student_records
        (student_id, student_name, marks, dept_id)
        VALUES (@id, @name, @marks, @deptId)";

        using SqlConnection conn = DatabaseConfig.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@marks", marks);
        cmd.Parameters.AddWithValue("@deptId", deptId);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Student inserted successfully.");
    }

    /* ================= UPDATE ================= */

    public static void UpdateMarks(int studentId, int newMarks)
    {
        string query =
            "UPDATE student_records SET marks=@marks WHERE student_id=@id";

        using SqlConnection conn = DatabaseConfig.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@marks", newMarks);
        cmd.Parameters.AddWithValue("@id", studentId);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Marks updated.");
    }

    /* ================= DELETE ================= */

    public static void DeleteStudent(int studentId)
    {
        string query =
            "DELETE FROM student_records WHERE student_id=@id";

        using SqlConnection conn = DatabaseConfig.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@id", studentId);
        cmd.ExecuteNonQuery();

        Console.WriteLine("Student deleted.");
    }
}
