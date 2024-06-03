using Events.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Domain.DEvents.Events
{
    public class AddressEventRegistredEvent : Event
    {
        public Guid Id { get; private set; }
        public string PublicPlace { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string Neighborhood { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public AddressEventRegistredEvent(Guid addressId, string publicPlace, string number, string complement, string neighborhood, string zipCode, string city, string state, Guid eventId)
        {
            Id = addressId;
            PublicPlace = publicPlace;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;    
            ZipCode = zipCode;
            City = city;
            State = state;
            AggregateId = eventId;
        }
    }
}
