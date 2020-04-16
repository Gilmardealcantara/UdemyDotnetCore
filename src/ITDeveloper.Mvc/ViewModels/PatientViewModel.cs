using System;
using ITDeveloper.Domain.Enums;

namespace ITDeveloper.Mvc.Models
{
    public class PatientViewModels
    {
        
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HospitalizationDate { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public bool Active { get; set; }
        public PatientType type { get; set; }
        public string RG { get; set; }
        public string RGEmitterOrgan { get; set; }
        public DateTime EmissionDate { get; set; }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
