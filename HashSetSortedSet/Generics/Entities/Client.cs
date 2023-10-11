using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics.Entities
{
    internal class Client
    {
        public String Name { get; set; }
        public string Email { get; set; }


        public override bool Equals(object obj)
        {   if(!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
