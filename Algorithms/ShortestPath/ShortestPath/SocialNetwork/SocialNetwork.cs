using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath.SocialNetwork
{
    public class SocialNetwork
    {
        public static string[] GetShortestPathToFriend(PersonVertex fromPerson, PersonVertex toPerson)
        {
            var previousVertexTable = new Dictionary<string, string>();            

            var queue = new Queue<PersonVertex>();
            queue.Enqueue(fromPerson);
            var visitedPeople = new Dictionary<PersonVertex, bool>
            {
                [fromPerson] = true
            };

            while (queue.Count > 0)
            {
                var currentPerson = queue.Dequeue();
                
                foreach (var friend in currentPerson.Friends)
                {
                    if (visitedPeople.ContainsKey(friend)) continue;

                    visitedPeople[friend] = true;
                    queue.Enqueue(friend);

                    previousVertexTable[friend.Name] = currentPerson.Name;
                }
            }
            var result = new List<string>();
            var currentPersonValue = toPerson.Name;
            while (currentPersonValue != fromPerson.Name)
            {
                result.Add(currentPersonValue);
                currentPersonValue = previousVertexTable[currentPersonValue];
            }
            result.Add(fromPerson.Name);
            result.Reverse();

            return result.ToArray();
        }
    }
}
