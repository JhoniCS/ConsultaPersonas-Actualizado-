using System;

namespace ConsultaPersonas.Domain
{
    public record Persona(int Id, string FirstName, string LastName, string Email, string Gender, string Job, int Age);
}