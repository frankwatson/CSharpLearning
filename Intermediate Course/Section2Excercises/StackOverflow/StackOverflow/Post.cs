using System;

namespace StackOverflow
{
    public class Post
    {
        // Properties
        private string _title;
        private string _description;
        private readonly DateTime _created = DateTime.Now;
        private int _voteCount;

        public void UpVote()
        {
            _voteCount += 1;
        }

        public void DownVote()
        {
            _voteCount -= 1;
        }

        public string CurrentVoteCount()
        {
            return string.Format("Post vote count: {0}  " +
                                 "Date Created: {1}  ", _voteCount, _created);
        }
    }
}