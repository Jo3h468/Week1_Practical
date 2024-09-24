Console.WriteLine("Enter you name");
string name = Console.ReadLine();

Console.WriteLine("Enter you age");
int age =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello " + name + " you will be " + (age+= 5) + " in 5 years");
