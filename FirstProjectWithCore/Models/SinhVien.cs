using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProjectWithCore.Models
{
    public class SinhVien
    {
        [Key]
        [Display(Name ="Mã Sinh Viên")]
        [Required(ErrorMessage = "Bạn phải nhập trường này")]
        public string MaSV { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name ="Tên Sinh Viên")]
        [Required(ErrorMessage = "Bạn phải nhập trường này")]
        public string TenSv { get; set; }
        [Column(TypeName = "nvarchar(50)")]
       // [Required(ErrorMessage = "Bạn phải nhập trường này")]
        [Display(Name ="Địa chỉ")]
        public string Address { get; set; }

    }
}
