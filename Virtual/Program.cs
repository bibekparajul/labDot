namespace Virtual
{
    public class Program
    {
        public static void Main()
        {
            //Student s = new Student
            //{
            //    Email = "abc@gmail.com",
            //    Name = "Bibek",
            //    Phone = "82819"
            //};
            //s.Display();
            //Teacher teacher = new Teacher();
            //teacher.Display();
            Person P = new Person("hello", "hello@gmail.comm", "111");
            Student s = new Student("Bbek", "bek@gmail.com", "98219", 1);

            s.Display();
        }
    }
}