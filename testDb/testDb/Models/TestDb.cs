using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace testDb.Models
{
    public class TestDb :DbContext
    {
        public DbSet<Car> Cars { get; set; }
       
    }

    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string CarName { get; set; }
        public string Image { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

    }
}