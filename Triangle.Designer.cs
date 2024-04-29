namespace WindowsFormsApp1
{
    partial class Triangle
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
            this.label3 = new System.Windows.Forms.Label();
            this.BASE = new System.Windows.Forms.TextBox();
            this.HEIGHT = new System.Windows.Forms.TextBox();
            this.RESULT = new System.Windows.Forms.TextBox();
            this.COMPUTEBUTTON = new System.Windows.Forms.Button();
            this.BACKBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEIGTH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESULT:";
            // 
            // BASE
            // 
            this.BASE.Location = new System.Drawing.Point(431, 96);
            this.BASE.Name = "BASE";
            this.BASE.Size = new System.Drawing.Size(100, 20);
            this.BASE.TabIndex = 3;
            this.BASE.TextChanged += new System.EventHandler(this.BASE_TextChanged);
            // 
            // HEIGHT
            // 
            this.HEIGHT.Location = new System.Drawing.Point(431, 174);
            this.HEIGHT.Name = "HEIGHT";
            this.HEIGHT.Size = new System.Drawing.Size(100, 20);
            this.HEIGHT.TabIndex = 4;
            this.HEIGHT.TextChanged += new System.EventHandler(this.HEIGHT_TextChanged);
            // 
            // RESULT
            // 
            this.RESULT.Location = new System.Drawing.Point(431, 259);
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(100, 20);
            this.RESULT.TabIndex = 5;
            // 
            // COMPUTEBUTTON
            // 
            this.COMPUTEBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPUTEBUTTON.Location = new System.Drawing.Point(181, 326);
            this.COMPUTEBUTTON.Name = "COMPUTEBUTTON";
            this.COMPUTEBUTTON.Size = new System.Drawing.Size(130, 59);
            this.COMPUTEBUTTON.TabIndex = 6;
            this.COMPUTEBUTTON.Text = "COMPUTE";
            this.COMPUTEBUTTON.UseVisualStyleBackColor = true;
            this.COMPUTEBUTTON.Click += new System.EventHandler(this.COMPUTEBUTTON_Click);
            // 
            // BACKBUTTON
            // 
            this.BACKBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKBUTTON.Location = new System.Drawing.Point(415, 326);
            this.BACKBUTTON.Name = "BACKBUTTON";
            this.BACKBUTTON.Size = new System.Drawing.Size(128, 59);
            this.BACKBUTTON.TabIndex = 7;
            this.BACKBUTTON.Text = "BACK";
            this.BACKBUTTON.UseVisualStyleBackColor = true;
            this.BACKBUTTON.Click += new System.EventHandler(this.BACKBUTTON_Click);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BACKBUTTON);
            this.Controls.Add(this.COMPUTEBUTTON);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.HEIGHT);
            this.Controls.Add(this.BASE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Triangle";
            this.Text = "TRIANGLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BASE;
        private System.Windows.Forms.TextBox HEIGHT;
        private System.Windows.Forms.TextBox RESULT;
        private System.Windows.Forms.Button COMPUTEBUTTON;
        private System.Windows.Forms.Button BACKBUTTON;
    }
}