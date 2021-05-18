namespace Treehouse.MediaLibrary
{
    class Album : MediaType
    {
        public readonly string Artist { get; private set; }

        public string DisplayText
        {
        get
         {
             return "Album: " + Title + " by " + Artist + OnLoanDisplayText;
              
                return text;

        }

        }
        
        public Album(string title, string artist) 
            : base(title)
        {
            Artist = artist;
        }
    }
}