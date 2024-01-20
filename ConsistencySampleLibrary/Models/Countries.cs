#nullable disable
using System.ComponentModel.DataAnnotations;
using ConsistencySampleLibrary.Interfaces;

namespace ConsistencySampleLibrary.Models;

public partial class Countries : IBase
{
    public int Id => CountryId;
    [Key]
    public int CountryId { get; set; }
    public string Name { get; set; }
    public override string ToString() => Name;
}