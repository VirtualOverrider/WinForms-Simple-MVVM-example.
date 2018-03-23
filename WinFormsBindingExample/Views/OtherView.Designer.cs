namespace WinFormsBindingExample.Views
{
    partial class OtherView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOtherFunText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOtherFunText
            // 
            this.lblOtherFunText.AutoEllipsis = true;
            this.lblOtherFunText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOtherFunText.Location = new System.Drawing.Point(12, 10);
            this.lblOtherFunText.Name = "lblOtherFunText";
            this.lblOtherFunText.Size = new System.Drawing.Size(187, 126);
            this.lblOtherFunText.TabIndex = 0;
            this.lblOtherFunText.Text = "Unbound";
            // 
            // OtherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOtherFunText);
            this.Name = "OtherView";
            this.Size = new System.Drawing.Size(220, 149);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOtherFunText;
    }
}
