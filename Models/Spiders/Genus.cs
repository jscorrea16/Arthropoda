using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ArthrpodaASP.Models
{
    public class Genus
    {
        public int GenusId {get; set;}// primary key

        public string Name {get; set;}

        public Family Family {get; set;}//navigation property

        public int FamilyId {get; set;}// foreign key

        public override string ToString()
        {
            return $"({Name})";
        }
    }
}