namespace Project
{
    partial class FormScene
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.addAShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelShapes = new System.Windows.Forms.Label();
            this.labelRectangles = new System.Windows.Forms.Label();
            this.labelTriangles = new System.Windows.Forms.Label();
            this.labelEllipse = new System.Windows.Forms.Label();
            this.labelHexagon = new System.Windows.Forms.Label();
            this.labelOctagon = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelSelectedShape = new System.Windows.Forms.Label();
            this.labelShapeType = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelAreaSelected = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAShapeToolStripMenuItem,
            this.CustomizeToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Margin = new System.Windows.Forms.Padding(1);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(484, 24);
            this.MenuStrip.TabIndex = 0;
            // 
            // addAShapeToolStripMenuItem
            // 
            this.addAShapeToolStripMenuItem.Name = "addAShapeToolStripMenuItem";
            this.addAShapeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.addAShapeToolStripMenuItem.Text = "Add shape";
            this.addAShapeToolStripMenuItem.Click += new System.EventHandler(this.AddShapeToolStripMenuItem_Click);
            // 
            // CustomizeToolStripMenuItem
            // 
            this.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem";
            this.CustomizeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.CustomizeToolStripMenuItem.Text = "Edit";
            this.CustomizeToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(1127, 28);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(238, 29);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Shapes Information";
            // 
            // labelShapes
            // 
            this.labelShapes.AutoSize = true;
            this.labelShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShapes.Location = new System.Drawing.Point(1127, 58);
            this.labelShapes.Name = "labelShapes";
            this.labelShapes.Size = new System.Drawing.Size(185, 24);
            this.labelShapes.TabIndex = 2;
            this.labelShapes.Text = "All Shapes(   in total):";
            // 
            // labelRectangles
            // 
            this.labelRectangles.AutoSize = true;
            this.labelRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRectangles.Location = new System.Drawing.Point(1127, 83);
            this.labelRectangles.Name = "labelRectangles";
            this.labelRectangles.Size = new System.Drawing.Size(94, 20);
            this.labelRectangles.TabIndex = 3;
            this.labelRectangles.Text = "Rectangles:";
            // 
            // labelTriangles
            // 
            this.labelTriangles.AutoSize = true;
            this.labelTriangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTriangles.Location = new System.Drawing.Point(1127, 104);
            this.labelTriangles.Name = "labelTriangles";
            this.labelTriangles.Size = new System.Drawing.Size(77, 20);
            this.labelTriangles.TabIndex = 4;
            this.labelTriangles.Text = "Triangles:";
            // 
            // labelEllipse
            // 
            this.labelEllipse.AutoSize = true;
            this.labelEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEllipse.Location = new System.Drawing.Point(1127, 125);
            this.labelEllipse.Name = "labelEllipse";
            this.labelEllipse.Size = new System.Drawing.Size(67, 20);
            this.labelEllipse.TabIndex = 5;
            this.labelEllipse.Text = "Ellipses:";
            // 
            // labelHexagon
            // 
            this.labelHexagon.AutoSize = true;
            this.labelHexagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHexagon.Location = new System.Drawing.Point(1127, 146);
            this.labelHexagon.Name = "labelHexagon";
            this.labelHexagon.Size = new System.Drawing.Size(85, 20);
            this.labelHexagon.TabIndex = 6;
            this.labelHexagon.Text = "Hexagons:";
            // 
            // labelOctagon
            // 
            this.labelOctagon.AutoSize = true;
            this.labelOctagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOctagon.Location = new System.Drawing.Point(1127, 167);
            this.labelOctagon.Name = "labelOctagon";
            this.labelOctagon.Size = new System.Drawing.Size(82, 20);
            this.labelOctagon.TabIndex = 7;
            this.labelOctagon.Text = "Octagons:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(1127, 188);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(126, 20);
            this.labelArea.TabIndex = 8;
            this.labelArea.Text = "Area of Painting:";
            // 
            // labelSelectedShape
            // 
            this.labelSelectedShape.AutoSize = true;
            this.labelSelectedShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedShape.Location = new System.Drawing.Point(1127, 258);
            this.labelSelectedShape.Name = "labelSelectedShape";
            this.labelSelectedShape.Size = new System.Drawing.Size(149, 24);
            this.labelSelectedShape.TabIndex = 9;
            this.labelSelectedShape.Text = "Selected Shape:";
            // 
            // labelShapeType
            // 
            this.labelShapeType.AutoSize = true;
            this.labelShapeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShapeType.Location = new System.Drawing.Point(1127, 283);
            this.labelShapeType.Name = "labelShapeType";
            this.labelShapeType.Size = new System.Drawing.Size(47, 20);
            this.labelShapeType.TabIndex = 10;
            this.labelShapeType.Text = "Type:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(1127, 304);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(44, 20);
            this.labelSize.TabIndex = 11;
            this.labelSize.Text = "Size:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(1127, 325);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(74, 20);
            this.labelLocation.TabIndex = 12;
            this.labelLocation.Text = "Location:";
            // 
            // labelAreaSelected
            // 
            this.labelAreaSelected.AutoSize = true;
            this.labelAreaSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaSelected.Location = new System.Drawing.Point(1127, 346);
            this.labelAreaSelected.Name = "labelAreaSelected";
            this.labelAreaSelected.Size = new System.Drawing.Size(47, 20);
            this.labelAreaSelected.TabIndex = 13;
            this.labelAreaSelected.Text = "Area:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.Color.Red;
            this.labelNote.Location = new System.Drawing.Point(1127, 420);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(15, 24);
            this.labelNote.TabIndex = 14;
            this.labelNote.Text = " ";
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelAreaSelected);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelShapeType);
            this.Controls.Add(this.labelSelectedShape);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelOctagon);
            this.Controls.Add(this.labelHexagon);
            this.Controls.Add(this.labelEllipse);
            this.Controls.Add(this.labelTriangles);
            this.Controls.Add(this.labelRectangles);
            this.Controls.Add(this.labelShapes);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.MenuStrip);
            this.MaximizeBox = false;
            this.Name = "FormScene";
            this.Text = "Scene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseUp);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addAShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelShapes;
        private System.Windows.Forms.Label labelRectangles;
        private System.Windows.Forms.Label labelTriangles;
        private System.Windows.Forms.Label labelEllipse;
        private System.Windows.Forms.Label labelHexagon;
        private System.Windows.Forms.Label labelOctagon;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelSelectedShape;
        private System.Windows.Forms.Label labelShapeType;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelAreaSelected;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
    }
}

