namespace GeradorDeTeste.WinFormsApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadsatrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestaoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executarTesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerOTesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadsatrosToolStripMenuItem,
            this.executarTesteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadsatrosToolStripMenuItem
            // 
            this.cadsatrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinaMenuItem,
            this.materiaMenuItem,
            this.QuestaoMenuItem});
            this.cadsatrosToolStripMenuItem.Name = "cadsatrosToolStripMenuItem";
            this.cadsatrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadsatrosToolStripMenuItem.Text = "Cadastros";
            // 
            // disciplinaMenuItem
            // 
            this.disciplinaMenuItem.Name = "disciplinaMenuItem";
            this.disciplinaMenuItem.Size = new System.Drawing.Size(125, 22);
            this.disciplinaMenuItem.Text = "Disciplina";
            this.disciplinaMenuItem.Click += new System.EventHandler(this.disciplinaMenuItem_Click);
            // 
            // materiaMenuItem
            // 
            this.materiaMenuItem.Name = "materiaMenuItem";
            this.materiaMenuItem.Size = new System.Drawing.Size(125, 22);
            this.materiaMenuItem.Text = "Materia";
            this.materiaMenuItem.Click += new System.EventHandler(this.materiaMenuItem_Click);
            // 
            // QuestaoMenuItem
            // 
            this.QuestaoMenuItem.Name = "QuestaoMenuItem";
            this.QuestaoMenuItem.Size = new System.Drawing.Size(125, 22);
            this.QuestaoMenuItem.Text = "Questão";
            this.QuestaoMenuItem.Click += new System.EventHandler(this.QuestaoMenuItem_Click);
            // 
            // executarTesteToolStripMenuItem
            // 
            this.executarTesteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerOTesteToolStripMenuItem});
            this.executarTesteToolStripMenuItem.Name = "executarTesteToolStripMenuItem";
            this.executarTesteToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.executarTesteToolStripMenuItem.Text = "Executar Teste";
            // 
            // fazerOTesteToolStripMenuItem
            // 
            this.fazerOTesteToolStripMenuItem.Name = "fazerOTesteToolStripMenuItem";
            this.fazerOTesteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fazerOTesteToolStripMenuItem.Text = "Fazer o teste";
            this.fazerOTesteToolStripMenuItem.Click += new System.EventHandler(this.fazerOTesteToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodape});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.Enabled = false;
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(668, 33);
            this.toolStripPrincipal.TabIndex = 5;
            this.toolStripPrincipal.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::GeradorDeTeste.WinFormsApp.Properties.Resources.add_FILL0_wght400_GRAD0_opsz48;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Margin = new System.Windows.Forms.Padding(0);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(69, 33);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::GeradorDeTeste.WinFormsApp.Properties.Resources.edit_note_FILL0_wght400_GRAD0_opsz48;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(67, 30);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::GeradorDeTeste.WinFormsApp.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(72, 30);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panelRegistros
            // 
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 57);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(668, 273);
            this.panelRegistros.TabIndex = 6;
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 352);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipalForm";
            this.Text = "TelaPrincipalForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadsatrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuestaoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executarTesteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerOTesteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.ToolStripStatusLabel labelRodape;
    }
}
