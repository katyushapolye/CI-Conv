using System.Collections.Generic;

namespace DataStructs
    {

    public class ePistolariumNetwork 
    {
        public List<Link> links { get; set; }
        public int fullNodeCount { get; set; }
        public List<Node> nodes { get; set; }
    }
    public class Link
    {
        public int w { get; set; }
        public int source { get; set; }
        public int target { get; set; }
    }

    public class Node
    {
        public int w { get; set; }
        public int group { get; set; }
        public string name { get; set; }
    }
    }








