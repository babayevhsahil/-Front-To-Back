﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaxkendEterna.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string SkypeUrl { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

    }
}
