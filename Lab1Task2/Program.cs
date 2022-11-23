using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Lab1Task2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Program p=new Program();
            int totalStudents;
            Console.WriteLine("Enter Total Subjects");
            totalStudents = Convert.ToInt32(Console.ReadLine());
            List<string> sub =p.Subjectname(totalStudents);
           List<int> numbers = p.MarksofSubject(sub);
            p.CalculateGpa(sub, numbers);
          

        }
        public List<string> Subjectname(int totalStudents)
        {
            List<string> subjects = new List<string>();
            for (int i = 1; i <=totalStudents; i++)
            {
                Console.Write("Enter Subject :: ");
                string subject = Console.ReadLine();
                subjects.Add(subject);
                ;

            }
            return subjects;
        }
        public List<int>  MarksofSubject(List<string> sub)
        {
            int length = sub.Count;
            List<int> marks = new List<int>();
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter Marks of {sub[i]} :: ");
                int mark = Convert.ToInt32(Console.ReadLine());
                marks.Add(mark);
            }
            return marks;
        }
        public void CalculateGpa(List<string> sub, List<int> numbers)
        {
            Console.WriteLine($"Sr. Subject Numbers  Grade");
            for (int i = 0; i < numbers.Count; i++)
            {
               
                if (numbers[i] > 84)
                {
                    
                    Console.WriteLine($"{i+1}    {sub[i]}     {numbers[i]}/100      A");
                } else if (numbers[i] >= 76 && numbers[i]<=83)
                {
                   
                    Console.WriteLine($"{i + 1}    {sub[i]}   {numbers[i]}/100     B");
                }
                else if (numbers[i] >= 66 && numbers[i] <= 75)
                {
                    
                    Console.WriteLine($"{i + 1}    {sub[i]}    {numbers[i]}/100    C");
                }
                else if (numbers[i] >= 50 && numbers[i] <= 65)
                {
                    
                    Console.WriteLine($"{i + 1}    {sub[i]}    {numbers[i]}/100     D");
                }
                else 
                {
                   
                    Console.WriteLine($"{i + 1}    {sub[i]}   {numbers[i]}/100     F");
                }
            }
        }
    }
}
