﻿using System;
using System.Collections.Generic;

namespace SailingManagerDatabase
{
    public partial class Clubs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Homepage { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Logotype { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationTime { get; set; }
    }
}
