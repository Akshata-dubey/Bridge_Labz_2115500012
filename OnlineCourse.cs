using System;

class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }
    public double Fee { get; set; }
    public static string InstituteName = "ABC Institute";

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} months, Fee: {Fee}, Institute: {InstituteName}");
    }

    public static void UpdateInstituteName(string newName)
    {
        InstituteName = newName;
    }
}

class OnlineCourseProgram
{
    // static void Main()
    // {
        // // Create instances of Course
        // Course course1 = new Course { CourseName = "C# Programming", Duration = 6, Fee = 5000 };
        // Course course2 = new Course { CourseName = "Web Development", Duration = 4, Fee = 4000 };

        // // Display course details
        // course1.DisplayCourseDetails();
        // course2.DisplayCourseDetails();

        // // Update Institute Name
        // Course.UpdateInstituteName("XYZ Institute");

        // // Display course details again to show the updated institute name
        // Console.WriteLine("\nAfter updating Institute Name:");
        // course1.DisplayCourseDetails();
        // course2.DisplayCourseDetails();
    // }
}
