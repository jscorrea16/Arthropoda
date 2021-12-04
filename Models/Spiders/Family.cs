using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ArthrpodaASP.Models
{
    public class Family
    {
        public int FamilyId {get; set;}// primary key

        public string Name {get; set;}

        public InfraOrder InfraOrder {get; set;}// navigation property

        public int InfraOrderId {get; set;}// foreign key
        public override string ToString()
        {
            return $"({Name})";
        }
    }
}