namespace kanji_learner
{
    partial class Resultado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.clnSymbal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnConfirmcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCertos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSymbal,
            this.clnConfirmcao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados.Location = new System.Drawing.Point(0, 116);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowTemplate.Height = 40;
            this.dgvResultados.Size = new System.Drawing.Size(245, 334);
            this.dgvResultados.TabIndex = 0;
            // 
            // clnSymbal
            // 
            this.clnSymbal.HeaderText = "Symbol";
            this.clnSymbal.Name = "clnSymbal";
            this.clnSymbal.ReadOnly = true;
            // 
            // clnConfirmcao
            // 
            this.clnConfirmcao.HeaderText = "Confirmação";
            this.clnConfirmcao.Name = "clnConfirmcao";
            this.clnConfirmcao.ReadOnly = true;
            // 
            // lblCertos
            // 
            this.lblCertos.AutoSize = true;
            this.lblCertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.lblCertos.Location = new System.Drawing.Point(12, 50);
            this.lblCertos.Name = "lblCertos";
            this.lblCertos.Size = new System.Drawing.Size(222, 63);
            this.lblCertos.TabIndex = 1;
            this.lblCertos.Text = "999/999";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Concluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCertos);
            this.Controls.Add(this.dgvResultados);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resultado_FormClosed);
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSymbal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnConfirmcao;
        private System.Windows.Forms.Label lblCertos;
        private System.Windows.Forms.Button button1;
    }
}