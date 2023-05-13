namespace jokesApp.Models
    // joke is the central part of our application
{
    public class Joke
    {
        // this Id is needed to reference it with the auto generated stuff from our Joke Controller.
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //constructor. For now leaving empty, for other parts of the code, it needs to be empty like this. 
        public Joke()
        {
             
        }
    }
}
