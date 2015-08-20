using EntryPoint.Exceptions.Common;
using System;

public class SimpleMathExam : Exam
{
    private int problemSolved;

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            problemsSolved = 0;
        }
        if (problemsSolved > 10)
        {
            problemsSolved = 10;
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { 
        get
        {
            return this.problemSolved;
        }

        private set
        {
            Validator.CheckIfNull<int>(value, "ProblemsSolved");
            Validator.CheckIfPositiveIntegerNumber(value, "ProblemsSolved");
            Validator.CheckIfIntegerInRange(value, 0, 10, "ProblemsSolved");

            this.problemSolved = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved >= 0 && this.problemSolved <= 4)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved >= 5 && this.ProblemsSolved< 8)
        {
            return new ExamResult(4, 2, 6, "Average result: " + this.ProblemsSolved + " problem(s) solved.");
        }
        else if (this.ProblemsSolved >= 8 && this.ProblemsSolved <= 10)
        {
            return new ExamResult(6, 2, 6, "Excellent result: " + this.ProblemsSolved + " problem(s) solved.");
        }

        throw new ArgumentException("Invalid exam results");
    }
}
