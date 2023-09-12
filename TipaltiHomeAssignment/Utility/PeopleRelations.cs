using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipaltiHomeAssignment.Models;

namespace TipaltiHomeAssignment.Utility
{
    public class PeopleRelations
    {
        private Person[] _people;

        private Graph<Person> _peopleGraph;

        public void Init(Person[] people)
        {
            _people = people;
            _peopleGraph = new Graph<Person>();
            BuildRelations(people);
        }

        public int FindMinRelationLevel(Person personA, Person personB)
        {
            return _peopleGraph.ShortestPathLength(personA, personB);
        }

        private void BuildRelations(Person[] people) 
        {
            for (int i = 0; i < people.Length; i++)
            {
                Person person = people[i];

                for (int j = 0; j < people.Length; j++)
                {
                    //Get 1-level relation (Ignoring 0-level realtions)
                    if (person != people[j])
                    {
                        if (person.FullName.Equals(people[j].FullName) ||
                            person.Address.Equals(people[j].Address))
                        {
                            _peopleGraph.AddEdge(person, people[j]);
                        }
                    }
                }
            }
        }
    }
}
