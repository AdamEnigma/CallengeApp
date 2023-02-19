Employee user1 = new Employee("Adam", "Kamiński", 30);
Employee user2 = new Employee("Dawid", "Marchewka", 42);
Employee user3 = new Employee("Zenon", "Burak", 52);

user1.AddScore(1);
user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(4);
user1.AddScore(5);

user2.AddScore(2);
user2.AddScore(3);
user2.AddScore(4);
user2.AddScore(5);
user2.AddScore(6);

user3.AddScore(4);
user3.AddScore(5);
user3.AddScore(6);
user3.AddScore(7);
user3.AddScore(8);


List<Employee> employeess = new List<Employee>()
{
    user1, user2, user3
};
var maxResult = -1;
Employee userWithMaxResult = null;

foreach (var employee in employeess)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        userWithMaxResult = employee;

    } 
}
Console.WriteLine("Pracownik z największą ilością punktów" +  "\n" + userWithMaxResult.Name + " " + userWithMaxResult.Surname + " lat " + userWithMaxResult.Age);
public class Employee
{
    private List<int> score = new List<int>();
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }

    public Employee(string Name, string Surname, int Age)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
}
