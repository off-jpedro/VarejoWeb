using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{
    public class CarBrand
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Status? Status { get; set; }
    }
}