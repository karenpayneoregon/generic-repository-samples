#nullable disable
using System.ComponentModel.DataAnnotations;
using ConsistencySampleLibrary.Interfaces;

namespace ConsistencySampleLibrary.Models;

/// <summary>
/// Represents a country entity with properties for identification and name.
/// </summary>
/// <remarks>
/// This class is part of the data model and implements the <see cref="Interfaces.IBase"/> interface.
/// It is used to store and retrieve country-related information.
/// </remarks>
public partial class Countries : IBase
{
    public int Id => CountryId;
    [Key]
    public int CountryId { get; set; }
    public string Name { get; set; }
    public override string ToString() => Name;
}