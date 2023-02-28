using System.Diagnostics.CodeAnalysis;

namespace StrategyDP
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {Lastname} ID: {ID}";
        }

        public Student()
        {

        }

        public Student(string name, int id)
        {
            FirstName = name;
            Lastname = name;
            ID = id;
        }
        public override int GetHashCode() => ID;

        public override bool Equals(object obj) =>
        obj is Student student
                ? Equals(student)
                : false;


        public int CompareTo([AllowNull] Student other) =>
            other == null ? 1 : ID.CompareTo(other.ID);
        public bool Equals(Student other) =>
            other is null ? false : ID.Equals(other.ID);

        public static bool operator >(Student s1, Student s2) => s1.ID > s2.ID;
        public static bool operator <(Student s1, Student s2) => s1.ID < s2.ID;

    }
}
