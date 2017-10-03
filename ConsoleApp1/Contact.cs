using System;

namespace ConsoleApp1
{
    public class Contact
    {
        public virtual Guid? Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Email { get; set; }
    }
}
