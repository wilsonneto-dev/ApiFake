using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFake.Entities
{
    public class Creator
    {
        public Creator(string name, string email, string link)
        {
            Id = Guid.NewGuid();
            Name = name;
            Link = link;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Link { get; private set; }
    }
}
