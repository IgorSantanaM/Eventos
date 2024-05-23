using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.IO.Application.ViewModels
{
    public class StateViewModel
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public static List<StateViewModel> ListStates()
        {
            return new List<StateViewModel>()
            {
                new StateViewModel() {Abbreviation ="AC", Name="Acre" },
                new StateViewModel() {Abbreviation ="AL", Name="Alagoas" },
                new StateViewModel() {Abbreviation ="AP", Name="Amapa" },
                new StateViewModel() {Abbreviation ="AM", Name="Amazonas" },
                new StateViewModel() {Abbreviation ="BA", Name="Bahia" },
                new StateViewModel() {Abbreviation ="CE", Name="Ceara" },
                new StateViewModel() {Abbreviation ="DF", Name="Distrito Federal" },
                new StateViewModel() {Abbreviation ="ES", Name="Espirito Santo" },
                new StateViewModel() {Abbreviation ="GO", Name="Goias" },
                new StateViewModel() {Abbreviation ="MA", Name="Maranhao" },
                new StateViewModel() {Abbreviation ="MT", Name="Mato Grosso" },
                new StateViewModel() {Abbreviation ="MS", Name="Mato Grosso do Sul" },
                new StateViewModel() {Abbreviation ="MG", Name="Minas Gerais" },
                new StateViewModel() {Abbreviation ="PA", Name="Para" },
                new StateViewModel() {Abbreviation ="PB", Name="Paraiba" },
                new StateViewModel() {Abbreviation ="PR", Name="Parana" },
                new StateViewModel() {Abbreviation ="PE", Name="Pernambuco" },
                new StateViewModel() {Abbreviation ="PI", Name="Piaui" },
                new StateViewModel() {Abbreviation ="RJ", Name="Rio de Janeiro" },
                new StateViewModel() {Abbreviation ="RN", Name="Rio Grande do Norte" },
                new StateViewModel() {Abbreviation ="RS", Name="Rio Grande do Sul" },
                new StateViewModel() {Abbreviation ="RO", Name="Rondonia" },
                new StateViewModel() {Abbreviation ="RR", Name="Roraima" },
                new StateViewModel() {Abbreviation ="SC", Name="Santa Catarina" },
                new StateViewModel() {Abbreviation ="SP", Name="Sao Paulo" },
                new StateViewModel() {Abbreviation ="SE", Name="Seripe" },
                new StateViewModel() {Abbreviation ="TO", Name="Tocantins" }
            };
        }

    }
}
