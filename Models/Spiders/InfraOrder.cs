using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ArthrpodaASP.Models
{
    public class InfraOrder
    {
        public int InfraOrderId {get; set;} // primary key

        public string Name {get; set;}
    }
}