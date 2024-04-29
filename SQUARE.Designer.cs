namespace WindowsFormsApp1
{
    partial class SQUARE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.COMPUTEBUTTON = new System.Windows.Forms.Button();
            this.BACKBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIDE : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESULT : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // COMPUTEBUTTON
            // 
            this.COMPUTEBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPUTEBUTTON.Location = new System.Drawing.Point(159, 241);
            this.COMPUTEBUTTON.Name = "COMPUTEBUTTON";
            this.COMPUTEBUTTON.Size = new System.Drawing.Size(159, 57);
            this.COMPUTEBUTTON.TabIndex = 4;
            this.COMPUTEBUTTON.Text = "COMPUTE";
            this.COMPUTEBUTTON.UseVisualStyleBackColor = true;
            this.COMPUTEBUTTON.Click += new System.EventHandler(this.COMPUTEBUTTON_Click);
            // 
            // BACKBUTTON
            // 
            this.BACKBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKBUTTON.Location = new System.Drawing.Point(373, 241);
            this.BACKBUTTON.Name = "BACKBUTTON";
            this.BACKBUTTON.Size = new System.Drawing.Size(133, 57);
            this.BACKBUTTON.TabIndex = 5;
            this.BACKBUTTON.Text = "BACK";
            this.BACKBUTTON.UseVisualStyleBackColor = true;
            this.BACKBUTTON.Click += new System.EventHandler(this.BACKBUTTON_Click);
            // 
            // SQUARE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BACKBUTTON);
            this.Controls.Add(this.COMPUTEBUTTON);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SQUARE";
            this.Text = "SQUARE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button COMPUTEBUTTON;
        private System.Windows.Forms.Button BACKBUTTON;
    }
}