using System;
using Microsoft.AspNetCore.Mvc;
using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Util;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ROBO.API.Controllers
{
    [Route("api/BracoEsquerdo/Cotovelo")]
    public class BracoEsquerdoCotoveloController : Controller
    {
        private readonly ICotoveloEsquerdoAppServico _cotoveloAppServico;

        public BracoEsquerdoCotoveloController(ICotoveloEsquerdoAppServico cotoveloAppServico)
        {
            _cotoveloAppServico = cotoveloAppServico;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Json(_cotoveloAppServico.Objeto()));
        }

        // GET: api/<controller>
        [HttpGet("EstadoAtual")]
        public ActionResult EstadoAtualGet()
        { 
            return Ok(Json(_cotoveloAppServico.EstadoAtual()));
        }

        // POST api/<controller>
        [HttpPost("ProximoEstado")]
        public ActionResult ProximoEstadoPost()
        {
            return Ok(Json(_cotoveloAppServico.ProximoEstado()));
        }

        // POST api/<controller>
        [HttpPost("AnteriorEstado")]
        public ActionResult AnteriorEstadoPost()
        {
            return Ok(Json(_cotoveloAppServico.AnteriorEstado()));
        }

        // POST api/<controller>
        [HttpPost("MudarEstado")]
        public ActionResult MudarEstadoPost([FromBody]string estado)
        {
            CotoveloEstadoEnum estadoConvertido = Util.ConversorStringParaEnum<CotoveloEstadoEnum>(estado);
            
            return Ok(Json(_cotoveloAppServico.MudarEstado(estadoConvertido)));
        }
    }
}
