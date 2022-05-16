namespace GeradorDeTeste.WinFormsApp.ModuloMateria
{
    partial class ListagemMateriaControl
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
            this.GridMateria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMateria
            // 
            this.GridMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMateria.Location = new System.Drawing.Point(0, 0);
            this.GridMateria.Name = "GridMateria";
            this.GridMateria.RowTemplate.Height = 25;
            this.GridMateria.Size = new System.Drawing.Size(658, 398);
            this.GridMateria.TabIndex = 5;
            // 
            // ListagemMateriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridMateria);
            this.Name = "ListagemMateriaControl";
            this.Size = new System.Drawing.Size(662, 403);
            ((System.ComponentModel.ISupportInitialize)(this.GridMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMateria;
    }
}
