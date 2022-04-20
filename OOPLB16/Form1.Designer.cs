
namespace lab_10
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
            this.PoleX = new System.Windows.Forms.TextBox();
            this.PoleY = new System.Windows.Forms.TextBox();
            this.PoleZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PoleRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PoleX
            // 
            this.PoleX.Location = new System.Drawing.Point(41, 12);
            this.PoleX.Name = "PoleX";
            this.PoleX.Size = new System.Drawing.Size(261, 22);
            this.PoleX.TabIndex = 0;
            this.PoleX.Text = "1,5";
            this.PoleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PoleX.TextChanged += new System.EventHandler(this.Pole_TextChanged);
            this.PoleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pole_KeyPress);
            this.PoleX.Validating += new System.ComponentModel.CancelEventHandler(this.Pole_Validating);
            // 
            // PoleY
            // 
            this.PoleY.Location = new System.Drawing.Point(41, 40);
            this.PoleY.Name = "PoleY";
            this.PoleY.Size = new System.Drawing.Size(261, 22);
            this.PoleY.TabIndex = 1;
            this.PoleY.Text = "0,1";
            this.PoleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PoleY.TextChanged += new System.EventHandler(this.Pole_TextChanged);
            this.PoleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pole_KeyPress);
            this.PoleY.Validating += new System.ComponentModel.CancelEventHandler(this.Pole_Validating);
            // 
            // PoleZ
            // 
            this.PoleZ.Location = new System.Drawing.Point(41, 68);
            this.PoleZ.Name = "PoleZ";
            this.PoleZ.Size = new System.Drawing.Size(261, 22);
            this.PoleZ.TabIndex = 2;
            this.PoleZ.Text = "0,5";
            this.PoleZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PoleZ.TextChanged += new System.EventHandler(this.Pole_TextChanged);
            this.PoleZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pole_KeyPress);
            this.PoleZ.Validating += new System.ComponentModel.CancelEventHandler(this.Pole_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обчислити без функції";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Обчислити з функції";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Завершити роботу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат:";
            // 
            // PoleRes
            // 
            this.PoleRes.Location = new System.Drawing.Point(21, 240);
            this.PoleRes.Name = "PoleRes";
            this.PoleRes.ReadOnly = true;
            this.PoleRes.Size = new System.Drawing.Size(280, 22);
            this.PoleRes.TabIndex = 10;
            this.PoleRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.PoleRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PoleZ);
            this.Controls.Add(this.PoleY);
            this.Controls.Add(this.PoleX);
            this.Name = "Form1";
            this.Text = "Lab 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoleX;
        private System.Windows.Forms.TextBox PoleY;
        private System.Windows.Forms.TextBox PoleZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PoleRes;
    }
}

