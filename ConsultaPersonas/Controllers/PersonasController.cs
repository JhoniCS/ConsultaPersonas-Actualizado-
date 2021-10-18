/*
Universidad Tecnologica Metropolitana
APLICACIONES WEB ORIENTADAS A SERVICIOS
Mtro. Joel Ivan Chuc Uc
"Crear una aplicación web api que permita consultar la información "
Alumno: Jhonatan Izael Canche Sulu
Cuatrimestre Septiembre-Diciembre
4°A
Parcial 2 */
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ConsultaPersonas.Repositorio;
using ConsultaPersonas.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetAll();
            return Ok(persons);
        }
        
        [HttpGet]
        [Route("GetFields")]
        public IActionResult GetFields()
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetFields();
            return Ok(persons);
        }
        //
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetById(id);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetByGender/{gender}")]
        public IActionResult GetByGender(string gender)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetByGender(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetByGenderAndAge/{gender}/{age}")]
        public IActionResult GetByGenderAndAge(string gender, int age)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetByGenderAndAge(gender, age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetDiferences/{job}")]
        public IActionResult GetDiferences(string job)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetDiferences(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetDistinct")]
        public IActionResult GetDistinct()
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetDistinct();
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetContains/{contains}")]
        public IActionResult GetContains(string contains)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetContains(contains);
            return Ok(persons);
        }
        //
        [HttpGet]
        [Route("GetByAges/{agesString}")]
        public IActionResult GetByAges(string agesString)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetByAges(agesString);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetByRangeAge/{minAge}/{maxAge}")]
        public IActionResult GetByRangeAge(int minAge, int maxAge)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetByRangeAge(minAge, maxAge);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetPersonsOrdered/{job}")]
        public IActionResult GetPersonsOrdered(string job)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetPersonsOrdered(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("GetPersonsOrderedDescending/{job}")]
        public IActionResult GetPersonsOrderedDescending(string job)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.GetPersonsOrderedDescending(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("CountPerson/{gender}")]
        public IActionResult CountPerson(string gender)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.CountPerson(gender);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ExistPerson/{lastName}")]
        public IActionResult ExistPerson(string lastName)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.ExistPerson(lastName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("TakePerson/{job}/{take}")]
        public IActionResult TakePerson(int take, string job)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.TakePerson(take, job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("TakeLastPerson/{job}/{take}")]
        public IActionResult TakeLastPerson(int take, string job)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.TakeLastPerson(take, job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("SkipPerson/{job}/{skip}")]
        public IActionResult SkipPerson(int skip, string job)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.SkipPerson(skip, job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("SkipTakePerson/{job}/{skip}/{take}")]
        public IActionResult SkipTakePerson(int skip, int take, string job)
        {
            var repository = new PersonaRepositorio();
            var persons = repository.SkipTakePerson(skip, take, job);
            return Ok(persons);
        }
    }
}