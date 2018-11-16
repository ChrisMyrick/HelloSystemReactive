namespace HelloSystem.Reactive
{
    partial class FormMain
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
            this.BtnSubscribe = new System.Windows.Forms.Button();
            this.BtnPublish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSubscribe
            // 
            this.BtnSubscribe.Location = new System.Drawing.Point(58, 84);
            this.BtnSubscribe.Name = "BtnSubscribe";
            this.BtnSubscribe.Size = new System.Drawing.Size(103, 45);
            this.BtnSubscribe.TabIndex = 0;
            this.BtnSubscribe.Text = "Subscribe";
            this.BtnSubscribe.UseVisualStyleBackColor = true;
            this.BtnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // BtnPublish
            // 
            this.BtnPublish.Location = new System.Drawing.Point(206, 84);
            this.BtnPublish.Name = "BtnPublish";
            this.BtnPublish.Size = new System.Drawing.Size(114, 45);
            this.BtnPublish.TabIndex = 2;
            this.BtnPublish.Text = "PublishEvent";
            this.BtnPublish.UseVisualStyleBackColor = true;
            this.BtnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 223);
            this.Controls.Add(this.BtnPublish);
            this.Controls.Add(this.BtnSubscribe);
            this.Name = "FormMain";
            this.Text = "Reactive Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSubscribe;
        private System.Windows.Forms.Button BtnPublish;
    }
}

