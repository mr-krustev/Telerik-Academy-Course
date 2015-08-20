using System;
using System.Linq;
using System.Collections.Generic;
using EntryPoint.Exceptions.Common;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            Validator.CheckIfNull<string>(value, "FirstName");
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            Validator.CheckIfNull<string>(value, "LastName");
            this.lastName = value;
        }
    }
    public IList<Exam> Exams
    {
        get
        {
            return this.exams;
        }
        private set
        {
            Validator.CheckIfNull<IList<Exam>>(value, "Exams");
            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        Validator.CheckIfNull(this.Exams, "Exams");

        if (this.Exams.Count == 0)
        {
            return null;
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        Validator.CheckIfNull(this.Exams, "Exams");

        double[] examScore = new double[this.Exams.Count];
        
        IList<ExamResult> examResults = CheckExams();
        Validator.CheckIfNull(examResults, "ExamResults");

        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
