namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string ParkName { get; set; }
    public string ParkType { get; set; }
    public string ParkAddress { get; set; }
    public bool ParkPetsAllowed { get; set; }
    public bool ParkStore { get; set; }
  }
}