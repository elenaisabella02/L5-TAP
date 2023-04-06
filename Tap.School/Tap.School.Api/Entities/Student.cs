namespace Tap.School.Api.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        //added LastName for exercise 4
        public string LastName { get; set; }


        public ICollection<Grade> Grades { get; set; }

    }
}
