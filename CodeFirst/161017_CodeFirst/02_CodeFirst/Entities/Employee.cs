using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst.Entities
{
    // Tüm nitelikler propert'lerin veya class'ların üstüne yazılır.
    // Intlar boş geçilemez durumdadır. Boş geçebilmek için int? yaparız. 
    // Stringlerboş geçilebilir durumdadır. Boş geçilmemesi için [Reguired] yapıyorsunuz.
    [Table("Calisan")]
    class Employee
    {
        [Key] // Tabloya PrimaryKey alanı eklemek için kullanırım.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // PrimaryKey'e otomatik artan özelliği verdik.
        public int ID { get; set; }
        // String ifadeler geçerli alttaki 2 satır.
        [Column("Ad",TypeName="varchar")] // Kolon Adı ve Tipi.
      //  [MaxLength(25)] // Tipinin Boyutu.
        [MaxLength(25,ErrorMessage = "25 Karakterden fazla yazamazsınız!"),MinLength(2)]
    [Required] // Boş Geçilemez Yapmak için
        public string FirstName { get; set; }

    [Column("Soyad",TypeName="varchar")]
        [MaxLength(25)]
        public string LastName { get; set; }
        public string Address { get; set; }

        public int ComID { get; set; }
        [ForeignKey("ComID")]
        public Company Company { get; set; }

        [DisplayFormat(NullDisplayText = "XXX-XXX-XXXX")] // Girilen Format.
        public string Phone { get; set; }

      //  public string FullName { get { return FirstName + " " + LastName; } } // Sql'de gözükmicek veri girilmicek sadece First + Last'ı çekicek.

        [NotMapped]
        public string FullName { get; set; }  // Sql'de yer almıcak ama veri girebilicez.
    }
}
