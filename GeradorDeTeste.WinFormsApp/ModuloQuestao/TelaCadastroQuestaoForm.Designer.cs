namespace GeradorDeTeste.WinFormsApp.ModuloQuestao
{
    partial class TelaCadastroQuestaoForm
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
            this.comboBoxMaterias = new System.Windows.Forms.ComboBox();
            this.comboBoxBimestres = new System.Windows.Forms.ComboBox();
            this.textBoxQuestao = new System.Windows.Forms.TextBox();
            this.textBoxAlternativas = new System.Windows.Forms.TextBox();
            this.AlternativascheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnAlternativa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDisciplinas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxMaterias
            // 
            this.comboBoxMaterias.FormattingEnabled = true;
            this.comboBoxMaterias.Location = new System.Drawing.Point(110, 77);
            this.comboBoxMaterias.Name = "comboBoxMaterias";
            this.comboBoxMaterias.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMaterias.TabIndex = 0;
            // 
            // comboBoxBimestres
            // 
            this.comboBoxBimestres.FormattingEnabled = true;
            this.comboBoxBimestres.Location = new System.Drawing.Point(110, 106);
            this.comboBoxBimestres.Name = "comboBoxBimestres";
            this.comboBoxBimestres.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBimestres.TabIndex = 1;
            // 
            // textBoxQuestao
            // 
            this.textBoxQuestao.Location = new System.Drawing.Point(110, 22);
            this.textBoxQuestao.Name = "textBoxQuestao";
            this.textBoxQuestao.Size = new System.Drawing.Size(219, 23);
            this.textBoxQuestao.TabIndex = 2;
            // 
            // textBoxAlternativas
            // 
            this.textBoxAlternativas.Location = new System.Drawing.Point(110, 135);
            this.textBoxAlternativas.Name = "textBoxAlternativas";
            this.textBoxAlternativas.Size = new System.Drawing.Size(121, 23);
            this.textBoxAlternativas.TabIndex = 3;
            // 
            // AlternativascheckedListBox
            // 
            this.AlternativascheckedListBox.FormattingEnabled = true;
            this.AlternativascheckedListBox.Location = new System.Drawing.Point(110, 164);
            this.AlternativascheckedListBox.Name = "AlternativascheckedListBox";
            this.AlternativascheckedListBox.Size = new System.Drawing.Size(121, 94);
            this.AlternativascheckedListBox.TabIndex = 4;
            // 
            // btnAlternativa
            // 
            this.btnAlternativa.Location = new System.Drawing.Point(237, 135);
            this.btnAlternativa.Name = "btnAlternativa";
            this.btnAlternativa.Size = new System.Drawing.Size(75, 23);
            this.btnAlternativa.TabIndex = 5;
            this.btnAlternativa.Text = "Adicionar";
            this.btnAlternativa.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(110, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInserir.Location = new System.Drawing.Point(226, 269);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(103, 39);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Questão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bimestre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alternativas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Disciplinas: ";
            // 
            // comboBoxDisciplinas
            // 
            this.comboBoxDisciplinas.FormattingEnabled = true;
            this.comboBoxDisciplinas.Location = new System.Drawing.Point(110, 51);
            this.comboBoxDisciplinas.Name = "comboBoxDisciplinas";
            this.comboBoxDisciplinas.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDisciplinas.TabIndex = 12;
            // 
            // TelaCadastroQuestaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDisciplinas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAlternativa);
            this.Controls.Add(this.AlternativascheckedListBox);
            this.Controls.Add(this.textBoxAlternativas);
            this.Controls.Add(this.textBoxQuestao);
            this.Controls.Add(this.comboBoxBimestres);
            this.Controls.Add(this.comboBoxMaterias);
            this.Name = "TelaCadastroQuestaoForm";
            this.Text = "TelaCadastroQuestaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMaterias;
        private System.Windows.Forms.ComboBox comboBoxBimestres;
        private System.Windows.Forms.TextBox textBoxQuestao;
        private System.Windows.Forms.TextBox textBoxAlternativas;
        private System.Windows.Forms.CheckedListBox AlternativascheckedListBox;
        private System.Windows.Forms.Button btnAlternativa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDisciplinas;
    }
}