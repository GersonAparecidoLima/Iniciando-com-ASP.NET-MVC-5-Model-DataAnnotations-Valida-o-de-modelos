using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Paramentro.Models;

namespace Paramentro.Controllers
{
    public class AlunoController : Controller
    {
        //Criando uma Rota especifica
        // https:/ /localhost:44369/novo-aluno
        [Route(template:"novo-aluno")]
        // GET: Aluno
        //Neste momento o papel da Action
        //Aqui temos uma tranforamção um modo byde 'Aluno aluno' 
        //e como se fosse o dado do formulario, que vai sendo passado por paramentro

        // A model e validada na hora que e passada no paramentro
        // public ActionResult Novo(Aluno aluno)
        //Aluno aluno => modo byde
        public ActionResult Novo(Aluno aluno)
        {
            // Para simular vamos criar uma stancia de aluno
            aluno = new Aluno
            {
                Id = 1,
                Nome = "Gerson",
                Cpf = "123456789",
                DataMatricula = DateTime.Now,
                Email = "gerson@gerson.com",
                Ativo = true
            };
            // simular uma entrada de dados
            // pasando um dado como parametro
            // para ActionResult Index
            // 1 passamos o none da ActionResult
            // 2 passamos a model como parametro

            return RedirectToAction("Index",aluno);
            //return View();
        }

        // Model Aluno aluno chega 
        // Aqui a model e utilizdo como dado
        //model Aluno aluno
        public ActionResult Index(Aluno aluno){
            // Se a moden stati não estiver valido
            // ele vai devolver dizendo o que esta erra
            // caso esteja correto retorna a View(aluno)
            if (!ModelState.IsValid)
            // ModelState e o estado da Model, se ela esta valida
            // caso o mode estiver validado em ok
            // retorno TRUE
            {
                // nsete momento nos não vamos implementar a View ainda
                // mas vamos simular um senario real
                return View(aluno);
            }

            return View();
        }

    }
}