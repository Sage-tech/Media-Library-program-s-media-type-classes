namespace Treehouse.MediaLibrary
{
    class Movie : MediaType
    {
        public string Director {get;  private set;}
        
        public Movie(string title, string director)
            : base(title)
        {
            Director = director;
        }

        public string GetDisplayText()
        {
            string text = "Movie: " + Title + " by " + Director;
            
            if (OnLoan)
            {
                if (!string.IsNullOrEmpty(Loanee))
                {
                    text += " (Currently on loan to " + Loanee + ")";
                }
                else
                {
                    text += " (Currently on loan)";
                }                
            }
            
            return text;
        }
    }
}