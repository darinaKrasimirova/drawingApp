namespace Project
{
    partial class Shape_Editor
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
            this.labelShapeChars = new System.Windows.Forms.Label();
            this.textBoxCharacteristics = new System.Windows.Forms.TextBox();
            this.labelInfoShape = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.textBoxPen = new System.Windows.Forms.TextBox();
            this.labelPen = new System.Windows.Forms.Label();
            this.labelPenColor = new System.Windows.Forms.Label();
            this.labelFillColor = new System.Windows.Forms.Label();
            this.comboBoxPenColor = new System.Windows.Forms.ComboBox();
            this.comboBoxFillColor = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelShapeChars
            // 
            this.labelShapeChars.AutoSize = true;
            this.labelShapeChars.Location = new System.Drawing.Point(12, 9);
            this.labelShapeChars.Name = "labelShapeChars";
            this.labelShapeChars.Size = new System.Drawing.Size(113, 13);
            this.labelShapeChars.TabIndex = 1;
            this.labelShapeChars.Text = "Shape Characteristics:";
            // 
            // textBoxCharacteristics
            // 
            this.textBoxCharacteristics.Location = new System.Drawing.Point(12, 61);
            this.textBoxCharacteristics.Name = "textBoxCharacteristics";
            this.textBoxCharacteristics.Size = new System.Drawing.Size(163, 20);
            this.textBoxCharacteristics.TabIndex = 2;
            // 
            // labelInfoShape
            // 
            this.labelInfoShape.AutoSize = true;
            this.labelInfoShape.Location = new System.Drawing.Point(15, 26);
            this.labelInfoShape.Name = "labelInfoShape";
            this.labelInfoShape.Size = new System.Drawing.Size(64, 13);
            this.labelInfoShape.TabIndex = 3;
            this.labelInfoShape.Text = "                   ";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(12, 84);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(31, 13);
            this.labelPoint.TabIndex = 4;
            this.labelPoint.Text = "Point";
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.Location = new System.Drawing.Point(12, 100);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.Size = new System.Drawing.Size(163, 20);
            this.textBoxPoint.TabIndex = 5;
            // 
            // textBoxPen
            // 
            this.textBoxPen.Location = new System.Drawing.Point(215, 25);
            this.textBoxPen.Name = "textBoxPen";
            this.textBoxPen.Size = new System.Drawing.Size(156, 20);
            this.textBoxPen.TabIndex = 6;
            // 
            // labelPen
            // 
            this.labelPen.AutoSize = true;
            this.labelPen.Location = new System.Drawing.Point(212, 9);
            this.labelPen.Name = "labelPen";
            this.labelPen.Size = new System.Drawing.Size(75, 13);
            this.labelPen.TabIndex = 7;
            this.labelPen.Text = "Contour Width";
            // 
            // labelPenColor
            // 
            this.labelPenColor.AutoSize = true;
            this.labelPenColor.Location = new System.Drawing.Point(212, 48);
            this.labelPenColor.Name = "labelPenColor";
            this.labelPenColor.Size = new System.Drawing.Size(71, 13);
            this.labelPenColor.TabIndex = 8;
            this.labelPenColor.Text = "Contour Color";
            // 
            // labelFillColor
            // 
            this.labelFillColor.AutoSize = true;
            this.labelFillColor.Location = new System.Drawing.Point(212, 88);
            this.labelFillColor.Name = "labelFillColor";
            this.labelFillColor.Size = new System.Drawing.Size(60, 13);
            this.labelFillColor.TabIndex = 9;
            this.labelFillColor.Text = "Filling Color";
            // 
            // comboBoxPenColor
            // 
            this.comboBoxPenColor.FormattingEnabled = true;
            this.comboBoxPenColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Cyan",
            "Dark Blue",
            "Dark Gray",
            "Dark Red",
            "Gray",
            "Green",
            "Light Gray",
            "Orange",
            "Pink",
            "Red",
            "Violet",
            "Yellow"});
            this.comboBoxPenColor.Location = new System.Drawing.Point(215, 64);
            this.comboBoxPenColor.Name = "comboBoxPenColor";
            this.comboBoxPenColor.Size = new System.Drawing.Size(157, 21);
            this.comboBoxPenColor.TabIndex = 10;
            // 
            // comboBoxFillColor
            // 
            this.comboBoxFillColor.FormattingEnabled = true;
            this.comboBoxFillColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Cyan",
            "Dark Blue",
            "Dark Gray",
            "Dark Red",
            "Gray",
            "Green",
            "Light Gray",
            "Orange",
            "Pink",
            "Red",
            "Violet",
            "None",
            "Yellow"});
            this.comboBoxFillColor.Location = new System.Drawing.Point(214, 104);
            this.comboBoxFillColor.Name = "comboBoxFillColor";
            this.comboBoxFillColor.Size = new System.Drawing.Size(157, 21);
            this.comboBoxFillColor.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(214, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(296, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.ForeColor = System.Drawing.Color.Red;
            this.labelNote.Location = new System.Drawing.Point(9, 123);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(58, 13);
            this.labelNote.TabIndex = 14;
            this.labelNote.Text = "                 ";
            // 
            // ShapeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 171);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxFillColor);
            this.Controls.Add(this.comboBoxPenColor);
            this.Controls.Add(this.labelFillColor);
            this.Controls.Add(this.labelPenColor);
            this.Controls.Add(this.labelPen);
            this.Controls.Add(this.textBoxPen);
            this.Controls.Add(this.textBoxPoint);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelInfoShape);
            this.Controls.Add(this.textBoxCharacteristics);
            this.Controls.Add(this.labelShapeChars);
            this.Name = "ShapeEditor";
            this.Text = "Edit Shape";
            this.Load += new System.EventHandler(this.Customize_Shape_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelShapeChars;
        private System.Windows.Forms.TextBox textBoxCharacteristics;
        private System.Windows.Forms.Label labelInfoShape;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.TextBox textBoxPen;
        private System.Windows.Forms.Label labelPen;
        private System.Windows.Forms.Label labelPenColor;
        private System.Windows.Forms.Label labelFillColor;
        private System.Windows.Forms.ComboBox comboBoxPenColor;
        private System.Windows.Forms.ComboBox comboBoxFillColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelNote;
    }
}