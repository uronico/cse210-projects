using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Business Development Executive";
        job1._company = "ACCPRO Interentional";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Virtual Assistant";
        job2._company = "Fullforce.ph";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Nico Uro";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}