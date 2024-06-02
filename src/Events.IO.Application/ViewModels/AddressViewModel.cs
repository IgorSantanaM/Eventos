using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Events.IO.Application.ViewModels
{
    public class AddressViewModel
    {

        public AddressViewModel()
        {
            Id = Guid.NewGuid();    
        }
        public SelectList States()
        {
            return new SelectList(StateViewModel.ListStates(), "Abbreviation", "Name");
        }

        [Key]
            public Guid Id { get; set; }
            public string PublicPlace { get;  set; }
            public string Number { get;  set; }
            public string Complement { get;  set; }
            public string Neighborhood { get;  set; }
            public string ZipCode { get;  set; }
            public string City { get;  set; }
            public string State { get;  set; }

        public Guid EventId { get; set; }
        public override string ToString()
        {
            return PublicPlace + "," + Number + "-" + Complement + "," + Neighborhood + "-" + ZipCode + "," + City + "-" + State;
         }
    }
}
