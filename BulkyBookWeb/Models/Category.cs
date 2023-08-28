using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models;

public class Category
{
    //key kazdığımızda hata veriyorsa CRTL+. tuşuna basıp çıkan önerileri gözden geçir genelde küyüphane eksikliğinden oluyor
    [Key]
    //key yazarak id alanının primary key olduğunu bildirdik
    //prop+2 kere tab tuşu ile bu değişkenler atanabliri
    public int  Id { get; set; }
    [Required]
    // bunla da name alanının gerekli olduğunu boş geçilemez olduğunu bildirdik
    public string Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1,100, ErrorMessage ="Display order must be between 1 and 100 only!")]
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    //böylelikle datetime verisini default deger olarak şimdiki zaman ve tarih verisini atamış olduk
}
