using Xunit;
using System;
using System.IO;

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Please Enter Your Name");
        string name = Console.ReadLine();
        // Console.ReadLine();
        Console.WriteLine("Please Enter the number of your subjects");
        int num_subject = int.Parse(Console.ReadLine());
        object[][] subjects = new object[num_subject][];
        
        for(int i = 0; i < num_subject; i++){
            Console.WriteLine("Please Enter the subject name");
            string subject_name = Console.ReadLine();
            Console.WriteLine("Please Enter the subject result");
            
            enter:
            double subject_results;
            string subject_result = Console.ReadLine();
            if (!double.TryParse(subject_result, out subject_results) || subject_results < 0 || subject_results > 100)
            {
                Console.WriteLine("Invalid Result, Please enter again");
                goto enter;
            }

            subjects[i] = new object[] { subject_name, subject_results };
        }
        double result,average;
        (result,average) = (0,0);
        Console.WriteLine($"Student Name: {name}");
        for(int i = 0; i < num_subject; i++){
            Console.WriteLine($"Your {subjects[i][0]} result is {subjects[i][1]}");
            result = result + (double)subjects[i][1];
        }
        average = result / num_subject;
        Console.WriteLine($"Your total result is {result} and total average is {average}");
    }
}
