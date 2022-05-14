using AutoMapper;
using SimpleCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrm.Application.Dto
{
    public class CustomerForReport
    {
       // public Guid Id { get; set; } // nie przekazuje 

        public string Name { get; set; } // true

        public string TaxNumber { get; set; }// true

        public string Email { get; set; } // true

        public string PhoneNumber { get; set; }// true

        public string StatusVat { get
            {
                if (TaxNumber != null)
                {
                    return "Czynny";
                }
                return null;
            } protected set { } }

        public string[] AccountNumbers { get; set; }
        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<Customer, CustomerForReport>();
        //}
        
       
    }
}
