
namespace Lab2_win_forms {
    partial class ListaZad6 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Hamm74CoderButton = new System.Windows.Forms.Button();
            this.ChooseZad = new System.Windows.Forms.Button();
            this.inputBox74 = new System.Windows.Forms.TextBox();
            this.WprowadzText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox74 = new System.Windows.Forms.TextBox();
            this.Hamming74DecoderButton = new System.Windows.Forms.Button();
            this.Hamm74CoderButton_2 = new System.Windows.Forms.Button();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lb4 = new System.Windows.Forms.Label();
            this.Lb3 = new System.Windows.Forms.Label();
            this.Lb5 = new System.Windows.Forms.Label();
            this.Lb6 = new System.Windows.Forms.Label();
            this.Lb7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.decodeResultLabel = new System.Windows.Forms.Label();
            this.decodeResultBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearButton_2 = new System.Windows.Forms.Button();
            this.decodeResultBox_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hamm1511CoderButton_2 = new System.Windows.Forms.Button();
            this.Hamming1511DecoderButton = new System.Windows.Forms.Button();
            this.outputBox1511 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputBox1511 = new System.Windows.Forms.TextBox();
            this.Hamm1511CoderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DefaultValues = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.matrixBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.randomBitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hamm74CoderButton
            // 
            this.Hamm74CoderButton.Location = new System.Drawing.Point(11, 62);
            this.Hamm74CoderButton.Margin = new System.Windows.Forms.Padding(2);
            this.Hamm74CoderButton.Name = "Hamm74CoderButton";
            this.Hamm74CoderButton.Size = new System.Drawing.Size(171, 28);
            this.Hamm74CoderButton.TabIndex = 3;
            this.Hamm74CoderButton.Text = "Hamming(7,4) - Code";
            this.Hamm74CoderButton.UseVisualStyleBackColor = true;
            this.Hamm74CoderButton.Click += new System.EventHandler(this.Hamm74CoderButton_Click);
            // 
            // ChooseZad
            // 
            this.ChooseZad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseZad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseZad.Location = new System.Drawing.Point(709, 464);
            this.ChooseZad.Name = "ChooseZad";
            this.ChooseZad.Size = new System.Drawing.Size(86, 35);
            this.ChooseZad.TabIndex = 4;
            this.ChooseZad.Text = "Wybór Zad";
            this.ChooseZad.UseVisualStyleBackColor = true;
            this.ChooseZad.Click += new System.EventHandler(this.ChooseZad_Click);
            // 
            // inputBox74
            // 
            this.inputBox74.Location = new System.Drawing.Point(12, 37);
            this.inputBox74.MaxLength = 4;
            this.inputBox74.Name = "inputBox74";
            this.inputBox74.Size = new System.Drawing.Size(170, 20);
            this.inputBox74.TabIndex = 5;
            this.inputBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WprowadzText
            // 
            this.WprowadzText.AutoSize = true;
            this.WprowadzText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WprowadzText.Location = new System.Drawing.Point(7, 9);
            this.WprowadzText.Name = "WprowadzText";
            this.WprowadzText.Size = new System.Drawing.Size(175, 25);
            this.WprowadzText.TabIndex = 19;
            this.WprowadzText.Text = "Wprowadź dane:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Code Hamming(7,4):";
            // 
            // outputBox74
            // 
            this.outputBox74.Enabled = false;
            this.outputBox74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox74.Location = new System.Drawing.Point(193, 37);
            this.outputBox74.MaxLength = 500;
            this.outputBox74.Name = "outputBox74";
            this.outputBox74.Size = new System.Drawing.Size(233, 20);
            this.outputBox74.TabIndex = 21;
            this.outputBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hamming74DecoderButton
            // 
            this.Hamming74DecoderButton.Enabled = false;
            this.Hamming74DecoderButton.Location = new System.Drawing.Point(193, 62);
            this.Hamming74DecoderButton.Margin = new System.Windows.Forms.Padding(2);
            this.Hamming74DecoderButton.Name = "Hamming74DecoderButton";
            this.Hamming74DecoderButton.Size = new System.Drawing.Size(233, 60);
            this.Hamming74DecoderButton.TabIndex = 22;
            this.Hamming74DecoderButton.Text = "Hamming(7,4) - Decode";
            this.Hamming74DecoderButton.UseVisualStyleBackColor = true;
            this.Hamming74DecoderButton.Click += new System.EventHandler(this.Hamming74DecoderButton_Click);
            // 
            // Hamm74CoderButton_2
            // 
            this.Hamm74CoderButton_2.Location = new System.Drawing.Point(12, 94);
            this.Hamm74CoderButton_2.Margin = new System.Windows.Forms.Padding(2);
            this.Hamm74CoderButton_2.Name = "Hamm74CoderButton_2";
            this.Hamm74CoderButton_2.Size = new System.Drawing.Size(171, 28);
            this.Hamm74CoderButton_2.TabIndex = 25;
            this.Hamm74CoderButton_2.Text = "Hamming(7,4) - Code (rand b)";
            this.Hamm74CoderButton_2.UseVisualStyleBackColor = true;
            this.Hamm74CoderButton_2.Click += new System.EventHandler(this.Hamm74CoderButton_2_Click);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(325, 412);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(0, 25);
            this.Lb1.TabIndex = 26;
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.Location = new System.Drawing.Point(380, 307);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(0, 25);
            this.Lb2.TabIndex = 27;
            // 
            // Lb4
            // 
            this.Lb4.AutoSize = true;
            this.Lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb4.Location = new System.Drawing.Point(438, 412);
            this.Lb4.Name = "Lb4";
            this.Lb4.Size = new System.Drawing.Size(0, 25);
            this.Lb4.TabIndex = 28;
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb3.Location = new System.Drawing.Point(351, 355);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(0, 25);
            this.Lb3.TabIndex = 29;
            // 
            // Lb5
            // 
            this.Lb5.AutoSize = true;
            this.Lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb5.Location = new System.Drawing.Point(380, 412);
            this.Lb5.Name = "Lb5";
            this.Lb5.Size = new System.Drawing.Size(0, 25);
            this.Lb5.TabIndex = 30;
            // 
            // Lb6
            // 
            this.Lb6.AutoSize = true;
            this.Lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb6.Location = new System.Drawing.Point(422, 355);
            this.Lb6.Name = "Lb6";
            this.Lb6.Size = new System.Drawing.Size(0, 25);
            this.Lb6.TabIndex = 31;
            // 
            // Lb7
            // 
            this.Lb7.AutoSize = true;
            this.Lb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb7.Location = new System.Drawing.Point(381, 377);
            this.Lb7.Name = "Lb7";
            this.Lb7.Size = new System.Drawing.Size(0, 25);
            this.Lb7.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab2_win_forms.Properties.Resources.Img2;
            this.pictureBox2.Location = new System.Drawing.Point(11, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 232);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab2_win_forms.Properties.Resources.Img2_2;
            this.pictureBox1.Location = new System.Drawing.Point(273, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 232);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // decodeResultLabel
            // 
            this.decodeResultLabel.AutoSize = true;
            this.decodeResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeResultLabel.Location = new System.Drawing.Point(432, 9);
            this.decodeResultLabel.Name = "decodeResultLabel";
            this.decodeResultLabel.Size = new System.Drawing.Size(152, 25);
            this.decodeResultLabel.TabIndex = 34;
            this.decodeResultLabel.Text = "Decode result:";
            // 
            // decodeResultBox
            // 
            this.decodeResultBox.Enabled = false;
            this.decodeResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeResultBox.Location = new System.Drawing.Point(437, 37);
            this.decodeResultBox.MaxLength = 500;
            this.decodeResultBox.Name = "decodeResultBox";
            this.decodeResultBox.Size = new System.Drawing.Size(207, 20);
            this.decodeResultBox.TabIndex = 35;
            this.decodeResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(437, 62);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(207, 60);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clearButton_2
            // 
            this.clearButton_2.Location = new System.Drawing.Point(437, 177);
            this.clearButton_2.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton_2.Name = "clearButton_2";
            this.clearButton_2.Size = new System.Drawing.Size(207, 60);
            this.clearButton_2.TabIndex = 46;
            this.clearButton_2.Text = "Clear All";
            this.clearButton_2.UseVisualStyleBackColor = true;
            this.clearButton_2.Click += new System.EventHandler(this.ClearButton_2_Click);
            // 
            // decodeResultBox_2
            // 
            this.decodeResultBox_2.Enabled = false;
            this.decodeResultBox_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeResultBox_2.Location = new System.Drawing.Point(437, 152);
            this.decodeResultBox_2.MaxLength = 500;
            this.decodeResultBox_2.Name = "decodeResultBox_2";
            this.decodeResultBox_2.Size = new System.Drawing.Size(207, 20);
            this.decodeResultBox_2.TabIndex = 45;
            this.decodeResultBox_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Decode result:";
            // 
            // Hamm1511CoderButton_2
            // 
            this.Hamm1511CoderButton_2.Location = new System.Drawing.Point(12, 209);
            this.Hamm1511CoderButton_2.Margin = new System.Windows.Forms.Padding(2);
            this.Hamm1511CoderButton_2.Name = "Hamm1511CoderButton_2";
            this.Hamm1511CoderButton_2.Size = new System.Drawing.Size(171, 28);
            this.Hamm1511CoderButton_2.TabIndex = 43;
            this.Hamm1511CoderButton_2.Text = "Hamming(15,11) - Code (rand b)";
            this.Hamm1511CoderButton_2.UseVisualStyleBackColor = true;
            this.Hamm1511CoderButton_2.Click += new System.EventHandler(this.Hamm1511CoderButton_2_Click);
            // 
            // Hamming1511DecoderButton
            // 
            this.Hamming1511DecoderButton.Enabled = false;
            this.Hamming1511DecoderButton.Location = new System.Drawing.Point(193, 177);
            this.Hamming1511DecoderButton.Margin = new System.Windows.Forms.Padding(2);
            this.Hamming1511DecoderButton.Name = "Hamming1511DecoderButton";
            this.Hamming1511DecoderButton.Size = new System.Drawing.Size(233, 60);
            this.Hamming1511DecoderButton.TabIndex = 42;
            this.Hamming1511DecoderButton.Text = "Hamming(15,11) - Decode";
            this.Hamming1511DecoderButton.UseVisualStyleBackColor = true;
            this.Hamming1511DecoderButton.Click += new System.EventHandler(this.Hamming1511DecoderButton_Click);
            // 
            // outputBox1511
            // 
            this.outputBox1511.Enabled = false;
            this.outputBox1511.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox1511.Location = new System.Drawing.Point(193, 152);
            this.outputBox1511.MaxLength = 500;
            this.outputBox1511.Name = "outputBox1511";
            this.outputBox1511.Size = new System.Drawing.Size(233, 20);
            this.outputBox1511.TabIndex = 41;
            this.outputBox1511.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Code Hamming(15,11):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Wprowadź dane:";
            // 
            // inputBox1511
            // 
            this.inputBox1511.Location = new System.Drawing.Point(12, 152);
            this.inputBox1511.MaxLength = 11;
            this.inputBox1511.Name = "inputBox1511";
            this.inputBox1511.Size = new System.Drawing.Size(170, 20);
            this.inputBox1511.TabIndex = 38;
            this.inputBox1511.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hamm1511CoderButton
            // 
            this.Hamm1511CoderButton.Location = new System.Drawing.Point(11, 177);
            this.Hamm1511CoderButton.Margin = new System.Windows.Forms.Padding(2);
            this.Hamm1511CoderButton.Name = "Hamm1511CoderButton";
            this.Hamm1511CoderButton.Size = new System.Drawing.Size(171, 28);
            this.Hamm1511CoderButton.TabIndex = 37;
            this.Hamm1511CoderButton.Text = "Hamming(15,11) - Code";
            this.Hamm1511CoderButton.UseVisualStyleBackColor = true;
            this.Hamm1511CoderButton.Click += new System.EventHandler(this.Hamm1511CoderButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Hamming (7, 4)";
            // 
            // DefaultValues
            // 
            this.DefaultValues.Location = new System.Drawing.Point(648, 37);
            this.DefaultValues.Margin = new System.Windows.Forms.Padding(2);
            this.DefaultValues.Name = "DefaultValues";
            this.DefaultValues.Size = new System.Drawing.Size(147, 200);
            this.DefaultValues.TabIndex = 48;
            this.DefaultValues.Text = "Default Values";
            this.DefaultValues.UseVisualStyleBackColor = true;
            this.DefaultValues.Click += new System.EventHandler(this.DefaultValues_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Matrix";
            this.label6.Visible = false;
            // 
            // matrixBox
            // 
            this.matrixBox.Location = new System.Drawing.Point(621, 412);
            this.matrixBox.Margin = new System.Windows.Forms.Padding(2);
            this.matrixBox.Multiline = true;
            this.matrixBox.Name = "matrixBox";
            this.matrixBox.ReadOnly = true;
            this.matrixBox.Size = new System.Drawing.Size(47, 27);
            this.matrixBox.TabIndex = 50;
            this.matrixBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Rand bit:";
            // 
            // randomBitLabel
            // 
            this.randomBitLabel.AutoSize = true;
            this.randomBitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomBitLabel.Location = new System.Drawing.Point(746, 239);
            this.randomBitLabel.Name = "randomBitLabel";
            this.randomBitLabel.Size = new System.Drawing.Size(49, 25);
            this.randomBitLabel.TabIndex = 52;
            this.randomBitLabel.Text = "N/A";
            // 
            // ListaZad6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 511);
            this.Controls.Add(this.randomBitLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.matrixBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DefaultValues);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearButton_2);
            this.Controls.Add(this.decodeResultBox_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hamm1511CoderButton_2);
            this.Controls.Add(this.Hamming1511DecoderButton);
            this.Controls.Add(this.outputBox1511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputBox1511);
            this.Controls.Add(this.Hamm1511CoderButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decodeResultBox);
            this.Controls.Add(this.decodeResultLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Lb7);
            this.Controls.Add(this.Lb6);
            this.Controls.Add(this.Lb5);
            this.Controls.Add(this.Lb3);
            this.Controls.Add(this.Lb4);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.Hamm74CoderButton_2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hamming74DecoderButton);
            this.Controls.Add(this.outputBox74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WprowadzText);
            this.Controls.Add(this.inputBox74);
            this.Controls.Add(this.ChooseZad);
            this.Controls.Add(this.Hamm74CoderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaZad6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmisja Danych - Lista 6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Hamm74CoderButton;
        private System.Windows.Forms.Button ChooseZad;
        private System.Windows.Forms.TextBox inputBox74;
        private System.Windows.Forms.Label WprowadzText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox74;
        private System.Windows.Forms.Button Hamming74DecoderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Hamm74CoderButton_2;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lb4;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.Label Lb5;
        private System.Windows.Forms.Label Lb6;
        private System.Windows.Forms.Label Lb7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label decodeResultLabel;
        private System.Windows.Forms.TextBox decodeResultBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button clearButton_2;
        private System.Windows.Forms.TextBox decodeResultBox_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Hamm1511CoderButton_2;
        private System.Windows.Forms.Button Hamming1511DecoderButton;
        private System.Windows.Forms.TextBox outputBox1511;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputBox1511;
        private System.Windows.Forms.Button Hamm1511CoderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DefaultValues;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox matrixBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label randomBitLabel;
    }
}