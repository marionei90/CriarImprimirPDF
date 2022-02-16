
namespace Imprimir
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.dgMemorandos = new System.Windows.Forms.DataGridView();
            this.MemorandoAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemorandoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemorandoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemorandoSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.rdAbrirPdf = new System.Windows.Forms.RadioButton();
            this.rdSolicitarImpressao = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemorandos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(73, 38);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(200, 20);
            this.txtAssunto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assunto:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(97, 206);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSolicitante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txtAssunto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 254);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Memorando";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(73, 160);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(200, 20);
            this.txtSolicitante.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Solicitante:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(73, 116);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(200, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(73, 76);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(200, 20);
            this.txtData.TabIndex = 1;
            // 
            // dgMemorandos
            // 
            this.dgMemorandos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemorandos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemorandoAssunto,
            this.MemorandoData,
            this.MemorandoNumero,
            this.MemorandoSolicitante});
            this.dgMemorandos.Enabled = false;
            this.dgMemorandos.Location = new System.Drawing.Point(317, 12);
            this.dgMemorandos.Name = "dgMemorandos";
            this.dgMemorandos.Size = new System.Drawing.Size(657, 254);
            this.dgMemorandos.TabIndex = 5;
            // 
            // MemorandoAssunto
            // 
            this.MemorandoAssunto.HeaderText = "Assunto";
            this.MemorandoAssunto.MinimumWidth = 150;
            this.MemorandoAssunto.Name = "MemorandoAssunto";
            this.MemorandoAssunto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MemorandoAssunto.Width = 150;
            // 
            // MemorandoData
            // 
            this.MemorandoData.HeaderText = "Data";
            this.MemorandoData.MinimumWidth = 150;
            this.MemorandoData.Name = "MemorandoData";
            this.MemorandoData.Width = 150;
            // 
            // MemorandoNumero
            // 
            this.MemorandoNumero.HeaderText = "Numero";
            this.MemorandoNumero.MinimumWidth = 150;
            this.MemorandoNumero.Name = "MemorandoNumero";
            this.MemorandoNumero.Width = 150;
            // 
            // MemorandoSolicitante
            // 
            this.MemorandoSolicitante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MemorandoSolicitante.HeaderText = "Solicitante";
            this.MemorandoSolicitante.MinimumWidth = 150;
            this.MemorandoSolicitante.Name = "MemorandoSolicitante";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(92, 13);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(227, 51);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Gerar PDF dos Memorandos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // rdAbrirPdf
            // 
            this.rdAbrirPdf.AutoSize = true;
            this.rdAbrirPdf.Checked = true;
            this.rdAbrirPdf.Location = new System.Drawing.Point(145, 70);
            this.rdAbrirPdf.Name = "rdAbrirPdf";
            this.rdAbrirPdf.Size = new System.Drawing.Size(79, 17);
            this.rdAbrirPdf.TabIndex = 7;
            this.rdAbrirPdf.TabStop = true;
            this.rdAbrirPdf.Text = "Abrir o PDF";
            this.rdAbrirPdf.UseVisualStyleBackColor = true;
            // 
            // rdSolicitarImpressao
            // 
            this.rdSolicitarImpressao.AutoSize = true;
            this.rdSolicitarImpressao.Location = new System.Drawing.Point(267, 70);
            this.rdSolicitarImpressao.Name = "rdSolicitarImpressao";
            this.rdSolicitarImpressao.Size = new System.Drawing.Size(144, 17);
            this.rdSolicitarImpressao.TabIndex = 8;
            this.rdSolicitarImpressao.Text = "Solicitar Impressão Direta";
            this.rdSolicitarImpressao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.rdSolicitarImpressao);
            this.panel1.Controls.Add(this.rdAbrirPdf);
            this.panel1.Location = new System.Drawing.Point(317, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 90);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ao fim da geração do PDF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgMemorandos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar e Imprimir PDF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemorandos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.DataGridView dgMemorandos;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemorandoAssunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemorandoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemorandoNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemorandoSolicitante;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton rdAbrirPdf;
        private System.Windows.Forms.RadioButton rdSolicitarImpressao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

