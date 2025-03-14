using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TPLOCAL1.Models
{
    public class Formulaire
    {
        public int Id { get; set; }
        [Required] public string? Nom { get; set; }
        [Required] public string? Prenom { get; set; }
        public string? Sexe { get; set; }
        public string? Adresse { get; set; }
        public int CodePostal { get; set; }
        public string? Ville { get; set; }
        [Required] public string? AdresseMail { get; set; }
        [Required] public DateOnly DateDebutFormation { get; set; }
        [Required] public string? NomFormation { get; set; }
        public string? AvisCobol { get; set; }
        public string? AvisCsharp { get; set; }


    }
}
