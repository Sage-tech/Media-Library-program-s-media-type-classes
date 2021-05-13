using System;

namespace Treehouse.MediaLibrary
{
    class MediaType
    {
        public string Title { get; private set; }

        public string Loanee { get; private set; } = "";
                public bool OnLoan { get; private set; } = false;
        
        public MediaType(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("A media type must have a title.");
            }
            
            Title = title;
        }

        public void Loan()
        {
            OnLoan = true;
        }
        
        public void Loan(string loanee)
        {
            Loanee = loanee;
            Loan();
        }
        
        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }        
    }
}