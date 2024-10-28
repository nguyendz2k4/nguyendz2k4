﻿using System.ComponentModel.DataAnnotations;

namespace DoAnNam3.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(4,ErrorMessage ="Yêu cầu nhập tên danh mục")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên danh mục")]
        public string Description { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả")]
        public string Slug { get; set; }
        public int Status { get; set; }

    }
}
