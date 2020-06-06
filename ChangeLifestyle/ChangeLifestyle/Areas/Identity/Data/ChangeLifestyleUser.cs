using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;

namespace ChangeLifestyle.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ChangeLifestyleUser class
    public class ChangeLifestyleUser : IdentityUser
    {
        [DisplayName("Nume")]
        [Column(TypeName ="nvarchar(100)")]
        public string Nume { get; set; }

        [DisplayName("Prenume")]
        [Column(TypeName = "nvarchar(100)")]
        public string Prenume { get; set; }

        [DisplayName("Varsta")]
        [Column(TypeName = "int")]
        public int Varsta { get; set; }

        [DisplayName("Greutate")]
        [Column(TypeName = "float(7)")]
        public float Greutate { get; set; }

        [DisplayName("Inaitlmea")]
        [Column(TypeName = "int")]
        public int Inaltimea { get; set; }

        [DisplayName("Data")]
        [Column(TypeName = "DateTime")]
        public DateTime Data { get; set; }

        [DisplayName("Grasime Corporala")]
        [Column(TypeName = "float(7)")]
        public float rezultat1 { get; set; }

        [DisplayName("Grad Grasime")]
        [Column(TypeName = "nvarchar(100)")]
        public string rezultat2 { get; set; }

        [DisplayName("Sex")]
        [Column(TypeName ="nvarchar(100)")]
        public string Sex { get; set; }
    }
}
