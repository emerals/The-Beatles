namespace Trabalho_the_beatles
{
    partial class Beatles
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
            this.tb_tempo_jonh = new System.Windows.Forms.TextBox();
            this.tb_tempo_total = new System.Windows.Forms.TextBox();
            this.tb_tempo_ringo = new System.Windows.Forms.TextBox();
            this.tb_tempo_george = new System.Windows.Forms.TextBox();
            this.tb_tempo_paul = new System.Windows.Forms.TextBox();
            this.btn_Go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_tempo_jonh
            // 
            this.tb_tempo_jonh.Location = new System.Drawing.Point(8, 23);
            this.tb_tempo_jonh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tempo_jonh.Name = "tb_tempo_jonh";
            this.tb_tempo_jonh.Size = new System.Drawing.Size(171, 20);
            this.tb_tempo_jonh.TabIndex = 0;
            this.tb_tempo_jonh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // tb_tempo_total
            // 
            this.tb_tempo_total.Location = new System.Drawing.Point(8, 213);
            this.tb_tempo_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tempo_total.Name = "tb_tempo_total";
            this.tb_tempo_total.Size = new System.Drawing.Size(171, 20);
            this.tb_tempo_total.TabIndex = 2;
            // 
            // tb_tempo_ringo
            // 
            this.tb_tempo_ringo.Location = new System.Drawing.Point(8, 66);
            this.tb_tempo_ringo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tempo_ringo.Name = "tb_tempo_ringo";
            this.tb_tempo_ringo.Size = new System.Drawing.Size(171, 20);
            this.tb_tempo_ringo.TabIndex = 3;
            this.tb_tempo_ringo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // tb_tempo_george
            // 
            this.tb_tempo_george.Location = new System.Drawing.Point(8, 110);
            this.tb_tempo_george.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tempo_george.Name = "tb_tempo_george";
            this.tb_tempo_george.Size = new System.Drawing.Size(171, 20);
            this.tb_tempo_george.TabIndex = 4;
            this.tb_tempo_george.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // tb_tempo_paul
            // 
            this.tb_tempo_paul.Location = new System.Drawing.Point(8, 155);
            this.tb_tempo_paul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_tempo_paul.Name = "tb_tempo_paul";
            this.tb_tempo_paul.Size = new System.Drawing.Size(171, 20);
            this.tb_tempo_paul.TabIndex = 5;
            this.tb_tempo_paul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(8, 240);
            this.btn_Go.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(169, 48);
            this.btn_Go.TabIndex = 6;
            this.btn_Go.Text = "GO";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jonh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Paul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "George";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ringo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tempo total em minutos";
            // 
            // Beatles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabalho_the_beatles.Properties.Resources.the_beatles3_thumb_800x500_118857;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 313);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.tb_tempo_paul);
            this.Controls.Add(this.tb_tempo_george);
            this.Controls.Add(this.tb_tempo_ringo);
            this.Controls.Add(this.tb_tempo_total);
            this.Controls.Add(this.tb_tempo_jonh);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Beatles";
            this.Text = "Beatles";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tempo_jonh;
        private System.Windows.Forms.TextBox tb_tempo_total;
        private System.Windows.Forms.TextBox tb_tempo_ringo;
        private System.Windows.Forms.TextBox tb_tempo_george;
        private System.Windows.Forms.TextBox tb_tempo_paul;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

