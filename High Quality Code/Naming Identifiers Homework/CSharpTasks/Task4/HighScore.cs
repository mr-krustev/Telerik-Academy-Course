namespace CSharpTasks
{
    public class HighScore
    {
        private string name;
        private int score;

        public HighScore()
        {
        }

        public HighScore(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Score
        {
            get { return this.score; }
            private set { this.score = value; }
        }
    }
}