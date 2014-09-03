﻿using UPC.CruzDelSur.Negocio.Modelo.Personal;

namespace UPC.CruzDelSur.Datos.Contratos
{
    public interface IPersonasRepositorio : IRepositorio<Persona>
    {
        Persona ObtenerPorDNI(string dni);
    }

    public interface IEducacionesRepositorio : IRepositorio<Educacion>
    {
         
    }

    public interface IExperienciasLaboralesRepositorio : IRepositorio<ExperienciaLaboral>
    {
         
    }
}