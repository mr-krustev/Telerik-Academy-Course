using EntryPoint.Exceptions.Common;
using System;

internal class CSharpExam : Exam
{
    private int score;

    internal CSharpExam(int score)
    {
        this.score = score;
    }

    internal int Score
    {
        get { return this.score; }
        private set
        {
            Validator.CheckIfIntegerInRange(value, 0, 100, "Score");

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}