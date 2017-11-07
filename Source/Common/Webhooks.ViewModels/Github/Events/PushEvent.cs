﻿using System.Collections.Generic;

namespace Webhooks.ViewModels.Github.Events
{
    public class PushEvent
    {
        public string Ref { get; set; }
        public string Before { get; set; }
        public string After { get; set; }
        public bool Created { get; set; }
        public bool Deleted { get; set; }
        public bool Forced { get; set; }
        public object BaseRef { get; set; }
        public string Compare { get; set; }
        public List<Commit> Commits { get; set; }
        public HeadCommit HeadCommit { get; set; }
        public Repository Repository { get; set; }
        public Pusher Pusher { get; set; }
        public Sender Sender { get; set; }
    }
    
}