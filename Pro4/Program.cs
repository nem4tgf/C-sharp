//c# collection
using Pro4;

class Program{
    public static void Main(string[] args){
        //List<T>
        List<string> students = new List<string>{"Thu","THao","MAnh"};
        students.Add("Haong");
        Console.WriteLine("List of Students: ");
        foreach(var student in students){
            Console.WriteLine(student);
        }
        //LinkedList<T>: danh sach lien ket dong(2 chieu) phu hop them xoa danh sach o vi tri bat ly
        LinkedList<string> languages = new LinkedList<string>();
        languages.AddLast("C#");
        languages.AddLast("Java");
        languages.AddFirst("Python");
        languages.AddFirst("Scala");
        Console.WriteLine("LinkedList of Programming languages: ");
        foreach(var language in languages){
            Console.WriteLine(language);
        }
        //stack<T> LIFO => xu li nguoc cua gia tri them vao
        Stack<string> books = new Stack<string>();
        books.Push("Java");
        books.Push("C#");
        books.Push("Python");
        Console.WriteLine("Stack of books: ");
        while(books.Count > 0){
             Console.WriteLine(books.Pop());
        }
        //Queue<T>FIFO, xu li theo thu tu them vao: vao trc xu ly trc theo dung trinh tu
        Queue<string> customers = new Queue<string>();
        customers.Enqueue("cus1");
        customers.Enqueue("cus2");
        customers.Enqueue("cus3");
        customers.Enqueue("cus4");
        Console.WriteLine("Queue of Customer: ");
        while(customers.Count > 0){
             Console.WriteLine(customers.Dequeue());
        }
        //Dictionary<TKey,TValue> => truy cap gia tri nhanh qua key
        Dictionary<int,string> studenGrades = new Dictionary<int, string>{
            {1,"A"},
            {2,"B"},
            {3,"C"}
        };
        //HashSet<T>: Ko turng lap gia tri, ko sap xep, Dma bao gia tri duy nhat.
        HashSet<string> cities = new HashSet<string>{"Ha Noi", "TP.HCM", "Hai Phong"};
        cities.Add("Ha Tinh");
        cities.Add("Nam DInh");
        Console.WriteLine("HashSet of cities: ");
        foreach(var city in cities){
            Console.WriteLine(city);
        }
        //Tao repository cho Student
    EntityRespository<Student> studentRepository = new EntityRespository<Student>();
    //Tao repository cho SchoolClass
    EntityRespository<SchoolClass> schoolClassRepository = new EntityRespository<SchoolClass>();
    //Tao repository cho Teacher
    EntityRespository<Teacher> teacherRepository = new EntityRespository<Teacher>();

    //Add
    studentRepository.Add(new Student{Id=1,Name="Gia Binh"});
    foreach(var student in studentRepository.GetAll()){
        Console.WriteLine(student);
    }
    schoolClassRepository.Add(new SchoolClass{Id=101,Name="C#"});
    foreach(var SchoolClass in schoolClassRepository.GetAll()){
        Console.WriteLine(SchoolClass);
    }
    teacherRepository.Add(new Teacher{Id=201,Name="Huy"});
    foreach(var Teacher in teacherRepository.GetAll()){
        Console.WriteLine(Teacher);
    }
    }
    
}