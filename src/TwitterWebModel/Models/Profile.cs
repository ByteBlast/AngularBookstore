﻿using System.Collections.Generic;

namespace Twitter.WebModel.Models
{
    public class Profile
    {
        public string UserName { get; set; }
        public IEnumerable<Tweet> Tweets { get; set; }
    }
}