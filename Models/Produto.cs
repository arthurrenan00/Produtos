using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Produtos.Models
{
    public class Produto
    {
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        [StringLength(10, MinimumLength =10, ErrorMessage ="O código deve possuir 10 caracteres!")]
        public string Codigo { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength =10, ErrorMessage ="Este campo necessita de 5 a 50 caracteres!" )]
        public string Descricao { get; set;}

        [Required(ErrorMessage ="Peso obrigatório")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Valor unitário obrigatório")]
        public decimal ValorUnit { get; set; }

    }
}