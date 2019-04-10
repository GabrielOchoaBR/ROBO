using System;
using Microsoft.AspNetCore.Mvc;
using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Util;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ROBO.API.Controllers
{
    [Route("api/Cabeca/Rotacao")]
    public class CabecaRotacaoController : Controller
    {
        private readonly ICabecaRotacaoAppServico _cabecaRotacaoAppServico;

        public CabecaRotacaoController(ICabecaRotacaoAppServico cabecaRotacaoAppServico)
        {
            _cabecaRotacaoAppServico = cabecaRotacaoAppServico;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Json(_cabecaRotacaoAppServico.Objeto()));
        }

        // GET: api/<controller>
        [HttpGet("EstadoAtual")]
        public ActionResult EstadoAtualGet()
        {
            return Ok(Json(_cabecaRotacaoAppServico.EstadoAtual()));
        }

        // POST api/<controller>
        [HttpPost("ProximoEstado")]
        public ActionResult ProximoEstadoPost()
        {
            return Ok(Json(_cabecaRotacaoAppServico.ProximoEstado()));
        }

        // POST api/<controller>
        [HttpPost("AnteriorEstado")]
        public ActionResult AnteriorEstadoPost()
        {
            return Ok(Json(_cabecaRotacaoAppServico.AnteriorEstado()));
        }

        // POST api/<controller>
        [HttpPost("MudarEstado")]
        public ActionResult MudarEstadoPost([FromBody]string estado)
        {
            CabecaRotacaoEnum estadoConvertido = Util.ConversorStringParaEnum<CabecaRotacaoEnum>(estado);

            return Ok(Json(_cabecaRotacaoAppServico.MudarEstado(estadoConvertido)));
        }
    }
}
