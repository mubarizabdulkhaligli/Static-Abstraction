namespace task2;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Name: ");
        string name = Console.ReadLine();

        string groupNo;
        do
        {
            Console.WriteLine("Group No: ");
            groupNo = Console.ReadLine();

        } while (!Student.CheckGroupNo(groupNo));
        
            
        Student student1 = new Student();

        student1.Name = name;
        student1.GroupNo = groupNo;

        Console.WriteLine($"No: {student1.No}. Name : {student1.Name}; GroupNo: {student1.GroupNo}");
        


    }
}

