using System.ComponentModel.DataAnnotations;
namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(20)]
    public string ParkName { get; set; }
    [Required]
    [StringLength(10)]
    public string ParkType { get; set; }
    [Required]
    [StringLength(50)]
    public string ParkAddress { get; set; }
    [Required]
    public bool? ParkPetsAllowed { get; set; }
    [Required]
    public bool? ParkStore { get; set; }
  }
}