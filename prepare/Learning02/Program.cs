using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "MEF";
        job1._jobTitle = "Accountant";
        job1._startYear = 2019;
        job1._endYear = 2022;
      

        Job job2 = new Job();
        job2._company = "Cámara de Senadores";
        job2._jobTitle = "Financial Advice";
        job2._startYear = 2022;
        job2._endYear = 2024;
        
        Resume myResume = new Resume();
        myResume._name = "Vanesa Laino";
        
        myResume._jobs.Add(job1); 
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}