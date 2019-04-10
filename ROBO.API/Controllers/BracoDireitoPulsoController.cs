using System;
using Microsoft.AspNetCore.Mvc;
using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Util;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ROBO.API.Controllers
{
    [Route("api/BracoDireito/Pulso")]
    public class BracoDireitoPulsoController : Controller
    {
        private readonly IPulsoDireitoAppServico _pulsoAppServico;

        public BracoDireitoPulsoController(IPulsoDireitoAppServico pulsoAppServico)
        {
            _pulsoAppServico = pulsoAppServico;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Json(_pulsoAppServico.Objeto()));
        }

        // GET: api/<controller>
        [HttpGet("EstadoAtual")]
        public ActionResult EstadoAtualGet()
        { 
            return Ok(Json(_pulsoAppServico.EstadoAtual()));
        }

        // POST api/<controller>
        [HttpPost("ProximoEstado")]
        public ActionResult ProximoEstadoPost()
        {
            return Ok(Json(_pulsoAppServico.ProximoEstado()));
        }

        // POST api/<controller>
        [HttpPost("AnteriorEstado")]
        public ActionResult AnteriorEstadoPost()
        {
            return Ok(Json(_pulsoAppServico.AnteriorEstado()));
        }

        // POST api/<controller>
        [HttpPost("MudarEstado")]
        public ActionResult MudarEstadoPost([FromBody]string estado)
        {
            PulsoEstadoEnum estadoConvertido = Util.ConversorStringParaEnum<PulsoEstadoEnum>(estado);

            return Ok(Json(_pulsoAppServico.MudarEstado(estadoConvertido)));
        }
    }
}
