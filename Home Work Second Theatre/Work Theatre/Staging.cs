namespace Work_Theatre
{
    public class Staging
    {
        public string StagingName;
        public string Director;
        public string Type;
        public int Request;

        public Staging(string name, string director, string type, int request = 20)
        {
            StagingName = name;
            Director = director;
            Type = type;
            Request = request;
        }
    }
}