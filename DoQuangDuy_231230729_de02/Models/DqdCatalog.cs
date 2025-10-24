using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoQuangDuy_231230729_de02.Models;

public partial class DqdCatalog
{
    public int DqdId { get; set; }
    [Required(ErrorMessage = "Tên không được để trống")]
    [Display(Name = "Tên sản phẩm")]
    public string DqdCateName { get; set; } = null!;
    [Required(ErrorMessage = "Giá phải là số")]
    [Range(100, 5000, ErrorMessage = "Giá phải nằm trong khoảng 100 đến 5000")]
    [Display(Name = "Giá")]
    public decimal DqdCatePrice { get; set; }
    [Required(ErrorMessage = "Số lượng")]
    [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải >= 0")]
    [Display(Name = "Số lượng")]
    public int DqdCateQty { get; set; }
    [Display(Name = "Ảnh")]
    public string? DqdPicture { get; set; }
    [Display(Name = "Trạng thái")]
    public bool DqdCateActive { get; set; }

}
