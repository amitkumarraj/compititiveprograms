// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
TestMethod();
Console.WriteLine("Main Thread end");
Console.ReadKey();


static async void TestMethod()
{
    AsyncMethod();

}
static async void AsyncMethod()
{
    Console.WriteLine("Async Void");
}
