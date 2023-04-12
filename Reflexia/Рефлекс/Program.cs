using System;
using System.IO;
using System.Reflection;

namespace BadImageFormatException
{
    class Program
    {
        static void Main()
        {
            Type t = typeof(System.BadImageFormatException);
            Console.WriteLine($"{t.Name}");
            Console.WriteLine();

            // Получаем все методы класса 
            MethodInfo[] methods = t.GetMethods();
            //Получаем все конструктуры класса
            ConstructorInfo[] constructors = t.GetConstructors();
            //Получаем все поля класса
            FieldInfo[] fields = t.GetFields();
            //Получаем все свойства класса
            PropertyInfo[] properties = t.GetProperties();


            // Запускается цикла по каждому заданию и выводится значения
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine($"Method Name: {method.Name}");
                Console.WriteLine($"IsAbstract: {method.IsAbstract}");
                Console.WriteLine($"IsFamily: {method.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {method.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {method.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {method.IsAssembly}");
                Console.WriteLine($"IsPrivate: {method.IsPrivate}");
                Console.WriteLine($"IsPublic: {method.IsPublic}");
                Console.WriteLine($"IsConstructor: {method.IsConstructor}");
                Console.WriteLine($"IsStatic: {method.IsStatic}");
                Console.WriteLine($"IsVirtual: {method.IsVirtual}");
                Console.WriteLine($"Return Type: {method.ReturnType}");
                Console.WriteLine();
            }
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine($"Constructor Name: {constructor.Name}");
                Console.WriteLine($"IsFamily: {constructor.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {constructor.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {constructor.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {constructor.IsAssembly}");
                Console.WriteLine($"IsPrivate: {constructor.IsPrivate}");
                Console.WriteLine($"IsPublic: {constructor.IsPublic}");
                Console.WriteLine();
            }
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"Field Name: {field.Name}");
                Console.WriteLine($"IsFamily: {field.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {field.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {field.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {field.IsAssembly}");
                Console.WriteLine($"IsPrivate: {field.IsPrivate}");
                Console.WriteLine($"IsPublic: {field.IsPublic}");
                Console.WriteLine($"IsStatic: {field.IsStatic}");
                Console.WriteLine();
            }
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"Property Name: {property.Name}");
                Console.WriteLine($"Attributes: {property.Attributes}");
                Console.WriteLine($"CanRead: {property.CanRead}");
                Console.WriteLine($"CanWrite: {property.CanWrite}");
                Console.WriteLine($"GetMethod: {property.GetGetMethod()}");
                Console.WriteLine($"SetMethod: {property.GetSetMethod()}");
                Console.WriteLine($"PropertyType: {property.PropertyType}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
