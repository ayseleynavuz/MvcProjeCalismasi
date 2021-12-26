using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Category
    {
        [Key]  //Attribute tanımlamaları 
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }  //projeden kaldırmak yerine aktiflik durumunu pasif hale getiriyor

        //ilişki oluşturma
        //heading sınıfıyla ilişkili ICollection türünde bir property oluşturuldu 
        public ICollection<Heading> Headings { get; set; }

    }
}
