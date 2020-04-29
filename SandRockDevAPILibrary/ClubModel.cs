using System;
using System.Collections.Generic;
using System.Text;

namespace SandRockDevAPILibrary
{
    public class ClubModel
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string SmallName { get; set; }
        public string Abb { get; set; }
        public string Photo { get; set; }
        public string ClubInfo { get; set; }
        public string Email { get; set; }
        public string FaceBook { get; set; }
        public DateTime RegisteredTime { get; set; }
        public bool Active { get; set; }
    }
}
