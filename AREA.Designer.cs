namespace WindowsFormsApp1
{
    partial class AREA
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
            this.SQUAREBUTTON = new System.Windows.Forms.Button();
            this.RECTANGLEBUTTON = new System.Windows.Forms.Button();
            this.TRIANGLEBUTTON = new System.Windows.Forms.Button();
            this.CIRCLEBUTTON = new System.Windows.Forms.Button();
            this.BACKBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARA OF SHAPES";
            // 
            // SQUAREBUTTON
            // 
            this.SQUAREBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQUAREBUTTON.Location = new System.Drawing.Point(106, 87);
            this.SQUAREBUTTON.Name = "SQUAREBUTTON";
            this.SQUAREBUTTON.Size = new System.Drawing.Size(158, 81);
            this.SQUAREBUTTON.TabIndex = 1;
            this.SQUAREBUTTON.Text = "SQUARE";
            this.SQUAREBUTTON.UseVisualStyleBackColor = true;
            this.SQUAREBUTTON.Click += new System.EventHandler(this.SQUAREBUTTON_Click);
            // 
            // RECTANGLEBUTTON
            // 
            this.RECTANGLEBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RECTANGLEBUTTON.Location = new System.Drawing.Point(474, 87);
            this.RECTANGLEBUTTON.Name = "RECTANGLEBUTTON";
            this.RECTANGLEBUTTON.Size = new System.Drawing.Size(155, 81);
            this.RECTANGLEBUTTON.TabIndex = 2;
            this.RECTANGLEBUTTON.Text = "RECTANGLE";
            this.RECTANGLEBUTTON.UseVisualStyleBackColor = true;
            this.RECTANGLEBUTTON.Click += new System.EventHandler(this.RECTANGLEBUTTON_Click);
            // 
            // TRIANGLEBUTTON
            // 
            this.TRIANGLEBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRIANGLEBUTTON.Location = new System.Drawing.Point(106, 206);
            this.TRIANGLEBUTTON.Name = "TRIANGLEBUTTON";
            this.TRIANGLEBUTTON.Size = new System.Drawing.Size(158, 95);
            this.TRIANGLEBUTTON.TabIndex = 3;
            this.TRIANGLEBUTTON.Text = "TRIANGLE";
            this.TRIANGLEBUTTON.UseVisualStyleBackColor = true;
            this.TRIANGLEBUTTON.Click += new System.EventHandler(this.TRIANGLEBUTTON_Click);
            // 
            // CIRCLEBUTTON
            // 
            this.CIRCLEBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIRCLEBUTTON.Location = new System.Drawing.Point(474, 206);
            this.CIRCLEBUTTON.Name = "CIRCLEBUTTON";
            this.CIRCLEBUTTON.Size = new System.Drawing.Size(155, 95);
            this.CIRCLEBUTTON.TabIndex = 4;
            this.CIRCLEBUTTON.Text = "CIRCLE";
            this.CIRCLEBUTTON.UseVisualStyleBackColor = true;
            this.CIRCLEBUTTON.Click += new System.EventHandler(this.CIRCLEBUTTON_Click);
            // 
            // BACKBUTTON
            // 
            this.BACKBUTTON.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKBUTTON.Location = new System.Drawing.Point(286, 322);
            this.BACKBUTTON.Name = "BACKBUTTON";
            this.BACKBUTTON.Size = new System.Drawing.Size(162, 86);
            this.BACKBUTTON.TabIndex = 5;
            this.BACKBUTTON.Text = "BACK";
            this.BACKBUTTON.UseVisualStyleBackColor = true;
            this.BACKBUTTON.Click += new System.EventHandler(this.BACKBUTTON_Click);
            // 
            // AREA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BACKBUTTON);
            this.Controls.Add(this.CIRCLEBUTTON);
            this.Controls.Add(this.TRIANGLEBUTTON);
            this.Controls.Add(this.RECTANGLEBUTTON);
            this.Controls.Add(this.SQUAREBUTTON);
            this.Controls.Add(this.label1);
            this.Name = "AREA";
            this.Text = "AREA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SQUAREBUTTON;
        private System.Windows.Forms.Button RECTANGLEBUTTON;
        private System.Windows.Forms.Button TRIANGLEBUTTON;
        private System.Windows.Forms.Button CIRCLEBUTTON;
        private System.Windows.Forms.Button BACKBUTTON;
    }
}