﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Zambia_Police_Service.WEB
{
    public partial class Complaints
    {
        public int ComplaintId { get; set; }
        public byte[] ComplaintLocation { get; set; }
        public int? UserNumber { get; set; }
        public string ComplaintDescription { get; set; }

        public virtual PoliceUsers UserNumberNavigation { get; set; }
    }
}