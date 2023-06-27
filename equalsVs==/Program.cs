// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a = 10;
int b = 10;
Console.WriteLine(a == b); // true
Console.WriteLine(b.Equals(a) + "\n"); // true 

string str1 = "Amit";
string str2 = "Amit";

Console.WriteLine(str1 == str2); // true
Console.WriteLine(str2.Equals(str1) + "\n"); // true

student std1 = new student();
student std2 = new student();

std1.studentName = "Amit Kumar";
std2.studentName = "Amit Kumar";

std1 = std2;

Console.WriteLine(std1 == std2); // false
Console.WriteLine(std2.Equals(std1) + "\n");// false

Console.WriteLine(std1.studentName == std2.studentName); // false
Console.WriteLine(std2.studentName.Equals(std1.studentName) + "\n");// false


object a1 = new string(new char[] { 'a', 'm', 'i', 't' });
object b1 = new string(new char[] { 'a', 'm', 'i', 't' });

Console.WriteLine(a1 == b1); //false
Console.WriteLine(a1.Equals(b1) + "\n"); // true

int num1 = 100;
byte num2 = 100;

Console.WriteLine(num1 == num2); //true
Console.WriteLine(num2.Equals(num1) + "\n");// false





class student
{
    public string studentName = string.Empty;
}
