using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class DonGiaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Giá không được để trống")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Xin nhập số và không bỏ trống")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal DonGiaBan { get; set; }
        [Required(ErrorMessage = "Ngày áp dụng không được để trống")]
        public DateTime Ngay { get; set; }
        [Required(ErrorMessage = "Giảm giá không được để trống")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Xin nhập số và không bỏ trống")]
        public int GiamGia { get; set; }
        public bool ApDung { get; set; }
        public LinhKienDTO LinhKien { get; set; }
    }
}
