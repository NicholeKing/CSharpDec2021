using System;
using System.ComponentModel.DataAnnotations;

namespace loginRegDec.Models
{
    public class LogUser
    {
        [Required]
        [EmailAddress]
        // email pattern A-Z0-9@A-Z0-9.com/net(A-Z)
        public string lemail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string lpassword {get;set;}
    }
}
