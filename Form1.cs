using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Extrai os dados do formulário de dados do memorando
            var assunto = txtAssunto.Text;
            var data = txtData.Value;
            var numero = txtNumero.Text;
            var solicitante = txtSolicitante.Text;

            //Cria uma linha nova para a grid e atribui os dados do formulário
            DataGridViewRow row = (DataGridViewRow)dgMemorandos.Rows[0].Clone();
            row.Cells[0].Value = assunto;
            row.Cells[1].Value = data;
            row.Cells[2].Value = numero;
            row.Cells[3].Value = solicitante;

            //Adiciona a linha nova na grid
            dgMemorandos.Rows.Add(row);

            //Habilita o botão de impressão
            btnImprimir.Enabled = true;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //Setando os dados que serão utilizados na geração do PDF
                var listaDeAssuntos = new List<string>();
                var listaDeDatas = new List<DateTime>();
                var listaDeNumeros = new List<string>();
                var listaDeSolicitantes = new List<string>();
                string caminhoDoPdf = string.Empty;
                int quantidadeDeMemorandos = 0;

                ExtrairDadosDosMemorandos(listaDeAssuntos, listaDeDatas, listaDeNumeros, listaDeSolicitantes, ref quantidadeDeMemorandos);

                DefinirCaminhoPdf(ref caminhoDoPdf);

                CriarPDF(listaDeAssuntos, listaDeDatas, listaDeNumeros, listaDeSolicitantes, quantidadeDeMemorandos, caminhoDoPdf);

                //Caso esteja marcado para abrir o PDF
                if (rdAbrirPdf.Checked)
                {
                    AbrirPdf(caminhoDoPdf);
                }
                else //Caso esteja marcado para solicitar impressão
                {
                    SolicitarImpressao(caminhoDoPdf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ex.: {ex.Message}. Stack: {ex.StackTrace}.", "Erro ao imprimir PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirPdf(string caminhoDoPdf)
        {
            Process.Start(caminhoDoPdf);
        }

        private void DefinirCaminhoPdf(ref string caminho)
        {
            //caminho onde sera criado o pdf + nome desejado. OBS: o nome sempre deve ser terminado com .pdf
            //Peguei o diretorio de onde está sendo executada a ferramenta e adicionei um nome aleatorio ao PDF
            caminho = Directory.GetCurrentDirectory() + $"\\Memorandos_{DateTime.Now.Ticks}.pdf";
        }

        private static void SolicitarImpressao(string caminho)
        {
            //Cria o processo de impressão para o Windows
            ProcessStartInfo info = new ProcessStartInfo
            {
                Verb = "print",
                FileName = caminho,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            //Inicia o processo
            Process p = new Process
            {
                StartInfo = info
            };

            p.Start();

            //Aguarda parametros do Acrobat por 3 segundos
            p.WaitForInputIdle();
            Thread.Sleep(3000);

            //Finaliza o Acrobat
            if (!p.CloseMainWindow())
                p.Kill();

            MessageBox.Show("Impressão automatica realizada com sucesso!", "Fim da geração do PDF");
        }

        private static void CriarPDF(List<string> listaDeAssuntos, List<DateTime> listaDeDatas, List<string> listaDeNumeros, List<string> listaDeSolicitantes, int quantidadeDeMemorandos, string caminho)
        {
            //Criando o objeto do PDF e definindo o tamanho da folha usada
            Document documento = new Document(PageSize.A4);

            //Definindo as margens 
            documento.SetMargins(15, 15, 15, 20);

            //Data de criacao
            documento.AddCreationDate();

            //Criando o arquivo PDF em branco
            _ = PdfWriter.GetInstance(documento, new FileStream(caminho, FileMode.Create));

            //Abrindo o PDF criado
            documento.Open();

            //Adiciona um cabeçalho no PDF para melhor visualização
            AdicionarCabecalho(documento);

            //Para cada memorando, repetir o mesmo processo
            for (int i = 0; i < quantidadeDeMemorandos; i++)
            {
                //Criando a variavel para paragrafo e passando a fonte padrão
                Paragraph paragrafo = new Paragraph(string.Empty, new Font());

                //Definindo o alinhamento dos dados (Centralizado)
                paragrafo.Alignment = Element.ALIGN_CENTER;

                //Adicionando o conteudo do memorando no paragrafo
                paragrafo.Add($"{listaDeAssuntos[i]} - {listaDeDatas[i]} - {listaDeNumeros[i]} - {listaDeSolicitantes[i]}");

                //Adicionando paragrafo ao documento
                documento.Add(paragrafo);
            }

            //Salvando as alterações no documento
            documento.Close();
        }

        private static void AdicionarCabecalho(Document documento)
        {
            //Cria uma fonte para o cabeçalho
            var fonteDoCabecalho = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

            //Criando a variavel para paragrafo e passando a fonte customizada
            Paragraph paragrafo = new Paragraph(string.Empty, fonteDoCabecalho);

            //Definindo o alinhamento dos dados (Centralizado)
            paragrafo.Alignment = Element.ALIGN_CENTER;

            //Adicionando as colunas do cabeçalho
            paragrafo.Add($"ASSUNTO | DATA | NUMERO | SOLICITANTE");

            //Adicionando paragrafo ao documento
            documento.Add(paragrafo);
        }

        private int ExtrairDadosDosMemorandos(List<string> listaDeAssuntos, List<DateTime> listaDeDatas, List<string> listaDeNumeros, List<string> listaDeSolicitantes, ref int quantidadeDeMemorandos)
        {
            //Aqui é onde você pega os dados do memorando (Acredito que no seu código são as propriedades do objeto MEMO)
            //Para cada linha do seu banco vai ser um add nessas listas ali
            foreach (DataGridViewRow memorando in dgMemorandos.Rows)
            {
                //Caso a linha da grid esteja nula, ignora
                if (memorando.Cells[0].Value == null)
                    continue;

                //Adiciona os dados de cada memorando nas listas criadas
                //No seu caso, substituir o memorando.Cells[x].Value pelo valor da sua grid/banco
                listaDeAssuntos.Add(Convert.ToString(memorando.Cells[0].Value));
                listaDeDatas.Add(Convert.ToDateTime(memorando.Cells[1].Value));
                listaDeNumeros.Add(Convert.ToString(memorando.Cells[2].Value));
                listaDeSolicitantes.Add(Convert.ToString(memorando.Cells[3].Value));

                quantidadeDeMemorandos++;
            }

            return quantidadeDeMemorandos;
        }
    }
}
