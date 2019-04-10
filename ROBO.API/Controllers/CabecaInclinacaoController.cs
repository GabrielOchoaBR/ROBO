using System;
using Microsoft.AspNetCore.Mvc;
using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Util;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ROBO.API.Controllers
{
    [Route("api/Cabeca/Inclinacao")]
    public class CabecaInclinacaoController : Controller
    {
        private readonly ICabecaInclinacaoAppServico _cabecaInclinacaoAppServico;

        public CabecaInclinacaoController(ICabecaInclinacaoAppServico cabecaInclinacaoAppServico)
        {
            _cabecaInclinacaoAppServico = cabecaInclinacaoAppServico;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Json(_cabecaInclinacaoAppServico.Objeto()));
        }

        // GET: api/<controller>
        [HttpGet("EstadoAtual")]
        public ActionResult EstadoAtualGet()
        {
            return Ok(Json(_cabecaInclinacaoAppServico.EstadoAtual()));
        }

        // POST api/<controller>
        [HttpPost("ProximoEstado")]
        public ActionResult ProximoEstadoPost()
        {
            return Ok(Json(_cabecaInclinacaoAppServico.ProximoEstado()));
        }

        // POST api/<controller>
        [HttpPost("AnteriorEstado")]
        public ActionResult AnteriorEstadoPost()
        {
            return Ok(Json(_cabecaInclinacaoAppServico.AnteriorEstado()));
        }

        // POST api/<controller>
        [HttpPost("MudarEstado")]
        public ActionResult MudarEstadoPost([FromBody]string estado)
        {
            CabecaInclinacaoEnum estadoConvertido = Util.ConversorStringParaEnum<CabecaInclinacaoEnum>(estado);

            return Ok(Json(_cabecaInclinacaoAppServico.MudarEstado(estadoConvertido)));
        }
    }
}
