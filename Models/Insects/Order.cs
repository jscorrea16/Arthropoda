using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ArthrpodaASP.Models
{
    public class Order
    {
        public int OrderId {get; set;} // primary key

        public string Name {get; set;}
    }
}