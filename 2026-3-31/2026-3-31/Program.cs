namespace _2026_3_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student joe, mary;

            joe = new Student(1234, "AAA", 92, 88);
            Console.WriteLine(joe.GetStudent());

            mary = new Student(1234, "AAA", 92, 88);

            Console.WriteLine(Student.count.ToString());
        }
    }
}