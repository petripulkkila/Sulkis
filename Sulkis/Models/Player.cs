using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sulkis.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string NickName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}