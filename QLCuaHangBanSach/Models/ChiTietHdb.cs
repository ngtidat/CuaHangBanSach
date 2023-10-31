using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLCuaHangBanSach.Models
{
    public partial class ChiTietHdb
    {
        [Key]
        [Column(Order = 1)]
        public string MaSach { get; set; } = null!;
        public short SoLuong { get; set; }
        public decimal GiamGia { get; set; }
        public decimal DonGia { get; set; }
        [Key]
        [Column(Order = 2)]
        public string SoHd { get; set; } = null!;

        public virtual Sach MaSachNavigation { get; set; } = null!;
        public virtual Hdb SoHdNavigation { get; set; } = null!;
    }
}
