using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ITDeveloper.Domain.Entitites {
    public class PatientState : EntityBase {
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(maximumLength: 20, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Description { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}