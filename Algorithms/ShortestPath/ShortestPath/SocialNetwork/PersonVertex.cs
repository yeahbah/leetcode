using System.Collections.Generic;
using System.Linq;

namespace ShortestPath.SocialNetwork
{
    public class PersonVertex
    {
        private readonly List<PersonVertex> _friends = new();
        
        public PersonVertex(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public IEnumerable<PersonVertex> Friends => _friends.AsEnumerable();

        public void AddFriend(PersonVertex personVertex)
        {
            _friends.Add(personVertex);
        }
        
    }
}
