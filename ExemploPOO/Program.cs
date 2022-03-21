using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstraction
            Person p1 = new Person();
            p1.Name = "Bob";
            p1.Age = 20;
            p1.Display();

            // Encapsulation - invalid values
            Rectangle r2 = new Rectangle();
            r2.DefineMeasures(0, 0);
            System.Console.WriteLine($"Area: {r2.GetArea()}");

            // Encapsulation - valid values
            Rectangle r = new Rectangle();
            r.DefineMeasures(30, 30);
            System.Console.WriteLine($"Area: {r.GetArea()}");

            // Inheritance and polymorphism with the teacher class, through method override
            // (Early Binding)
            Teacher p2 = new Teacher();
            p2.Name = "Leo";
            p2.Age = 20;
            p2.Document = "123456";
            p2.Salary = 1000;
            p2.Display();

            // Inheritance and polymorphism with the student class, by overriding methods
            // (Late Binding)
            Student student = new Student();
            student.Name = "Bob";
            student.Age = 20;
            student.Document = "123456";
            student.Grade = 10;
            student.present();

            // Polymorphism with constructors (Early Binding)
            Calculator calc = new Calculator();
            System.Console.WriteLine("Result of the first sum: " + calc.Sum(10, 10));
            System.Console.WriteLine("Result of second sum: " + calc.Sum(10, 10, 10));

            // Inheritance with abstract class
            Current c = new Current();
            c.Credit(100);
            c.DisplayBalance();

            // Using interfaces
            ICalculator calcInterface = new Calculator();
            System.Console.WriteLine(calcInterface.Sum(10, 20));

            // Definition of paths to work with files
            var path = "C:\\WorkingWithFiles";
            var pathPathCombine = path.Combine(path, "Test Folder 1");
            var filepath = path.Combine(path, "file-test-stream.txt");
            var testFilePath = path.Combine(path, "testfile.txt");
            var pathFileTestCopy = path.Combine(path, "file-test-bkp.txt");
            var newFilePath = path.Combine(path, "Test Folder 2", "test-file-stream.txt");

            // Lines to be written to the file
            var listString = new List<string> { "Line 1", "Line 2", "Line 3" };
            var listStringContinued = new List<string> { "Line 4", "Line 5", "Line 6" };

            // File operations using our FileHelper
            FileHelper helper = new FileHelper(path);
            helper.ListDirectories(path);
            helper.ListFilesDirectories(path);
            helper.CreateDirectory(pathPathCombine);
            helper.DeleteDirectory(pathPathCombine, true);
            helper.CreateTextFile(filepath, "Hello! File writing test");
            helper.CreateFileTextStream(filepath, StringList);
            helper.AddTextStream(PathFile,ListStringContinued);
            helper.ReadFileStream(pathFile);
            helper.MoveFile(PathFile, newPathFile, false);
            helper.CopyFile(pathFileTest,pathFileTestCopy, false);
            helper.DeleteFile(pathFileTestCopy);
        }
    }
}
