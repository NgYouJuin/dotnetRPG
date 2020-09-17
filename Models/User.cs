using System.Collections.Generic;

namespace dotnetRPG.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public List<Character> Characters {get; set;}

        public Weapon Weapon { get; set; }
    }
}