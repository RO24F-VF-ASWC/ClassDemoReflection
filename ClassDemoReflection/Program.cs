// See https://aka.ms/new-console-template for more information


using ClassDemoReflection;
using System.Reflection;

Person person = new Person(2,"Peter");
Console.WriteLine(person);



TryReflection(person);

void TryReflection(object obj)
{
    Type t = obj.GetType();

    Console.WriteLine("Name:" + t.FullName);
    Console.WriteLine("Interface:" + t.IsInterface);
    Console.WriteLine("Clas:" + t.IsClass);
    Console.WriteLine("Abstract:" + t.IsAbstract);
    Console.WriteLine("Base:" + t.BaseType);


    Console.WriteLine(" ==> Properties <=====");
    foreach (PropertyInfo pi in t.GetProperties())
    {
        Console.WriteLine(pi);
    }

    Console.WriteLine(" ===> Metoder <====");
    foreach(MethodInfo mi in t.GetMethods())
    {
        Console.WriteLine(mi);
    }


    Console.WriteLine(" ===> Call method <=======");
    var setId = t.GetMethods().First(m => m.Name == "set_Id");

    Console.WriteLine(" BEFORE " + obj);

    setId.Invoke(obj, new object?[] { 149 });

    Console.WriteLine(" After " + obj);




}