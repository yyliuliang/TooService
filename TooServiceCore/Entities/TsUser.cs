using System;
using System.Collections.Generic;
using System.Text;

namespace TooService.Entities
{
    public class TsUser : Entity
    {
        public string LoginName { get; set; }

        public string DisplayName { get; set; }

        public string Password { get; set; }

        public string Avatar { get; set; }
    }
}
