namespace SingleResponsible
{
    partial class Form1
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
            buttonCreate = new Button();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(187, 192);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Ekle";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += button1_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(162, 163);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(162, 134);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 302);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
    }
}