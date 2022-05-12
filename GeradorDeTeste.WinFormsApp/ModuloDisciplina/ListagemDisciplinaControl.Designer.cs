namespace GeradorDeTeste.WinFormsApp.ModuloDisciplina
{
    partial class ListagemDisciplinaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridDisciplina = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDisciplina
            // 
            this.GridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDisciplina.Location = new System.Drawing.Point(0, 0);
            this.GridDisciplina.Name = "GridDisciplina";
            this.GridDisciplina.RowTemplate.Height = 25;
            this.GridDisciplina.Size = new System.Drawing.Size(658, 398);
            this.GridDisciplina.TabIndex = 5;
            // 
            // ListagemDisciplinaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridDisciplina);
            this.Name = "ListagemDisciplinaControl";
            this.Size = new System.Drawing.Size(659, 397);
            ((System.ComponentModel.ISupportInitialize)(this.GridDisciplina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDisciplina;
    }
}
