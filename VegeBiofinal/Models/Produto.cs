using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VegeBiofinal.Models
{
    public class Produto
    {
        public int id;

        [Display(Name = "Nome")]
        public string nome;

        [Display(Name = "Estação")]
        public string epoca;

        [Display(Name = "Preço")]
        public float preco;

        [Display(Name = "Descrição")]
        public string descricao;

        public string tipo;

        public string imageurl;

    
}
}
