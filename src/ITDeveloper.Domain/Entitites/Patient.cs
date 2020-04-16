﻿using System;
using ITDeveloper.Domain.Enums;

namespace ITDeveloper.Domain.Entitites
{
    public class Patient : EntityBase
    {
        public Patient()
        {
            this.HospitalizationDate = DateTime.Now;
            this.Active = true;
        }
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
            return $"{this.Id} - {this.Name}";
        }
    }
}