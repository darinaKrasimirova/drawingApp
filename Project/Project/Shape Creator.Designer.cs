namespace Project
{
    partial class Shape_Creator
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.labelShape = new System.Windows.Forms.Label();
            this.textBoxCharacteristics = new System.Windows.Forms.TextBox();
            this.boxColors = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPen = new System.Windows.Forms.Label();
            this.textBoxPen = new System.Windows.Forms.TextBox();
            this.labelCharacteristics = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelException = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(501, 300);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(300, 174);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // listBoxShapes
            // 
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.Location = new System.Drawing.Point(0, 21);
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.Size = new System.Drawing.Size(177, 134);
            this.listBoxShapes.TabIndex = 0;
            this.listBoxShapes.SelectedIndexChanged += new System.EventHandler(this.listBoxShape_SelectedIndexChanged);
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Location = new System.Drawing.Point(-3, 5);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(43, 13);
            this.labelShape.TabIndex = 3;
            this.labelShape.Text = "Shapes";
            // 
            // textBoxCharacteristics
            // 
            this.textBoxCharacteristics.Location = new System.Drawing.Point(210, 61);
            this.textBoxCharacteristics.Name = "textBoxCharacteristics";
            this.textBoxCharacteristics.Size = new System.Drawing.Size(165, 20);
            this.textBoxCharacteristics.TabIndex = 2;
            // 
            // boxColors
            // 
            this.boxColors.FormattingEnabled = true;
            this.boxColors.IntegralHeight = false;
            this.boxColors.Items.AddRange(new object[] {
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
            this.boxColors.Location = new System.Drawing.Point(210, 100);
            this.boxColors.Name = "boxColors";
            this.boxColors.Size = new System.Drawing.Size(165, 21);
            this.boxColors.Sorted = true;
            this.boxColors.TabIndex = 3;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(207, 84);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(71, 13);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Contour Color";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(210, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelPen
            // 
            this.labelPen.AutoSize = true;
            this.labelPen.Location = new System.Drawing.Point(207, 124);
            this.labelPen.Name = "labelPen";
            this.labelPen.Size = new System.Drawing.Size(75, 13);
            this.labelPen.TabIndex = 13;
            this.labelPen.Text = "Contour Width";
            // 
            // textBoxPen
            // 
            this.textBoxPen.Location = new System.Drawing.Point(210, 140);
            this.textBoxPen.Name = "textBoxPen";
            this.textBoxPen.Size = new System.Drawing.Size(165, 20);
            this.textBoxPen.TabIndex = 4;
            // 
            // labelCharacteristics
            // 
            this.labelCharacteristics.AutoSize = true;
            this.labelCharacteristics.Location = new System.Drawing.Point(207, 45);
            this.labelCharacteristics.Name = "labelCharacteristics";
            this.labelCharacteristics.Size = new System.Drawing.Size(113, 13);
            this.labelCharacteristics.TabIndex = 15;
            this.labelCharacteristics.Text = "Shape Characteristics:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(207, 6);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 16;
            this.labelPosition.Text = "Position";
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.ForeColor = System.Drawing.Color.Red;
            this.labelException.Location = new System.Drawing.Point(-3, 158);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(76, 13);
            this.labelException.TabIndex = 17;
            this.labelException.Text = "                       ";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(210, 22);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(165, 20);
            this.textBoxPosition.TabIndex = 1;
            // 
            // Shape_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 204);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.labelException);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelCharacteristics);
            this.Controls.Add(this.textBoxPen);
            this.Controls.Add(this.labelPen);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.boxColors);
            this.Controls.Add(this.textBoxCharacteristics);
            this.Controls.Add(this.labelShape);
            this.Controls.Add(this.listBoxShapes);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.Name = "Shape_Creator";
            this.Load += new System.EventHandler(this.Shape_Creator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ListBox listBoxShapes;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.TextBox textBoxCharacteristics;
        private System.Windows.Forms.ComboBox boxColors;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPen;
        private System.Windows.Forms.TextBox textBoxPen;
        private System.Windows.Forms.Label labelCharacteristics;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelException;
        private System.Windows.Forms.TextBox textBoxPosition;
    }
}