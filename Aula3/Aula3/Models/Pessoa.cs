using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula3.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = ("*O nome deve ser preenchido"))]
        public string nome { get; set; }

       
        [StringLength(50,MinimumLength =5,ErrorMessage ="A observação deve conter entre 5 a 50 caracteres") ]
        public string observacao { get; set; }
        [Range(18,50,ErrorMessage ="*Idade minima é de 18 anos e idade maxima 50 anos")]
     rte1\Source\Repos
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage ="*Email invalido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage ="*Login deve conter apenas letras, entre 5 e 15 caracteres")]
        [Required(ErrorMessage =("*Campo obrigatorio"))]
        [Remote("LoginUnico", "Pessoa", "Este login já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = ("* Senha deve ser informada"))]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha",ErrorMessage ="*As senhas não conferem")]
        public string ConfimaSenha { get; set; }

    }
    
}