using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ArthrpodaASP.Models
{
    public class Familyinsect
    {
        public int FamilyinsectId {get; set;}// primary key

        public string Name {get; set;}

        public Order Order {get; set;}// navigation property

        public int OrderId {get; set;}// foreign key
        public override string ToString()
        {
            return $"({Name})";
        }
    }
}