
namespace kanji_learner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bdJPWRITINGSYSTEMDataSet = new kanji_learner.bdJPWRITINGSYSTEMDataSet();
            this.hiraganaMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hiraganaMainTableAdapter = new kanji_learner.bdJPWRITINGSYSTEMDataSetTableAdapters.HiraganaMainTableAdapter();
            this.gpbHiraganaGroup = new System.Windows.Forms.GroupBox();
            this.ckbHCOMBINATION = new System.Windows.Forms.CheckBox();
            this.ckbHDAKUTEN = new System.Windows.Forms.CheckBox();
            this.ckbHMAIN = new System.Windows.Forms.CheckBox();
            this.gpbKatakanaGroup = new System.Windows.Forms.GroupBox();
            this.ckbKCOMBINATION = new System.Windows.Forms.CheckBox();
            this.ckbKDAKUTEN = new System.Windows.Forms.CheckBox();
            this.ckbKMAIN = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEditar_BD = new System.Windows.Forms.Button();
            this.btnMselction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbConfirmar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdJPWRITINGSYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaMainBindingSource)).BeginInit();
            this.gpbHiraganaGroup.SuspendLayout();
            this.gpbKatakanaGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdJPWRITINGSYSTEMDataSet
            // 
            this.bdJPWRITINGSYSTEMDataSet.DataSetName = "bdJPWRITINGSYSTEMDataSet";
            this.bdJPWRITINGSYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hiraganaMainBindingSource
            // 
            this.hiraganaMainBindingSource.DataMember = "HiraganaMain";
            this.hiraganaMainBindingSource.DataSource = this.bdJPWRITINGSYSTEMDataSet;
            // 
            // hiraganaMainTableAdapter
            // 
            this.hiraganaMainTableAdapter.ClearBeforeFill = true;
            // 
            // gpbHiraganaGroup
            // 
            this.gpbHiraganaGroup.BackColor = System.Drawing.SystemColors.Window;
            this.gpbHiraganaGroup.Controls.Add(this.ckbHCOMBINATION);
            this.gpbHiraganaGroup.Controls.Add(this.ckbHDAKUTEN);
            this.gpbHiraganaGroup.Controls.Add(this.ckbHMAIN);
            this.gpbHiraganaGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.gpbHiraganaGroup.Location = new System.Drawing.Point(12, 12);
            this.gpbHiraganaGroup.Name = "gpbHiraganaGroup";
            this.gpbHiraganaGroup.Size = new System.Drawing.Size(185, 155);
            this.gpbHiraganaGroup.TabIndex = 0;
            this.gpbHiraganaGroup.TabStop = false;
            this.gpbHiraganaGroup.Text = "Hiuragana";
            // 
            // ckbHCOMBINATION
            // 
            this.ckbHCOMBINATION.AutoSize = true;
            this.ckbHCOMBINATION.Location = new System.Drawing.Point(20, 103);
            this.ckbHCOMBINATION.Name = "ckbHCOMBINATION";
            this.ckbHCOMBINATION.Size = new System.Drawing.Size(154, 30);
            this.ckbHCOMBINATION.TabIndex = 2;
            this.ckbHCOMBINATION.Text = "Combination";
            this.ckbHCOMBINATION.UseVisualStyleBackColor = true;
            this.ckbHCOMBINATION.CheckedChanged += new System.EventHandler(this.ckbHCOMBINATION_CheckedChanged);
            // 
            // ckbHDAKUTEN
            // 
            this.ckbHDAKUTEN.AutoSize = true;
            this.ckbHDAKUTEN.Location = new System.Drawing.Point(20, 67);
            this.ckbHDAKUTEN.Name = "ckbHDAKUTEN";
            this.ckbHDAKUTEN.Size = new System.Drawing.Size(112, 30);
            this.ckbHDAKUTEN.TabIndex = 1;
            this.ckbHDAKUTEN.Text = "Dakuten";
            this.ckbHDAKUTEN.UseVisualStyleBackColor = true;
            this.ckbHDAKUTEN.CheckedChanged += new System.EventHandler(this.ckbHDAKUTEN_CheckedChanged);
            // 
            // ckbHMAIN
            // 
            this.ckbHMAIN.AutoSize = true;
            this.ckbHMAIN.Location = new System.Drawing.Point(20, 31);
            this.ckbHMAIN.Name = "ckbHMAIN";
            this.ckbHMAIN.Size = new System.Drawing.Size(78, 30);
            this.ckbHMAIN.TabIndex = 0;
            this.ckbHMAIN.Text = "Main";
            this.ckbHMAIN.UseVisualStyleBackColor = true;
            this.ckbHMAIN.CheckedChanged += new System.EventHandler(this.ckbHMAIN_CheckedChanged);
            // 
            // gpbKatakanaGroup
            // 
            this.gpbKatakanaGroup.BackColor = System.Drawing.SystemColors.Window;
            this.gpbKatakanaGroup.Controls.Add(this.ckbKCOMBINATION);
            this.gpbKatakanaGroup.Controls.Add(this.ckbKDAKUTEN);
            this.gpbKatakanaGroup.Controls.Add(this.ckbKMAIN);
            this.gpbKatakanaGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.gpbKatakanaGroup.Location = new System.Drawing.Point(203, 12);
            this.gpbKatakanaGroup.Name = "gpbKatakanaGroup";
            this.gpbKatakanaGroup.Size = new System.Drawing.Size(191, 155);
            this.gpbKatakanaGroup.TabIndex = 3;
            this.gpbKatakanaGroup.TabStop = false;
            this.gpbKatakanaGroup.Text = "Katakana";
            // 
            // ckbKCOMBINATION
            // 
            this.ckbKCOMBINATION.AutoSize = true;
            this.ckbKCOMBINATION.Location = new System.Drawing.Point(20, 103);
            this.ckbKCOMBINATION.Name = "ckbKCOMBINATION";
            this.ckbKCOMBINATION.Size = new System.Drawing.Size(154, 30);
            this.ckbKCOMBINATION.TabIndex = 2;
            this.ckbKCOMBINATION.Text = "Combination";
            this.ckbKCOMBINATION.UseVisualStyleBackColor = true;
            this.ckbKCOMBINATION.CheckedChanged += new System.EventHandler(this.ckbKCOMBINATION_CheckedChanged);
            // 
            // ckbKDAKUTEN
            // 
            this.ckbKDAKUTEN.AutoSize = true;
            this.ckbKDAKUTEN.Location = new System.Drawing.Point(20, 67);
            this.ckbKDAKUTEN.Name = "ckbKDAKUTEN";
            this.ckbKDAKUTEN.Size = new System.Drawing.Size(112, 30);
            this.ckbKDAKUTEN.TabIndex = 1;
            this.ckbKDAKUTEN.Text = "Dakuten";
            this.ckbKDAKUTEN.UseVisualStyleBackColor = true;
            this.ckbKDAKUTEN.CheckedChanged += new System.EventHandler(this.ckbKDAKUTEN_CheckedChanged);
            // 
            // ckbKMAIN
            // 
            this.ckbKMAIN.AutoSize = true;
            this.ckbKMAIN.Location = new System.Drawing.Point(20, 31);
            this.ckbKMAIN.Name = "ckbKMAIN";
            this.ckbKMAIN.Size = new System.Drawing.Size(78, 30);
            this.ckbKMAIN.TabIndex = 0;
            this.ckbKMAIN.Text = "Main";
            this.ckbKMAIN.UseVisualStyleBackColor = true;
            this.ckbKMAIN.CheckedChanged += new System.EventHandler(this.ckbKMAIN_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnStart.Location = new System.Drawing.Point(108, 254);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEditar_BD
            // 
            this.btnEditar_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnEditar_BD.Location = new System.Drawing.Point(259, 254);
            this.btnEditar_BD.Name = "btnEditar_BD";
            this.btnEditar_BD.Size = new System.Drawing.Size(135, 38);
            this.btnEditar_BD.TabIndex = 5;
            this.btnEditar_BD.Text = "Editar BD";
            this.btnEditar_BD.UseVisualStyleBackColor = true;
            this.btnEditar_BD.Click += new System.EventHandler(this.btnEditar_BD_Click);
            // 
            // btnMselction
            // 
            this.btnMselction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnMselction.Location = new System.Drawing.Point(12, 254);
            this.btnMselction.Name = "btnMselction";
            this.btnMselction.Size = new System.Drawing.Size(90, 38);
            this.btnMselction.TabIndex = 6;
            this.btnMselction.Text = "ALL";
            this.btnMselction.UseVisualStyleBackColor = true;
            this.btnMselction.Click += new System.EventHandler(this.btnMselction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.ckbConfirmar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // ckbConfirmar
            // 
            this.ckbConfirmar.AutoSize = true;
            this.ckbConfirmar.Checked = true;
            this.ckbConfirmar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbConfirmar.Location = new System.Drawing.Point(20, 31);
            this.ckbConfirmar.Name = "ckbConfirmar";
            this.ckbConfirmar.Size = new System.Drawing.Size(281, 30);
            this.ckbConfirmar.TabIndex = 0;
            this.ckbConfirmar.Text = "Confirmação de respostra";
            this.ckbConfirmar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMselction);
            this.Controls.Add(this.btnEditar_BD);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gpbKatakanaGroup);
            this.Controls.Add(this.gpbHiraganaGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Japanese writting system";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdJPWRITINGSYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiraganaMainBindingSource)).EndInit();
            this.gpbHiraganaGroup.ResumeLayout(false);
            this.gpbHiraganaGroup.PerformLayout();
            this.gpbKatakanaGroup.ResumeLayout(false);
            this.gpbKatakanaGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private bdJPWRITINGSYSTEMDataSet bdJPWRITINGSYSTEMDataSet;
        private System.Windows.Forms.BindingSource hiraganaMainBindingSource;
        private bdJPWRITINGSYSTEMDataSetTableAdapters.HiraganaMainTableAdapter hiraganaMainTableAdapter;
        private System.Windows.Forms.GroupBox gpbHiraganaGroup;
        private System.Windows.Forms.CheckBox ckbHCOMBINATION;
        private System.Windows.Forms.CheckBox ckbHDAKUTEN;
        private System.Windows.Forms.CheckBox ckbHMAIN;
        private System.Windows.Forms.GroupBox gpbKatakanaGroup;
        private System.Windows.Forms.CheckBox ckbKCOMBINATION;
        private System.Windows.Forms.CheckBox ckbKDAKUTEN;
        private System.Windows.Forms.CheckBox ckbKMAIN;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEditar_BD;
        private System.Windows.Forms.Button btnMselction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbConfirmar;
    }
}

