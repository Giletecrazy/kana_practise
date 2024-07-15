
namespace kanji_learner
{
    partial class romanji_test
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
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnUkeyboard = new System.Windows.Forms.Button();
            this.btnOkeyboard = new System.Windows.Forms.Button();
            this.btnIkeyboard = new System.Windows.Forms.Button();
            this.btnEkeyboard = new System.Windows.Forms.Button();
            this.btnAkeyboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.lblSymbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSymbol.Location = new System.Drawing.Point(12, 9);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(208, 76);
            this.lblSymbol.TabIndex = 0;
            this.lblSymbol.Text = "label1";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.txtResposta.Location = new System.Drawing.Point(12, 88);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(392, 44);
            this.txtResposta.TabIndex = 1;
            this.txtResposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResposta_KeyDown);
            // 
            // btnShift
            // 
            this.btnShift.BackColor = System.Drawing.Color.Thistle;
            this.btnShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnShift.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShift.Location = new System.Drawing.Point(328, 18);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(58, 56);
            this.btnShift.TabIndex = 5;
            this.btnShift.Text = "⇪";
            this.btnShift.UseVisualStyleBackColor = false;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnUkeyboard
            // 
            this.btnUkeyboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUkeyboard.Location = new System.Drawing.Point(263, 31);
            this.btnUkeyboard.Name = "btnUkeyboard";
            this.btnUkeyboard.Size = new System.Drawing.Size(58, 43);
            this.btnUkeyboard.TabIndex = 4;
            this.btnUkeyboard.Text = "ū";
            this.btnUkeyboard.UseVisualStyleBackColor = true;
            this.btnUkeyboard.Click += new System.EventHandler(this.btnUkeyboard_Click);
            // 
            // btnOkeyboard
            // 
            this.btnOkeyboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOkeyboard.Location = new System.Drawing.Point(201, 31);
            this.btnOkeyboard.Name = "btnOkeyboard";
            this.btnOkeyboard.Size = new System.Drawing.Size(56, 43);
            this.btnOkeyboard.TabIndex = 3;
            this.btnOkeyboard.Text = "ō";
            this.btnOkeyboard.UseVisualStyleBackColor = true;
            this.btnOkeyboard.Click += new System.EventHandler(this.btnOkeyboard_Click);
            // 
            // btnIkeyboard
            // 
            this.btnIkeyboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIkeyboard.Location = new System.Drawing.Point(139, 31);
            this.btnIkeyboard.Name = "btnIkeyboard";
            this.btnIkeyboard.Size = new System.Drawing.Size(56, 43);
            this.btnIkeyboard.TabIndex = 2;
            this.btnIkeyboard.Text = "ī";
            this.btnIkeyboard.UseVisualStyleBackColor = true;
            this.btnIkeyboard.Click += new System.EventHandler(this.btnIkeyboard_Click);
            // 
            // btnEkeyboard
            // 
            this.btnEkeyboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkeyboard.Location = new System.Drawing.Point(74, 31);
            this.btnEkeyboard.Name = "btnEkeyboard";
            this.btnEkeyboard.Size = new System.Drawing.Size(59, 43);
            this.btnEkeyboard.TabIndex = 1;
            this.btnEkeyboard.Text = "ē";
            this.btnEkeyboard.UseVisualStyleBackColor = true;
            this.btnEkeyboard.Click += new System.EventHandler(this.btnEkeyboard_Click);
            // 
            // btnAkeyboard
            // 
            this.btnAkeyboard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAkeyboard.Location = new System.Drawing.Point(6, 31);
            this.btnAkeyboard.Name = "btnAkeyboard";
            this.btnAkeyboard.Size = new System.Drawing.Size(62, 43);
            this.btnAkeyboard.TabIndex = 0;
            this.btnAkeyboard.Text = "ā";
            this.btnAkeyboard.UseVisualStyleBackColor = true;
            this.btnAkeyboard.Click += new System.EventHandler(this.btnAkeyboard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShift);
            this.groupBox1.Controls.Add(this.btnUkeyboard);
            this.groupBox1.Controls.Add(this.btnOkeyboard);
            this.groupBox1.Controls.Add(this.btnIkeyboard);
            this.groupBox1.Controls.Add(this.btnEkeyboard);
            this.groupBox1.Controls.Add(this.btnAkeyboard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyboard";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.btnCancelar.Location = new System.Drawing.Point(12, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.btnNext.Location = new System.Drawing.Point(286, 224);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 33);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // romanji_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(413, 269);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblSymbol);
            this.Name = "romanji_test";
            this.Text = "Romanjib Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.romanji_test_FormClosed);
            this.Load += new System.EventHandler(this.romanji_test_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnUkeyboard;
        private System.Windows.Forms.Button btnOkeyboard;
        private System.Windows.Forms.Button btnIkeyboard;
        private System.Windows.Forms.Button btnEkeyboard;
        private System.Windows.Forms.Button btnAkeyboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNext;
    }
}