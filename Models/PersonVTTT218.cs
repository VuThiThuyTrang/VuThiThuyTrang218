using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VuThiThuyTrang218.Models;
using VuThiThuyTrang218.Data;

namespace VuThiThuyTrang218.Models
{
    public class PersonVTTT218
    {
        [Key]
        public string PersonId { get; set; }
        public string PersonName { get; set; }
    }
}