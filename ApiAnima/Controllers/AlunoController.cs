using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiAnima.Data;
using ApiAnima.Models;
using System.Net;
using System.Net.Http;

using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiAnima.Controllers
{
    [ApiController]
    [Route("school/aluno")]
    public class AlunoController : ControllerBase
    {

        private WebApiSchoolContext db = new WebApiSchoolContext();

        // GET: api/values
        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return db.Alunos.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //[HttpPost("{ra}")]
        //public Object Post([FromBody]Object value)
        //{

        //    //Usuario usuario = new Usuario();
        //    //usuario.cpf = jsonTratado.cpf;
        //    //usuario.nome = jsonTratado.nome;
        //    //usuario.email = jsonTratado.email;
        //    //usuario.login = jsonTratado.login;
        //    //usuario.senha = jsonTratado.senha;
        //    //db.Usuarios.Add(usuario);

        //    ////Aluno aluno = new Aluno();
        //    ////aluno.Usuario = usuario;
        //    ////aluno.ra = jsonTratado.ra;
        //    ////db.Alunos.Add(aluno);

        //    //db.SaveChanges();

        //    return value;

        //}

        //[HttpPost]
        //public Object Post([FromBody]Usuario aluno)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.myCombinedClasses.Add(mycombinedclass);
        //    db.OrderMenus.AddRange(mycombinedclass.OrderMenu);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = mycombinedclass.Order_ID }, mycombinedclass);
        //}

        [HttpPost]
        public Object Post([FromBody]Usuario usuario)
        {

            db.Usuarios.Add(usuario);

            Aluno aluno = new Aluno();
            aluno.Usuario = usuario;
            //aluno.ra = ra;
            //aluno.usuarioId = usuario.id;
            aluno.ra = aluno.ra;

            db.Alunos.Add(aluno);
            db.SaveChanges();

            //return "{ Usuário do tipo: Aluno, criado com sucesso. }";
            return usuario;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
