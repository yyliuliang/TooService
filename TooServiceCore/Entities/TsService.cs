using System;
using System.Collections.Generic;
using System.Text;

namespace TooService.Entities
{
    public class TsService : Entity
    {
        public string Name { get; set; }

        public string CategoryId { get; set; }

        public ChargeMode ChargeMode { get; set; }

        public string Description { get; set; }

        public string WebsiteUrl { get; set; }
        
    }


    public enum ChargeMode
    {
        Free = 0,
        FreeTrial = 1,
        Fee = 2
    }

}
