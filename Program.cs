using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crerating a post
            Post post = new Post("Post_Title", "Post_Description", DateTime.Now);
            //Downvoting the post
            post.DownVote();
            //Upvoting the post
            post.UpVote();
            //Displaying the current vote
            post.DisplayVote();
        }
    }

    public class Post
    {
        public string _title { get; set; }
        public string _description { get; set; }
        public DateTime _dateTime { get; set; }
        //Defining the vote private for preventing accidental changes of vote
        private int vote = 0;

        //Default Constructor
        public Post(){     
        }
        //Constructor with parameters title description and dateTime
        public Post(string title, string description, DateTime dateTime)
        {
            this._title = title;
            this._description = description;
            this._dateTime = dateTime;
        }

        public void UpVote()
        {
            vote += 1;
        }
        public void DownVote()
        {
            vote += -1;
        }
        
        public void DisplayVote()
        {
            System.Console.WriteLine("Current vote is {0}", vote);
        }
    }
}
