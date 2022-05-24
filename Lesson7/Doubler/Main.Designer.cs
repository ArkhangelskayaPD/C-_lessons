namespace Doubler
{
    partial class Main
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelUserNubmer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(483, 18);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(189, 119);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Новая игра";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.Location = new System.Drawing.Point(483, 147);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(189, 94);
            this.buttonMultiply.TabIndex = 1;
            this.buttonMultiply.Text = "x2";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(483, 251);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(189, 94);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComputerNumber.Location = new System.Drawing.Point(90, 101);
            this.labelComputerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(222, 29);
            this.labelComputerNumber.TabIndex = 3;
            this.labelComputerNumber.Text = "Получите число:";
            // 
            // labelUserNubmer
            // 
            this.labelUserNubmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUserNubmer.AutoSize = true;
            this.labelUserNubmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserNubmer.Location = new System.Drawing.Point(102, 185);
            this.labelUserNubmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserNubmer.Name = "labelUserNubmer";
            this.labelUserNubmer.Size = new System.Drawing.Size(210, 29);
            this.labelUserNubmer.TabIndex = 4;
            this.labelUserNubmer.Text = "Текущее число:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество введенных команд:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserNubmer);
            this.Controls.Add(this.labelComputerNumber);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonReset);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(739, 585);
            this.MinimumSize = new System.Drawing.Size(702, 431);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelUserNubmer;
        private System.Windows.Forms.Label label1;
    }
}

