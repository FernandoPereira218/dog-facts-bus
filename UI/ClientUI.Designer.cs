namespace dog_facts_bus
{
    partial class ClientUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientUI));
            this.tbDogFactsInput = new System.Windows.Forms.TextBox();
            this.tbDogFactsOutput = new System.Windows.Forms.TextBox();
            this.tbEndpoint = new System.Windows.Forms.TextBox();
            this.pbSelectInput = new System.Windows.Forms.PictureBox();
            this.pbSelectOutput = new System.Windows.Forms.PictureBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelEndpoint = new System.Windows.Forms.Label();
            this.btnStartInput = new System.Windows.Forms.Button();
            this.btnStartOutput = new System.Windows.Forms.Button();
            this.labelOutputFileName = new System.Windows.Forms.Label();
            this.tbOutputFileName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDogFactsInput
            // 
            this.tbDogFactsInput.Location = new System.Drawing.Point(300, 93);
            this.tbDogFactsInput.Name = "tbDogFactsInput";
            this.tbDogFactsInput.ReadOnly = true;
            this.tbDogFactsInput.Size = new System.Drawing.Size(162, 23);
            this.tbDogFactsInput.TabIndex = 1;
            // 
            // tbDogFactsOutput
            // 
            this.tbDogFactsOutput.Location = new System.Drawing.Point(300, 138);
            this.tbDogFactsOutput.Name = "tbDogFactsOutput";
            this.tbDogFactsOutput.ReadOnly = true;
            this.tbDogFactsOutput.Size = new System.Drawing.Size(162, 23);
            this.tbDogFactsOutput.TabIndex = 2;
            // 
            // tbEndpoint
            // 
            this.tbEndpoint.Location = new System.Drawing.Point(300, 215);
            this.tbEndpoint.Multiline = true;
            this.tbEndpoint.Name = "tbEndpoint";
            this.tbEndpoint.Size = new System.Drawing.Size(162, 111);
            this.tbEndpoint.TabIndex = 3;
            this.tbEndpoint.TextChanged += new System.EventHandler(this.tbEndpoint_TextChanged);
            // 
            // pbSelectInput
            // 
            this.pbSelectInput.Image = ((System.Drawing.Image)(resources.GetObject("pbSelectInput.Image")));
            this.pbSelectInput.Location = new System.Drawing.Point(468, 93);
            this.pbSelectInput.Name = "pbSelectInput";
            this.pbSelectInput.Size = new System.Drawing.Size(23, 23);
            this.pbSelectInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectInput.TabIndex = 4;
            this.pbSelectInput.TabStop = false;
            this.pbSelectInput.Click += new System.EventHandler(this.pbSelectInput_Click);
            // 
            // pbSelectOutput
            // 
            this.pbSelectOutput.Image = ((System.Drawing.Image)(resources.GetObject("pbSelectOutput.Image")));
            this.pbSelectOutput.Location = new System.Drawing.Point(468, 138);
            this.pbSelectOutput.Name = "pbSelectOutput";
            this.pbSelectOutput.Size = new System.Drawing.Size(23, 23);
            this.pbSelectOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectOutput.TabIndex = 5;
            this.pbSelectOutput.TabStop = false;
            this.pbSelectOutput.Click += new System.EventHandler(this.pbSelectOutput_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(243, 96);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(38, 15);
            this.labelInput.TabIndex = 6;
            this.labelInput.Text = "Input:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(233, 138);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(48, 15);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "Output:";
            // 
            // labelEndpoint
            // 
            this.labelEndpoint.AutoSize = true;
            this.labelEndpoint.Location = new System.Drawing.Point(223, 218);
            this.labelEndpoint.Name = "labelEndpoint";
            this.labelEndpoint.Size = new System.Drawing.Size(58, 15);
            this.labelEndpoint.TabIndex = 8;
            this.labelEndpoint.Text = "Endpoint:";
            // 
            // btnStartInput
            // 
            this.btnStartInput.Location = new System.Drawing.Point(79, 107);
            this.btnStartInput.Name = "btnStartInput";
            this.btnStartInput.Size = new System.Drawing.Size(98, 23);
            this.btnStartInput.TabIndex = 9;
            this.btnStartInput.Text = "Start Input";
            this.btnStartInput.UseVisualStyleBackColor = true;
            this.btnStartInput.Click += new System.EventHandler(this.btnStartInput_Click);
            // 
            // btnStartOutput
            // 
            this.btnStartOutput.Location = new System.Drawing.Point(79, 138);
            this.btnStartOutput.Name = "btnStartOutput";
            this.btnStartOutput.Size = new System.Drawing.Size(98, 23);
            this.btnStartOutput.TabIndex = 10;
            this.btnStartOutput.Text = "Start Output";
            this.btnStartOutput.UseVisualStyleBackColor = true;
            this.btnStartOutput.Click += new System.EventHandler(this.btnStartOutput_Click);
            // 
            // labelOutputFileName
            // 
            this.labelOutputFileName.AutoSize = true;
            this.labelOutputFileName.Location = new System.Drawing.Point(177, 177);
            this.labelOutputFileName.Name = "labelOutputFileName";
            this.labelOutputFileName.Size = new System.Drawing.Size(104, 15);
            this.labelOutputFileName.TabIndex = 12;
            this.labelOutputFileName.Text = "Output File Name:";
            // 
            // tbOutputFileName
            // 
            this.tbOutputFileName.Location = new System.Drawing.Point(300, 177);
            this.tbOutputFileName.Name = "tbOutputFileName";
            this.tbOutputFileName.Size = new System.Drawing.Size(162, 23);
            this.tbOutputFileName.TabIndex = 11;
            this.tbOutputFileName.Text = "OutputDogFacts.xlsx";
            this.tbOutputFileName.TextChanged += new System.EventHandler(this.tbOutputFileName_TextChanged);
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutputFileName);
            this.Controls.Add(this.tbOutputFileName);
            this.Controls.Add(this.btnStartOutput);
            this.Controls.Add(this.btnStartInput);
            this.Controls.Add(this.labelEndpoint);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.pbSelectOutput);
            this.Controls.Add(this.pbSelectInput);
            this.Controls.Add(this.tbEndpoint);
            this.Controls.Add(this.tbDogFactsOutput);
            this.Controls.Add(this.tbDogFactsInput);
            this.Name = "ClientUI";
            this.Text = "DogFacts";
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDogFactsInput;
        private System.Windows.Forms.TextBox tbDogFactsOutput;
        private System.Windows.Forms.TextBox tbEndpoint;
        private System.Windows.Forms.PictureBox pbSelectInput;
        private System.Windows.Forms.PictureBox pbSelectOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelEndpoint;
        private System.Windows.Forms.Button btnStartInput;
        private System.Windows.Forms.Button btnStartOutput;
        private System.Windows.Forms.Label labelOutputFileName;
        private System.Windows.Forms.TextBox tbOutputFileName;
    }
}
