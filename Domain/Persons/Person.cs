using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persons
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        //should be a relationship one to many with document type
        //because the person could have many documents like pasport, ci..etc
        public string Document { get; set; }
        public string Mail { get; set; }
        
    }
}
