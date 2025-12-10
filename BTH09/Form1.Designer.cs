namespace BTH09
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.cbboxShapes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(239, 35);
            this.btnColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(44, 22);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cbboxShapes
            // 
            this.cbboxShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxShapes.FormattingEnabled = true;
            this.cbboxShapes.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"});
            this.cbboxShapes.Location = new System.Drawing.Point(21, 35);
            this.cbboxShapes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbboxShapes.Name = "cbboxShapes";
            this.cbboxShapes.Size = new System.Drawing.Size(192, 24);
            this.cbboxShapes.TabIndex = 2;
            this.cbboxShapes.SelectedIndexChanged += new System.EventHandler(this.cbboxShapes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 421);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbboxShapes);
            this.Name = "Form1";
            this.Text = "ComboBoxText";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cbboxShapes;
    }
}

