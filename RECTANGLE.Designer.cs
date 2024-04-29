namespace WindowsFormsApp1
{
    partial class RECTANGLE
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
            this.BACKBUTTON = new System.Windows.Forms.Button();
            this.COMPUTEBUTTON = new System.Windows.Forms.Button();
            this.Length = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "RESULT";
            // 
            // BACKBUTTON
            // 
            this.BACKBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKBUTTON.Location = new System.Drawing.Point(134, 309);
            this.BACKBUTTON.Name = "BACKBUTTON";
            this.BACKBUTTON.Size = new System.Drawing.Size(147, 71);
            this.BACKBUTTON.TabIndex = 3;
            this.BACKBUTTON.Text = "Back";
            this.BACKBUTTON.UseVisualStyleBackColor = true;
            this.BACKBUTTON.Click += new System.EventHandler(this.BACKBUTTON_Click);
            // 
            // COMPUTEBUTTON
            // 
            this.COMPUTEBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPUTEBUTTON.Location = new System.Drawing.Point(372, 307);
            this.COMPUTEBUTTON.Name = "COMPUTEBUTTON";
            this.COMPUTEBUTTON.Size = new System.Drawing.Size(134, 75);
            this.COMPUTEBUTTON.TabIndex = 4;
            this.COMPUTEBUTTON.Text = "Compute";
            this.COMPUTEBUTTON.UseVisualStyleBackColor = true;
            this.COMPUTEBUTTON.Click += new System.EventHandler(this.COMPUTEBUTTON_Click);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(338, 78);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(136, 20);
            this.Length.TabIndex = 5;
            this.Length.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(338, 154);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(136, 20);
            this.Width.TabIndex = 6;
            this.Width.TextChanged += new System.EventHandler(this.Width_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(338, 231);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(136, 20);
            this.Result.TabIndex = 7;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // RECTANGLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.COMPUTEBUTTON);
            this.Controls.Add(this.BACKBUTTON);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RECTANGLE";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BACKBUTTON;
        private System.Windows.Forms.Button COMPUTEBUTTON;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Result;
    }
}