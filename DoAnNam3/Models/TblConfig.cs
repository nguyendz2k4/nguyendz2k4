﻿using System;
using System.Collections.Generic;

namespace DoAnNam3.Models
{
    public partial class TblConfig
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Value { get; set; }
        public bool? Status { get; set; }
    }
}
