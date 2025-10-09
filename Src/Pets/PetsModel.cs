

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ApiTest.Src.Owners.Models;
using ApiTest.Src.OwnersPets.Models;
using ApiTest.Utils;


public enum ESex
{
    Male,
    Female,
    Unknown
}

namespace ApiTest.Src.Pets.Models
{
    public class Pet : BaseEntity
    {
        [Required]
        [Column("name")]
        [NotNull]
        public required string Name { get; set; }

        [Required]
        [Column("bred")]
        [NotNull]
        public required string Breed { get; set; }

        [Required]
        [Column("sexo")]
        [NotNull]
        public required ESex Sexo { get; set; }


        List<Owner> Owners { get; set; } = [];

        List<OwnersPet> OwnersPets { get; set; } = [];


    }
}