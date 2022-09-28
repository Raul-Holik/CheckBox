namespace CheckBoxKontrola
{
    partial class Form1
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
            this.chcBxDo = new System.Windows.Forms.CheckBox();
            this.chcBxRu = new System.Windows.Forms.CheckBox();
            this.chcBxVe = new System.Windows.Forms.CheckBox();
            this.chcBxHide = new System.Windows.Forms.CheckBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chcBxDo
            // 
            this.chcBxDo.AutoSize = true;
            this.chcBxDo.Location = new System.Drawing.Point(75, 42);
            this.chcBxDo.Name = "chcBxDo";
            this.chcBxDo.Size = new System.Drawing.Size(67, 17);
            this.chcBxDo.TabIndex = 0;
            this.chcBxDo.TabStop = false;
            this.chcBxDo.Text = "Dorucak";
            this.chcBxDo.UseVisualStyleBackColor = true;
            // 
            // chcBxRu
            // 
            this.chcBxRu.AutoSize = true;
            this.chcBxRu.Location = new System.Drawing.Point(75, 86);
            this.chcBxRu.Name = "chcBxRu";
            this.chcBxRu.Size = new System.Drawing.Size(58, 17);
            this.chcBxRu.TabIndex = 1;
            this.chcBxRu.TabStop = false;
            this.chcBxRu.Text = "Rucak";
            this.chcBxRu.UseVisualStyleBackColor = true;
            // 
            // chcBxVe
            // 
            this.chcBxVe.AutoSize = true;
            this.chcBxVe.Location = new System.Drawing.Point(75, 138);
            this.chcBxVe.Name = "chcBxVe";
            this.chcBxVe.Size = new System.Drawing.Size(60, 17);
            this.chcBxVe.TabIndex = 2;
            this.chcBxVe.TabStop = false;
            this.chcBxVe.Text = "Vecera";
            this.chcBxVe.UseVisualStyleBackColor = true;
            // 
            // chcBxHide
            // 
            this.chcBxHide.AutoSize = true;
            this.chcBxHide.Location = new System.Drawing.Point(287, 239);
            this.chcBxHide.Name = "chcBxHide";
            this.chcBxHide.Size = new System.Drawing.Size(101, 17);
            this.chcBxHide.TabIndex = 3;
            this.chcBxHide.TabStop = false;
            this.chcBxHide.Text = "Sakriji narudžbu";
            this.chcBxHide.UseVisualStyleBackColor = true;
            this.chcBxHide.CheckedChanged += new System.EventHandler(this.chcBxHide_CheckedChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(75, 233);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 1;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(344, 45);
            this.txtBx.Multiline = true;
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(251, 154);
            this.txtBx.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.chcBxHide);
            this.Controls.Add(this.chcBxVe);
            this.Controls.Add(this.chcBxRu);
            this.Controls.Add(this.chcBxDo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chcBxDo;
        private System.Windows.Forms.CheckBox chcBxRu;
        private System.Windows.Forms.CheckBox chcBxVe;
        private System.Windows.Forms.CheckBox chcBxHide;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtBx;
    }
}

