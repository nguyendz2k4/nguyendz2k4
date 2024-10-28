﻿using System;
using System.Collections.Generic;

namespace DoAnNam3.Models
{
    public partial class TblProduct
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? SeoTitle { get; set; }
        public bool? Status { get; set; }
        public string? Image { get; set; }
        public string? ListImages { get; set; }
        public decimal? Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public bool? Vat { get; set; }
        public int? Quantity { get; set; }
        public int? Warranty { get; set; }
        public DateTime? Hot { get; set; }
        public string? Decription { get; set; }
        public string? Detail { get; set; }
        public int? ViewCount { get; set; }
        public int? CateId { get; set; }
        public int? UpdateBy { get; set; }
        public int? BraindId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? MetaKeyWords { get; set; }
        public string? MetaDecription { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
