namespace OopExamPrep01.Domain
{
    public abstract class BaseMovie
    {

    }

    public class Movie : BaseMovie
    {
        public string Name { get; set; }
        public string Director { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public int RunningTime { get; set; } = 0;

        public Movie()
        {

        }

        public void SetRating(string _rating)
        {
            // Valid RAtings = G,PG,PG-13,R,NC_17

            List<string> validRatings = new() { "G", "PG", "PG-13", "R", "NC_17" };
           
            //Check this is a valid rating and if it is assign it
            if (validRatings.Contains(_rating))
            {
                Rating = _rating;
            } else
            {
                throw new InvalidDataException();
            }


        }

        public void SetRunningTime(int _runningTime)
        {
            RunningTime = _runningTime;
        }

        public override string ToString()
        {
            return $"{Name} is directed by {Director}, is rated {Rating} and has a running time of {RunningTime}";
        }
    }
}
