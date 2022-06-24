namespace Lab2_win_forms
{
    partial class WybierzZad
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
            this.WyborZadaniaLabel = new System.Windows.Forms.Label();
            this.Lista1 = new System.Windows.Forms.Button();
            this.Lista4 = new System.Windows.Forms.Button();
            this.Lista2 = new System.Windows.Forms.Button();
            this.Lista3 = new System.Windows.Forms.Button();
            this.Lista6 = new System.Windows.Forms.Button();
            this.Lista7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WyborZadaniaLabel
            // 
            this.WyborZadaniaLabel.AccessibleName = "";
            this.WyborZadaniaLabel.AutoSize = true;
            this.WyborZadaniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WyborZadaniaLabel.Location = new System.Drawing.Point(16, 11);
            this.WyborZadaniaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WyborZadaniaLabel.Name = "WyborZadaniaLabel";
            this.WyborZadaniaLabel.Size = new System.Drawing.Size(330, 39);
            this.WyborZadaniaLabel.TabIndex = 0;
            this.WyborZadaniaLabel.Text = "Wybierz liste zadan: ";
            // 
            // Lista1
            // 
            this.Lista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista1.Location = new System.Drawing.Point(16, 87);
            this.Lista1.Margin = new System.Windows.Forms.Padding(4);
            this.Lista1.Name = "Lista1";
            this.Lista1.Size = new System.Drawing.Size(328, 49);
            this.Lista1.TabIndex = 1;
            this.Lista1.Text = "Lista 1";
            this.Lista1.UseVisualStyleBackColor = true;
            this.Lista1.Click += new System.EventHandler(this.Lista1_Click);
            // 
            // Lista4
            // 
            this.Lista4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista4.Location = new System.Drawing.Point(16, 257);
            this.Lista4.Margin = new System.Windows.Forms.Padding(4);
            this.Lista4.Name = "Lista4";
            this.Lista4.Size = new System.Drawing.Size(328, 49);
            this.Lista4.TabIndex = 2;
            this.Lista4.Text = "Lista 4 + 5";
            this.Lista4.UseVisualStyleBackColor = true;
            this.Lista4.Click += new System.EventHandler(this.Lista4_Click);
            // 
            // Lista2
            // 
            this.Lista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista2.Location = new System.Drawing.Point(16, 144);
            this.Lista2.Margin = new System.Windows.Forms.Padding(4);
            this.Lista2.Name = "Lista2";
            this.Lista2.Size = new System.Drawing.Size(328, 49);
            this.Lista2.TabIndex = 3;
            this.Lista2.Text = "Lista 2";
            this.Lista2.UseVisualStyleBackColor = true;
            this.Lista2.Click += new System.EventHandler(this.Lista2_Click);
            // 
            // Lista3
            // 
            this.Lista3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista3.Location = new System.Drawing.Point(16, 201);
            this.Lista3.Margin = new System.Windows.Forms.Padding(4);
            this.Lista3.Name = "Lista3";
            this.Lista3.Size = new System.Drawing.Size(328, 49);
            this.Lista3.TabIndex = 4;
            this.Lista3.Text = "Lista 3";
            this.Lista3.UseVisualStyleBackColor = true;
            this.Lista3.Click += new System.EventHandler(this.Lista3_Click);
            // 
            // Lista6
            // 
            this.Lista6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista6.Location = new System.Drawing.Point(16, 314);
            this.Lista6.Margin = new System.Windows.Forms.Padding(4);
            this.Lista6.Name = "Lista6";
            this.Lista6.Size = new System.Drawing.Size(328, 49);
            this.Lista6.TabIndex = 5;
            this.Lista6.Text = "Lista 6";
            this.Lista6.UseVisualStyleBackColor = true;
            this.Lista6.Click += new System.EventHandler(this.Lista6_Click);
            // 
            // Lista7
            // 
            this.Lista7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista7.Location = new System.Drawing.Point(13, 371);
            this.Lista7.Margin = new System.Windows.Forms.Padding(4);
            this.Lista7.Name = "Lista7";
            this.Lista7.Size = new System.Drawing.Size(328, 49);
            this.Lista7.TabIndex = 6;
            this.Lista7.Text = "Lista 7";
            this.Lista7.UseVisualStyleBackColor = true;
            this.Lista7.Click += new System.EventHandler(this.Lista7_Click);
            // 
            // L2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(360, 449);
            this.Controls.Add(this.Lista7);
            this.Controls.Add(this.Lista6);
            this.Controls.Add(this.Lista3);
            this.Controls.Add(this.Lista2);
            this.Controls.Add(this.Lista4);
            this.Controls.Add(this.Lista1);
            this.Controls.Add(this.WyborZadaniaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WybierzZad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseList()";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WyborZadaniaLabel;
        private System.Windows.Forms.Button Lista1;
        private System.Windows.Forms.Button Lista4;
        private System.Windows.Forms.Button Lista2;
        private System.Windows.Forms.Button Lista3;
        private System.Windows.Forms.Button Lista6;
        private System.Windows.Forms.Button Lista7;
    }
}

