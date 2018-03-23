namespace WinFormsBindingExample
{
    partial class Example
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLoadExampleView = new System.Windows.Forms.Button();
            this.btnLoadOtherView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadExampleView
            // 
            this.btnLoadExampleView.Location = new System.Drawing.Point(12, 318);
            this.btnLoadExampleView.Name = "btnLoadExampleView";
            this.btnLoadExampleView.Size = new System.Drawing.Size(156, 23);
            this.btnLoadExampleView.TabIndex = 0;
            this.btnLoadExampleView.Text = "Load ExampleView";
            this.btnLoadExampleView.UseVisualStyleBackColor = true;
            this.btnLoadExampleView.Click += new System.EventHandler(this.btnLoadExampleView_Click);
            // 
            // btnLoadOtherView
            // 
            this.btnLoadOtherView.Location = new System.Drawing.Point(183, 318);
            this.btnLoadOtherView.Name = "btnLoadOtherView";
            this.btnLoadOtherView.Size = new System.Drawing.Size(149, 23);
            this.btnLoadOtherView.TabIndex = 1;
            this.btnLoadOtherView.Text = "Load OtherView";
            this.btnLoadOtherView.UseVisualStyleBackColor = true;
            this.btnLoadOtherView.Click += new System.EventHandler(this.btnLoadOtherView_Click);
            // 
            // Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadOtherView);
            this.Controls.Add(this.btnLoadExampleView);
            this.Name = "Example";
            this.Text = "Example Form";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoadExampleView;
        private System.Windows.Forms.Button btnLoadOtherView;
    }
}

