using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidation.Models
{
    public class Survey
        {
            [Required]
            [MinLength(2)]
            public string Name { get; set; }

            [Required]
            public string DojoLocation { get; set; }

            [Required]
            public string FaveLanguage { get; set; }

            [MaxLength(20)]
            public string Comment { get; set; }

        }

}