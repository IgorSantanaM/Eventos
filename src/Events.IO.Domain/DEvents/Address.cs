﻿using Events.IO.Domain.Core.Models;
using FluentValidation;

namespace Events.IO.Domain.DEvents
{
    public class Address : Entity<Address>
    {

        public string  PublicPlace { get; private set; }
        public string  Number { get; private set; }
        public string  Complement { get; private set; }
        public string Neighborhood { get; private set; }
        public string  ZipCode { get; private set; }
        public string  City { get; private set; }
        public string  State{ get; private set; }
        public Guid? EventId { get; private set; }

        //EF
        public virtual DEvent DEvent { get; private set; }

        public Address(Guid id, string publicPlace, string number, string complement, string neighborhood, string zipCode, string city, string state, Guid? eventId)
        {
            Id = id;
            PublicPlace = publicPlace;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            City = city;
            State = state;
            EventId = eventId;

        }
        //contrutor EF
        protected Address() { }
        public override bool IsValidate()
        {
<<<<<<< HEAD
                #region ValidationsAddress

                RuleFor(c => c.PublicPlace)
                .NotEmpty().WithMessage("The street name must be provided")
                .Length(2, 150).WithMessage("The street name must be between 2 and 150 characters");

            RuleFor(c => c.Neighborhood)
                .NotEmpty().WithMessage("The neighborhood must be provided")
                .Length(2, 150).WithMessage("The neighborhood must be between 2 and 150 characters");

            RuleFor(c => c.ZipCode)
                .NotEmpty().WithMessage("The ZIP code must be provided")
                .Length(8).WithMessage("The ZIP code must be 8 characters long");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("The city must be provided")
                .Length(2, 150).WithMessage("The city must be between 2 and 150 characters");

            RuleFor(c => c.State)
                .NotEmpty().WithMessage("The state must be provided")
                .Length(2, 150).WithMessage("The state must be between 2 and 150 characters");

            RuleFor(c => c.Number)
                .NotEmpty().WithMessage("The number must be provided")
                .Length(1, 10).WithMessage("The number must be between 1 and 10 characters");
=======
            #region ValidacoesEnd

            RuleFor(c => c.PublicPlace)
                .NotEmpty().WithMessage("O longradouro precisa ser fornecido")
                .Length(2, 150).WithMessage("O longradouro precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Neighborhood)
                .NotEmpty().WithMessage("O bairro precisa ser fornecido")
                .Length(2, 150).WithMessage("O bairro precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.ZipCode)
                .NotEmpty().WithMessage("O cep precisa ser fornecido")
                .Length(8).WithMessage("O cep precisa ter entre 8 caracteres");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("O cidade precisa ser fornecido")
                .Length(2, 150).WithMessage("O cidade precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.State)
                .NotEmpty().WithMessage("O estado precisa ser fornecido")
                .Length(2, 150).WithMessage("O estado precisa ter entre 2 e 150 caracteres");

            RuleFor(c => c.Number)
                .NotEmpty().WithMessage("O numero precisa ser fornecido")
                .Length(1, 10).WithMessage("O numero precisa ter entre 1 e 10 caracteres");
>>>>>>> TesteApi

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;

            #endregion
<<<<<<< HEAD
=======

>>>>>>> TesteApi
        }
    }
}