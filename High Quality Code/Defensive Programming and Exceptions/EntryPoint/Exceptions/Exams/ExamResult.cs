using EntryPoint.Exceptions.Common;
using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        // Dear reader, I had no idea where to put this. If you have better idea be sure to tell me! :)
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("MaxGrade cannot be less or equal to MinGrade.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
    internal int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            Validator.CheckIfNull<int>(value, "MinGrade");
            Validator.CheckIfPositiveIntegerNumber(value, "MinGrade");
            this.minGrade = value;
        }
    }

    internal int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            Validator.CheckIfNull<int>(value, "MaxGrade");
            Validator.CheckIfPositiveIntegerNumber(value, "MaxGrade");
            this.maxGrade = value;
        }
    }

    internal string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            Validator.CheckIfNull<string>(value, "Comments");
            Validator.CheckIfEmptyString(value, "Comments");
            this.comments = value;
        }
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            Validator.CheckIfNull<int>(grade, "Grade");
            this.grade = value;
        }
    }
}
