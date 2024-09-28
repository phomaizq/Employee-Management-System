﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Town: BaseEntity
    {
        //One to many relationship with Employees
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }

        //Many to One relationship with City
        //public City? City { get; set; }
        public int CityID { get; set; }
    }
}
