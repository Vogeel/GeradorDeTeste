namespace GeradorDeTeste.WinFormsApp.ModuloQuestao
{
    partial class ListagemQuestaoControl
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
            this.gridQuestao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestao)).BeginInit();
            this.SuspendLayout();
            // 
            // gridQuestao
            // 
            this.gridQuestao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuestao.Location = new System.Drawing.Point(0, 0);
            this.gridQuestao.Name = "gridQuestao";
            this.gridQuestao.RowTemplate.Height = 25;
            this.gridQuestao.Size = new System.Drawing.Size(658, 398);
            this.gridQuestao.TabIndex = 4;
            // 
            // ListagemQuestaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridQuestao);
            this.Name = "ListagemQuestaoControl";
            this.Size = new System.Drawing.Size(664, 404);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridQuestao;
    }
}
