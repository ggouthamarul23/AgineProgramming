using System;
using System.Collections.Generic;
using System.Text;

namespace Agnie.Domain
{
    public class Subscriberinfo
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public IList<int> magazineIds { get; set; }

    }
    public class SubscriberDatamodel
    {
        public IList<Subscriberinfo> data { get; set; }
        public bool success { get; set; }
        public string token { get; set; }

    }
}
