﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EsadMVCProje.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
       // public ICollection<Yorumlars Yorumlars { get; set; }
    }

}