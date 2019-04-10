using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;

namespace ROBO.API.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRobo _robo;

        private readonly ICabecaInclinacaoAppServico _cabecaInclinacaoAppServico;
        private readonly ICabecaRotacaoAppServico _cabecaRotacaoAppServico;
        private readonly IPulsoEsquerdoAppServico _pulsoEsquerdoAppServico;
        private readonly IPulsoDireitoAppServico _pulsoDireitoAppServico;
        private readonly ICotoveloEsquerdoAppServico _cotoveloEsquerdoAppServico;
        private readonly ICotoveloDireitoAppServico _cotoveloDireitoAppServico;

        public IndexModel(IRobo robo,
            ICabecaInclinacaoAppServico cabecaInclinacaoAppServico,
            ICabecaRotacaoAppServico cabecaRotacaoAppServico,
            IPulsoEsquerdoAppServico pulsoEsquerdoAppServico,
            IPulsoDireitoAppServico pulsoDireitoAppServico,
            ICotoveloEsquerdoAppServico cotoveloEsquerdoAppServico,
            ICotoveloDireitoAppServico cotoveloDireitoAppServico)
        {
            _robo = robo;
            _cabecaInclinacaoAppServico = cabecaInclinacaoAppServico;
            _cabecaRotacaoAppServico = cabecaRotacaoAppServico;
            _pulsoEsquerdoAppServico = pulsoEsquerdoAppServico;
            _pulsoDireitoAppServico = pulsoDireitoAppServico;
            _cotoveloEsquerdoAppServico = cotoveloEsquerdoAppServico;
            _cotoveloDireitoAppServico = cotoveloDireitoAppServico;
        }
        public string CabecaRotacaoEstado { get; private set; }
        public string CabecaInclinacaoEstado { get; private set; }
        public string PulsoEsquerdoEstado { get; private set; }
        public string PulsoDireitoEstado { get; private set; }
        public string CotoveloEsquerdoEstado { get; private set; }
        public string CotoveloDireitoEstado { get; private set; }

        public string ClasseRobo { get; private set; }

        public void OnGet(string AcaoQueryString)
        {
            if (!string.IsNullOrEmpty(AcaoQueryString))
                ExecutarAcao(AcaoQueryString);

            AtualizaInterface();

        }

        private void ExecutarAcao(string acaoQueryString)
        {
            string[] Acao = acaoQueryString.Split("-");

            if (Acao.Length != 2)
                return;

            switch (Acao[0])
            {
                case "CabecaRotacao":
                    if (Acao[1] == "Proximo") _cabecaRotacaoAppServico.ProximoEstado();
                    else _cabecaRotacaoAppServico.AnteriorEstado();
                    break;

                case "CabecaInclinacao":
                    if (Acao[1] == "Proximo") _cabecaInclinacaoAppServico.ProximoEstado();
                    else _cabecaInclinacaoAppServico.AnteriorEstado();
                    break;

                case "PulsoEsquerdo":
                    if (Acao[1] == "Proximo") _pulsoEsquerdoAppServico.ProximoEstado();
                    else _pulsoEsquerdoAppServico.AnteriorEstado();
                    break;

                case "PulsoDireito":
                    if (Acao[1] == "Proximo") _pulsoDireitoAppServico.ProximoEstado();
                    else _pulsoDireitoAppServico.AnteriorEstado();
                    break;

                case "CotoveloEsquerdo":
                    if (Acao[1] == "Proximo") _cotoveloEsquerdoAppServico.ProximoEstado();
                    else _cotoveloEsquerdoAppServico.AnteriorEstado();
                    break;

                case "CotoveloDireito":
                    if (Acao[1] == "Proximo") _cotoveloDireitoAppServico.ProximoEstado();
                    else _cotoveloDireitoAppServico.AnteriorEstado();
                    break;

            }
        }

        private void AtualizaInterface()
        {
            CabecaRotacaoEstado = _cabecaRotacaoAppServico.EstadoAtual().ToString();
            CabecaInclinacaoEstado = _cabecaInclinacaoAppServico.EstadoAtual().ToString();
            PulsoEsquerdoEstado = _pulsoEsquerdoAppServico.EstadoAtual().ToString();
            PulsoDireitoEstado = _pulsoDireitoAppServico.EstadoAtual().ToString();
            CotoveloEsquerdoEstado = _cotoveloEsquerdoAppServico.EstadoAtual().ToString();
            CotoveloDireitoEstado = _cotoveloDireitoAppServico.EstadoAtual().ToString();

            ClasseRobo = JsonConvert.SerializeObject(_robo, Formatting.Indented);
        }
    }
}