using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Paramentro.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        //obrigatoridade do preenchimento do campo
        //Mensagem personaliza ErrorMessage =""
        // e preciso using System.ComponentModel.DataAnnotations;
        // quando o nome não for preenchido devolver a msg

        [Required(ErrorMessage =" O nome e de preenchimento obrigatorio!")]        
        public string Nome{ get; set; }

        // utilizando a msg de forma generia
        //{0} e o indice e faz o DataAnnotations entenda que e o nome da propriedade que no caso e Email
        [Required(ErrorMessage = " O campo {0} e  requerido!")]        
        
        //a msg que vai aparecer na View
        [DisplayName("O campo Email deve ser preenchido completo com @ e ponto")]
        public string Email { get; set; }
        [EmailAddress(ErrorMessage ="E-mail no formato invalido")]
        // Esta DataAnnotations EmailAddress  e para o tipo e-amil então ele vai segui a estrutura de @ e (.)
        public string Cpf { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }

        [Required(ErrorMessage = " O campo {0} e  requerido!")]
        public string senha { get; set; }

        // recurso de compara a senha
        [Compare(otherProperty:"Senha", ErrorMessage ="A senha informada não confere")]
        [Required(ErrorMessage = " O campo {0} e  requerido!")]
        public string senhaConfirmacao { get; set; }
    }
}