namespace WindowsFormsApp1
{
    partial class CIRCLE
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
            this.RADIUS = new System.Windows.Forms.TextBox();
            this.RESULT = new System.Windows.Forms.TextBox();
            this.COMPUTEBUTTON = new System.Windows.Forms.Button();
            this.BACKBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RADIUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESULT";
            // 
            // RADIUS
            // 
            this.RADIUS.Location = new System.Drawing.Point(420, 98);
            this.RADIUS.Name = "RADIUS";
            this.RADIUS.Size = new System.Drawing.Size(100, 20);
            this.RADIUS.TabIndex = 2;
            this.RADIUS.TextChanged += new System.EventHandler(this.RADIUS_TextChanged);
            // 
            // RESULT
            // 
            this.RESULT.Location = new System.Drawing.Point(420, 198);
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(100, 20);
            this.RESULT.TabIndex = 3;
            this.RESULT.TextChanged += new System.EventHandler(this.RESULT_TextChanged);
            // 
            // COMPUTEBUTTON
            // 
            this.COMPUTEBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPUTEBUTTON.Location = new System.Drawing.Point(177, 300);
            this.COMPUTEBUTTON.Name = "COMPUTEBUTTON";
            this.COMPUTEBUTTON.Size = new System.Drawing.Size(128, 59);
            this.COMPUTEBUTTON.TabIndex = 4;
            this.COMPUTEBUTTON.Text = "COMPUTE";
            this.COMPUTEBUTTON.UseVisualStyleBackColor = true;
            this.COMPUTEBUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // BACKBUTTON
            // 
            this.BACKBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKBUTTON.Location = new System.Drawing.Point(398, 300);
            this.BACKBUTTON.Name = "BACKBUTTON";
            this.BACKBUTTON.Size = new System.Drawing.Size(122, 59);
            this.BACKBUTTON.TabIndex = 5;
            this.BACKBUTTON.Text = "BACK";
            this.BACKBUTTON.UseVisualStyleBackColor = true;
            this.BACKBUTTON.Click += new System.EventHandler(this.BACKBUTTON_Click);
            // 
            // CIRCLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BACKBUTTON);
            this.Controls.Add(this.COMPUTEBUTTON);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.RADIUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CIRCLE";
            this.Text = "Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RADIUS;
        private System.Windows.Forms.TextBox RESULT;
        private System.Windows.Forms.Button COMPUTEBUTTON;
        private System.Windows.Forms.Button BACKBUTTON;
    }
}