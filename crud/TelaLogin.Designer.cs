
namespace crud
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.txtbIdade = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlEditar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.pnlEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAluno.Location = new System.Drawing.Point(107, 12);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(569, 194);
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAluno_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(63, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelId.Location = new System.Drawing.Point(63, 94);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            // 
            // txtbNome
            // 
            this.txtbNome.Enabled = false;
            this.txtbNome.Location = new System.Drawing.Point(123, 18);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(100, 20);
            this.txtbNome.TabIndex = 4;
            // 
            // txtbId
            // 
            this.txtbId.Enabled = false;
            this.txtbId.Location = new System.Drawing.Point(123, 91);
            this.txtbId.Name = "txtbId";
            this.txtbId.Size = new System.Drawing.Size(100, 20);
            this.txtbId.TabIndex = 5;
            // 
            // txtbIdade
            // 
            this.txtbIdade.Enabled = false;
            this.txtbIdade.Location = new System.Drawing.Point(123, 52);
            this.txtbIdade.Name = "txtbIdade";
            this.txtbIdade.Size = new System.Drawing.Size(100, 20);
            this.txtbIdade.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(96, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 50);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlEditar
            // 
            this.pnlEditar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlEditar.Controls.Add(this.label2);
            this.pnlEditar.Controls.Add(this.btnEditar);
            this.pnlEditar.Controls.Add(this.label1);
            this.pnlEditar.Controls.Add(this.txtbIdade);
            this.pnlEditar.Controls.Add(this.labelId);
            this.pnlEditar.Controls.Add(this.txtbId);
            this.pnlEditar.Controls.Add(this.txtbNome);
            this.pnlEditar.Location = new System.Drawing.Point(274, 222);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(272, 216);
            this.pnlEditar.TabIndex = 8;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEditar);
            this.Controls.Add(this.dgvAluno);
            this.Name = "TelaLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.TextBox txtbIdade;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlEditar;
    }
}

