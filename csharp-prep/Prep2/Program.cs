using System;
using System.Collections.Generic; // Required for the List<T> data structure

// This class represents a single job and its details.
public class Job
{
    // Member variables to hold job details.
    public string _company; // The name of the company
    public string _jobTitle; // The title of the job
    public int _startYear; // The year the job started
    public int _endYear; // The year the job ended

    // Method to display job details in the format: "Job Title (Company) StartYear-EndYear"
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// This class represents a resume containing a person's name and a list of jobs.
public class Resume
{
    // Member variable to hold the person's name.
    public string _name;

    // Member variable to hold a list of jobs.
    // It is initialized to an empty list to avoid null reference issues.
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume details:
    // First, the person's name is displayed, followed by the details of each job.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}"); // Display the name
        Console.WriteLine("Jobs:"); // Display the jobs header

        // Loop through the list of jobs and call each job's Display method
        foreach (Job job in _jobs)
        {
            job.Display(); // Display details for each job
        }
        }
    }


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
