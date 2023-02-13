namespace LanguageSchool.Data
{
    public class SchoolYear
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Courses { get; set; }

        public int Year { get; set; }

        public int Date { get; set; }

        public int Duration { get; set; }

        public int MethodId { get; set; }

        public Method Methods { get; set; }

        public double Price { get; set; }

        public string Description { get; set; } 

        public int BookPrice { get; set; }

        public DateTime RegData { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
