using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FichaApexEntityFramework.Models
{
    public class Ficha
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Nome { get; set; }
        [StringLength(20)]
        [Required]
        public string Curso { get; set; }
        [StringLength(20)]
        [Required]
        public string Instrutor { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Data { get; set; }
        [DisplayName("Sala/Equipamentos")]
        public Avaliacao SalaEquipamentos { get; set; }

        public Avaliacao Pontualidade { get; set; }
        [DisplayName("Conteúdo Apresentado")]
        public Avaliacao ConteudoApresentado { get; set; }
        [DisplayName("Instrutor")]
        public Avaliacao InstrutorAV { get; set; }

        [StringLength(200)]
        public string Dificuldade { get; set; }
        [StringLength(200)]
        public string Sugestao { get; set; }



    }
}
