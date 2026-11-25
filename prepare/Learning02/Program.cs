using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Microsoft Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2026;
        job1._endYear = 2030;


        Job job2 = new Job();
        job2._jobTitle = "Designer";
        job2._company = "Apple";
        job2._startYear = 2026;
        job2._endYear = 2028;

        Resume myResume =new Resume();
        myResume._name = "Ange Michel";


        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine(myResume._name);
        Console.WriteLine("Jobs:");
        job1.Display();
        job2.Display();
        
    }
}