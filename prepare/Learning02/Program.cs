using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first job instance and set its details
        Job job1 = new Job();
        job1._company = "Microsoft"; // Set the company name
        job1._jobTitle = "Software Engineer"; // Set the job title
        job1._startYear = 2019; // Set the start year
        job1._endYear = 2022; // Set the end year

        // Create the second job instance and set its details
        Job job2 = new Job();
        job2._company = "Apple"; // Set the company name
        job2._jobTitle = "Manager"; // Set the job title
        job2._startYear = 2022; // Set the start year
        job2._endYear = 2023; // Set the end year

        // Create a new resume instance
        Resume myResume = new Resume();
        myResume._name = "John Doe"; // Set the person's name for the resume

        // Add the jobs to the resume's list of jobs
        myResume._jobs.Add(job1); // Add the first job
        myResume._jobs.Add(job2); // Add the second job

        // Display the complete resume (name and job details)
        myResume.Display();
    }
}