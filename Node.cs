using System;

namespace Assignment3
{
    [Serializable]
    public class Node
    {
        public User Value { get; set; }
        public Node Next { get; set; }

        public Node(User data)
        {
            this.Value = data;
        }

    }
}

