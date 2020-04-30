namespace NumberRange
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startInput = new System.Windows.Forms.TextBox();
            this.endInput = new System.Windows.Forms.TextBox();
            this.valueButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(152, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(327, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fun With Loops!!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter A Starting Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter An Ending Value:";
            // 
            // startInput
            // 
            this.startInput.Location = new System.Drawing.Point(379, 91);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(100, 20);
            this.startInput.TabIndex = 3;
            this.startInput.TextChanged += new System.EventHandler(this.startInput_TextChanged);
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(379, 132);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(100, 20);
            this.endInput.TabIndex = 4;
            this.endInput.TextChanged += new System.EventHandler(this.endInput_TextChanged);
            // 
            // valueButton
            // 
            this.valueButton.Location = new System.Drawing.Point(379, 176);
            this.valueButton.Name = "valueButton";
            this.valueButton.Size = new System.Drawing.Size(100, 23);
            this.valueButton.TabIndex = 5;
            this.valueButton.Text = "Show Values";
            this.valueButton.UseVisualStyleBackColor = true;
            this.valueButton.Click += new System.EventHandler(this.valueButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(12, 273);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(631, 61);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 366);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.valueButton);
            this.Controls.Add(this.endInput);
            this.Controls.Add(this.startInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startInput;
        private System.Windows.Forms.TextBox endInput;
        private System.Windows.Forms.Button valueButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

