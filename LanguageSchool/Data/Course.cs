namespace LanguageSchool.Data
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public int AgeTypeId { get; set; }
        public AgeType AgeTypes { get; set; }

        public Category Category { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime RegData { get; set; }
         
    }
}
