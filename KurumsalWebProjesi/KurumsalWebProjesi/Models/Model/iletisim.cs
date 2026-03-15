using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KurumsalWebProjesi.Models.Model
{
    [Table("iletisim")]
    public class iletisim
    {
        [Key]
        public int iletisimId { get; set; }
        [StringLength(250,ErrorMessage ="250 karakter olmalı..")]
        public string Adres { get; set; }
        [StringLength(250, ErrorMessage = "250 karakter olmalı..")]
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Whatsapp { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}