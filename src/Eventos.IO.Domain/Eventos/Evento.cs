using Eventos.IO.Domain.Core.Models;
using FluentValidation;
using Eventos.IO.Domain.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Eventos.IO.Domain.Eventos
{
    public class Evento : Entity<Evento>
    {
        public Evento(string nome, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;
        }

        public Evento() {}
        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
        public bool Excluido { get; private set; }
        public ICollection<Tags> Tags { get; private set; }
        public Guid? CategoriaId { get; private set; }
        public Guid? EnderecoId { get; private set; }
        public Guid? OrganizadorId { get; private set; }



        //EF
        public virtual Categoria Categoria { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public virtual Organizador Organizador { get; private set; }


        public void AtribuirEndereco(Endereco endereco)
        {
            if (!endereco.EhValido()) return;
            Endereco = endereco;
        }
        public void ExcluirEvento()
        {
            Excluido = true;
        }
        
        public void AtribuirCategoria(Categoria categoria)
        {
            if (!categoria.EhValido()) return;
            Categoria = categoria;
        }
        public override bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }
        #region Validacoes

        private void Validar()
        {
            ValidarNome();
            ValidaNomeEmpresa();
            ValidarData();
            ValidarLocal();
            ValidarValor();
            ValidationResult = Validate(this);

            //Validacoes adicionais
            ValidarEndereco();
        }
        private void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome deve ser fornecido")
                .Length(2, 150).WithMessage("O nome do evento tem que estar entre 2 a 150 caracteres");
        }
        private void ValidarValor()
        {
            if (!Gratuito)
                RuleFor(c => c.Valor)
                    .ExclusiveBetween(1, 50000)
                    .WithMessage("O evento deve custar entre 1 a 50000.");

            if (Gratuito)
                RuleFor(c => c.Valor)
                    .ExclusiveBetween(0, 0).When(e => e.Gratuito)
                    .WithMessage("O evento deve custar entre 0.");
        }

        private void ValidarData()
        {
            RuleFor(c => c.DataInicio)
                .GreaterThan(c => c.DataFim)
                .WithMessage("O evento nao pode comecar depois do fim dele.");

            RuleFor(c => c.DataInicio)
                .LessThan(DateTime.Now)
                .WithMessage("O evento nao pode comecar antes da data atual");
        }
        private void ValidarLocal()
        {
            if (Online)
                RuleFor(c => c.Endereco)
                    .Null().When(c => c.Online)
                    .WithMessage("O evento nao deve possuir um endereco se ele eh online");


            if (!Online)
                RuleFor(c => c.Endereco)
                    .NotNull().When(c => c.Online == false)
                    .WithMessage("O evento deve possuir um endereco");
        }
        private void ValidaNomeEmpresa()
        {
            RuleFor(c => c.NomeEmpresa)
                .NotEmpty().WithMessage("O nome do organizador precisa ser fornecido")
                .Length(2, 150).WithMessage("O nome do orgaizador precisaser entre 2 a 150");
        }


        private void ValidarEndereco()
        {
            if (Online) return;
            if (Endereco.EhValido()) return;

            foreach(var error in Endereco.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }
        #endregion

        public static class EventoFactory
        {
            public static Evento NovoEventoCompleto(Guid id,
                string nome,
                string descCurta, 
                string descLonga,
                DateTime dataInicio,
                DateTime dataFim, 
                bool gratuito,
                decimal valor, 
                bool online, 
                string nomeEmpresa, 
                Guid? organizadorId, 
                Endereco endereco, 
                Guid categoriaId)
            {
                var evento = new Evento()
                {
                    Id = id,
                    Nome = nome,
                    DescricaoCurta = descCurta,
                    DescricaoLonga = descLonga,
                    DataInicio = dataInicio,
                    DataFim = dataFim,
                    Gratuito = gratuito,
                    Valor = valor,
                    Online = online,
                    NomeEmpresa = nomeEmpresa,
                    Endereco = endereco,
                    CategoriaId = categoriaId
                };
                if(organizadorId.HasValue )
                {
                    evento.OrganizadorId = organizadorId.Value;

                    if (online)
                        evento.Endereco = null;
                }
                return evento;

            }
        }
    }
}
