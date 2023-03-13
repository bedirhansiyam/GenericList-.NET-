namespace GenericList;
class Program
{
    static void Main(string[] args)
    {
        // List<T> class
        // System.Collections.Generic
        // T-> object type

        List<int> numberList = new List<int>();
        numberList.Add(13);
        numberList.Add(23);
        numberList.Add(5);
        numberList.Add(75);
        numberList.Add(54);
        numberList.Add(22);

        List<string> colorList = new List<string>();
        colorList.Add("Blue");
        colorList.Add("Yellow");
        colorList.Add("White");
        colorList.Add("Green");
        colorList.Add("Pink");

        // Count
        Console.WriteLine(colorList.Count);   //5
        Console.WriteLine(numberList.Count);  //6

        // foreach & List.ForEach        
        foreach (var number in numberList)
        {
            Console.WriteLine(number);
        }
         foreach (var color in colorList)
        {
            Console.WriteLine(color);
        }

        numberList.ForEach(number => Console.WriteLine(number));
        colorList.ForEach(color => Console.WriteLine(color));

        // Remove & RemoveAt
        numberList.Remove(54);   // item
        colorList.Remove("Pink");   // item

        numberList.RemoveAt(1);   // index
        colorList.RemoveAt(2);   // index

        // Contains
        if(numberList.Contains(22))
            Console.WriteLine("Number List has 22");

        // BınarySearch
        Console.WriteLine(colorList.BinarySearch("Blue"));   // 0

        // Convert array to list
        string[] animals = {"Cat", "Dog", "Bird"};        
        List<string> animalList = new List<string>(animals);

        // Clear
        animalList.Clear();

        // class List
        List<Users> userList = new List<Users>();

        Users user1 = new Users();
        user1.Name = "Bedirhan";
        user1.Surname = "Siyam";
        user1.Age = 30;

        Users user2 = new Users();
        user2.Name = "Cengizhan";
        user2.Surname = "Siyam";
        user2.Age = 24;

        userList.Add(user1);
        userList.Add(user2);

        List<Users> newList = new List<Users>();
        newList.Add(new Users(){
            Name = "Arda",
            Surname = "Güler",
            Age = 18
        });


        foreach (var user in userList)
        {
            Console.WriteLine("User name : " + user.Name);
            Console.WriteLine("User surname : " + user.Surname);
            Console.WriteLine("User age : " + user.Age);
        }

    }
}

public class Users
{
    private string name;
    private string surname;
    private int age;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Age { get => age; set => age = value; }
}
