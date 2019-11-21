﻿namespace PosiChange.Formulários
{
    partial class Cad_Enf
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.cmb_nivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_vol_enf = new System.Windows.Forms.Button();
            this.btn_ver_enf = new System.Windows.Forms.Button();
            this.btn_cad_enf = new System.Windows.Forms.Button();
            this.txt_telefone_cad_enf = new System.Windows.Forms.MaskedTextBox();
            this.txt_intervalo_cad_enf = new System.Windows.Forms.MaskedTextBox();
            this.lbl_telefone_cad_enf = new System.Windows.Forms.Label();
            this.txt_turno_cad_enf = new System.Windows.Forms.TextBox();
            this.txt_coren_cad_enf = new System.Windows.Forms.TextBox();
            this.txt_nome_cad_enf = new System.Windows.Forms.TextBox();
            this.lbl_nivel_cad_enf = new System.Windows.Forms.Label();
            this.lbl_intervalo_cad_enf = new System.Windows.Forms.Label();
            this.lbl_turno_cad_enf = new System.Windows.Forms.Label();
            this.lbl_coren_cad_enf = new System.Windows.Forms.Label();
            this.lbl_nome_cad_enf = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txt_rg);
            this.groupBox1.Controls.Add(this.cmb_nivel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_vol_enf);
            this.groupBox1.Controls.Add(this.btn_ver_enf);
            this.groupBox1.Controls.Add(this.btn_cad_enf);
            this.groupBox1.Controls.Add(this.txt_telefone_cad_enf);
            this.groupBox1.Controls.Add(this.txt_intervalo_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_telefone_cad_enf);
            this.groupBox1.Controls.Add(this.txt_turno_cad_enf);
            this.groupBox1.Controls.Add(this.txt_coren_cad_enf);
            this.groupBox1.Controls.Add(this.txt_nome_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_nivel_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_intervalo_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_turno_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_coren_cad_enf);
            this.groupBox1.Controls.Add(this.lbl_nome_cad_enf);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Enfermeiro";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(209, 55);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(84, 20);
            this.txt_cpf.TabIndex = 22;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(62, 54);
            this.txt_rg.Mask = "00.000.000-0";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(84, 20);
            this.txt_rg.TabIndex = 21;
            // 
            // cmb_nivel
            // 
            this.cmb_nivel.FormattingEnabled = true;
            this.cmb_nivel.Location = new System.Drawing.Point(355, 55);
            this.cmb_nivel.Name = "cmb_nivel";
            this.cmb_nivel.Size = new System.Drawing.Size(81, 21);
            this.cmb_nivel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "RG";
            // 
            // btn_vol_enf
            // 
            this.btn_vol_enf.Location = new System.Drawing.Point(512, 123);
            this.btn_vol_enf.Name = "btn_vol_enf";
            this.btn_vol_enf.Size = new System.Drawing.Size(75, 23);
            this.btn_vol_enf.TabIndex = 15;
            this.btn_vol_enf.Text = "Voltar";
            this.btn_vol_enf.UseVisualStyleBackColor = true;
            this.btn_vol_enf.Click += new System.EventHandler(this.btn_vol_enf_Click);
            // 
            // btn_ver_enf
            // 
            this.btn_ver_enf.Location = new System.Drawing.Point(431, 123);
            this.btn_ver_enf.Name = "btn_ver_enf";
            this.btn_ver_enf.Size = new System.Drawing.Size(75, 23);
            this.btn_ver_enf.TabIndex = 14;
            this.btn_ver_enf.Text = "Verificar";
            this.btn_ver_enf.UseVisualStyleBackColor = true;
            this.btn_ver_enf.Click += new System.EventHandler(this.btn_ver_enf_Click);
            // 
            // btn_cad_enf
            // 
            this.btn_cad_enf.Location = new System.Drawing.Point(350, 123);
            this.btn_cad_enf.Name = "btn_cad_enf";
            this.btn_cad_enf.Size = new System.Drawing.Size(75, 23);
            this.btn_cad_enf.TabIndex = 13;
            this.btn_cad_enf.Text = "Cadastrar";
            this.btn_cad_enf.UseVisualStyleBackColor = true;
            // 
            // txt_telefone_cad_enf
            // 
            this.txt_telefone_cad_enf.Location = new System.Drawing.Point(367, 87);
            this.txt_telefone_cad_enf.Mask = "(00) 00000-0000";
            this.txt_telefone_cad_enf.Name = "txt_telefone_cad_enf";
            this.txt_telefone_cad_enf.Size = new System.Drawing.Size(90, 20);
            this.txt_telefone_cad_enf.TabIndex = 8;
            // 
            // txt_intervalo_cad_enf
            // 
            this.txt_intervalo_cad_enf.Location = new System.Drawing.Point(232, 87);
            this.txt_intervalo_cad_enf.Mask = "00:00";
            this.txt_intervalo_cad_enf.Name = "txt_intervalo_cad_enf";
            this.txt_intervalo_cad_enf.Size = new System.Drawing.Size(38, 20);
            this.txt_intervalo_cad_enf.TabIndex = 6;
            // 
            // lbl_telefone_cad_enf
            // 
            this.lbl_telefone_cad_enf.AutoSize = true;
            this.lbl_telefone_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone_cad_enf.Location = new System.Drawing.Point(288, 88);
            this.lbl_telefone_cad_enf.Name = "lbl_telefone_cad_enf";
            this.lbl_telefone_cad_enf.Size = new System.Drawing.Size(72, 17);
            this.lbl_telefone_cad_enf.TabIndex = 12;
            this.lbl_telefone_cad_enf.Text = "Telefone";
            // 
            // txt_turno_cad_enf
            // 
            this.txt_turno_cad_enf.Location = new System.Drawing.Point(64, 87);
            this.txt_turno_cad_enf.Name = "txt_turno_cad_enf";
            this.txt_turno_cad_enf.Size = new System.Drawing.Size(84, 20);
            this.txt_turno_cad_enf.TabIndex = 5;
            // 
            // txt_coren_cad_enf
            // 
            this.txt_coren_cad_enf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_coren_cad_enf.Location = new System.Drawing.Point(503, 54);
            this.txt_coren_cad_enf.MaxLength = 6;
            this.txt_coren_cad_enf.Name = "txt_coren_cad_enf";
            this.txt_coren_cad_enf.Size = new System.Drawing.Size(84, 20);
            this.txt_coren_cad_enf.TabIndex = 4;
            // 
            // txt_nome_cad_enf
            // 
            this.txt_nome_cad_enf.Location = new System.Drawing.Point(62, 20);
            this.txt_nome_cad_enf.Name = "txt_nome_cad_enf";
            this.txt_nome_cad_enf.Size = new System.Drawing.Size(525, 20);
            this.txt_nome_cad_enf.TabIndex = 1;
            // 
            // lbl_nivel_cad_enf
            // 
            this.lbl_nivel_cad_enf.AutoSize = true;
            this.lbl_nivel_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel_cad_enf.Location = new System.Drawing.Point(304, 55);
            this.lbl_nivel_cad_enf.Name = "lbl_nivel_cad_enf";
            this.lbl_nivel_cad_enf.Size = new System.Drawing.Size(44, 17);
            this.lbl_nivel_cad_enf.TabIndex = 12;
            this.lbl_nivel_cad_enf.Text = "Nivel";
            // 
            // lbl_intervalo_cad_enf
            // 
            this.lbl_intervalo_cad_enf.AutoSize = true;
            this.lbl_intervalo_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intervalo_cad_enf.Location = new System.Drawing.Point(155, 87);
            this.lbl_intervalo_cad_enf.Name = "lbl_intervalo_cad_enf";
            this.lbl_intervalo_cad_enf.Size = new System.Drawing.Size(71, 17);
            this.lbl_intervalo_cad_enf.TabIndex = 12;
            this.lbl_intervalo_cad_enf.Text = "Intervalo";
            // 
            // lbl_turno_cad_enf
            // 
            this.lbl_turno_cad_enf.AutoSize = true;
            this.lbl_turno_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno_cad_enf.Location = new System.Drawing.Point(7, 87);
            this.lbl_turno_cad_enf.Name = "lbl_turno_cad_enf";
            this.lbl_turno_cad_enf.Size = new System.Drawing.Size(51, 17);
            this.lbl_turno_cad_enf.TabIndex = 12;
            this.lbl_turno_cad_enf.Text = "Turno";
            // 
            // lbl_coren_cad_enf
            // 
            this.lbl_coren_cad_enf.AutoSize = true;
            this.lbl_coren_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coren_cad_enf.Location = new System.Drawing.Point(448, 54);
            this.lbl_coren_cad_enf.Name = "lbl_coren_cad_enf";
            this.lbl_coren_cad_enf.Size = new System.Drawing.Size(51, 17);
            this.lbl_coren_cad_enf.TabIndex = 12;
            this.lbl_coren_cad_enf.Text = "Coren";
            // 
            // lbl_nome_cad_enf
            // 
            this.lbl_nome_cad_enf.AutoSize = true;
            this.lbl_nome_cad_enf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome_cad_enf.Location = new System.Drawing.Point(7, 20);
            this.lbl_nome_cad_enf.Name = "lbl_nome_cad_enf";
            this.lbl_nome_cad_enf.Size = new System.Drawing.Size(49, 17);
            this.lbl_nome_cad_enf.TabIndex = 12;
            this.lbl_nome_cad_enf.Text = "Nome";
            // 
            // Cad_Enf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(626, 186);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Cad_Enf";
            this.Text = "PosiChange | Novo Enfermeiro";
            this.Load += new System.EventHandler(this.Cad_Enf_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nome_cad_enf;
        private System.Windows.Forms.Label lbl_nivel_cad_enf;
        private System.Windows.Forms.Label lbl_telefone_cad_enf;
        private System.Windows.Forms.Label lbl_intervalo_cad_enf;
        private System.Windows.Forms.Label lbl_turno_cad_enf;
        private System.Windows.Forms.Label lbl_coren_cad_enf;
        private System.Windows.Forms.TextBox txt_coren_cad_enf;
        private System.Windows.Forms.TextBox txt_nome_cad_enf;
        private System.Windows.Forms.MaskedTextBox txt_telefone_cad_enf;
        private System.Windows.Forms.MaskedTextBox txt_intervalo_cad_enf;
        private System.Windows.Forms.TextBox txt_turno_cad_enf;
        private System.Windows.Forms.Button btn_vol_enf;
        private System.Windows.Forms.Button btn_ver_enf;
        private System.Windows.Forms.Button btn_cad_enf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_nivel;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_rg;
    }
}