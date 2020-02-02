using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryShapes;
using Rectangle = LibraryShapes.Rectangle;

namespace Project
{
    public partial class FormScene : Form,IGraphics
    {
        public FormScene()
        {
            InitializeComponent();
        }

        List<Shape> shapes = new List<Shape>();
        private readonly int CoordSystemUnit = 15;
        private Shape selected;
        private int shapeNum = 0;

        private void FormScene_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            CoordinateSystem.DrawCoordinateSystem(this, CoordSystemUnit, new Point(0, 24), new Point(1125, 699));
            foreach(Shape sh in shapes)
            {
                sh.Paint(this, sh.ShapeContourColor, sh.ShapeContourWidth);
                if (sh.filled) sh.FillIn(this, sh.FillingColor);
            }
            if (selected != null) selected.DrawFrame(this);
            ShowInfoSelected(selected);
            ShowInfoShapes();
        }

        private void AddShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newShape =new Shape_Creator();
            if (newShape.ShowDialog() == DialogResult.OK)
            {
                Shape sh = newShape.shape;
                shapes.Add(sh);
                sh.Paint(this, newShape.color, newShape.pen);
                sh.SerialNum = shapeNum++;
            }
            ShowInfoShapes();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                var changeShape = new Shape_Editor(selected);
                if (changeShape.ShowDialog() == DialogResult.OK)
                {
                    selected = changeShape.s;
                    Invalidate();
                }
            }
            else
                labelNote.Text = "Select a shape!";
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                foreach (Shape sh in shapes.ToList())
                {
                    if (selected.Equals(sh))
                    {
                        shapes.Remove(sh);
                        break;
                    }
                }
                selected = null;
                Invalidate();
            }
            else labelNote.Text = "Select a shape!";
        }
    
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JSON Files (*.json)|*.json";
            if (saveDialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName,JsonConvert.SerializeObject(shapes, typeof(Shape), Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }));
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "JSON Files (*.json)|*.json";
            if(openDialog.ShowDialog()==DialogResult.OK)
            {
                shapes = JsonConvert.DeserializeObject<List<Shape>>(File.ReadAllText(openDialog.FileName), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                Invalidate();
            }
        }

        private void FormScene_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selected = shapes.Where(s => s.Contains(e.Location))
                    .OrderBy(s => s.SerialNum)
                    .LastOrDefault();
                Invalidate();
            }
        }

        Shape sh;
        int distX;
        int distY;
        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sh = shapes.Where(s => s.Contains(e.Location))
                     .OrderBy(s => s.SerialNum)
                     .LastOrDefault();
                distX = e.Location.X / CoordSystemUnit - sh.Position.X;
                distY = e.Location.Y / CoordSystemUnit - sh.Position.Y;
                selected = sh;
            }
        }

        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sh.Move(new Point(e.Location.X / CoordSystemUnit - distX, e.Location.Y / CoordSystemUnit - distY));
                Invalidate();
            }
        }

        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to save the drawing?", "The appliaction is closing", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "JSON Files (*.json)|*.json";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, JsonConvert.SerializeObject(shapes, typeof(Shape), Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }));
                }
            }
        }

        private void ShowInfoSelected(Shape sh)
        {
            if (sh == null)
            {
                labelSelectedShape.Text = "";
                labelShapeType.Text = "";
                labelSize.Text = "";
                labelLocation.Text = "";
                labelAreaSelected.Text = "";
                labelNote.Text = "";
            }
            else
            {
                labelSelectedShape.Text = "Selected Shape:";
                Type type = sh.GetType();
                var properties = type.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.DeclaredOnly);

                if (type == typeof(Rectangle) && ((int)properties[0].GetValue(sh) == (int)properties[1].GetValue(sh)))
                    labelShapeType.Text = "Type: Square";
                else if (type == typeof(Ellipse) && ((int)properties[0].GetValue(sh) == (int)properties[1].GetValue(sh)))
                    labelShapeType.Text = "Type: Circle";
                else
                    labelShapeType.Text = "Type: " + type.Name;

                try
                {
                    if ((int)properties[0].GetValue(sh) == (int)properties[1].GetValue(sh)) labelSize.Text = $"Size: {properties[0].Name}-{properties[0].GetValue(sh)}";
                    else labelSize.Text = $"Size: {properties[0].Name}-{properties[0].GetValue(sh)},{properties[1].Name}-{properties[1].GetValue(sh)}";
                }
                catch (IndexOutOfRangeException)
                {
                    labelSize.Text = $"Size: {properties[0].Name}-{properties[0].GetValue(sh)}";
                }
                string location = "";
                if (type == typeof(Rectangle))
                    location = "Upper-left point";
                else if (type == typeof(Triangle))
                    location = "Base Start point";
                else location = "Center";
                labelLocation.Text = $"Location: {location}({sh.Position.X},{sh.Position.Y})";
                labelAreaSelected.Text = $"Area: {sh.GetArea()}";
            }
        }

        private void ShowInfoShapes()
        {
            labelArea.Text = $"Area of painting:{shapes.Aggregate(0.0,(area,s)=>area+s.GetArea()) }";
            labelShapes.Text = $"All shapes:{shapes.Count}";
            labelRectangles.Text = $"Rectangles:{shapes.Where(s=> s is Rectangle).Count()}";
            labelTriangles.Text = $"Triangles:{shapes.Where(s => s is Triangle).Count()}";
            labelEllipse.Text = $"Ellipses:{shapes.Where(s => s is Ellipse).Count()}";
            labelHexagon.Text = $"Hexagons:{shapes.Where(s => s is Hexagon).Count()}";
            labelOctagon.Text = $"Octagons:{shapes.Where(s => s is Octagon).Count()}";
        }
        
        public void DrawLine(Color color, int penWidth, Point start, Point end)
        {
            using (Graphics g = CreateGraphics())
            using (Pen p = new Pen(color, penWidth))
            {
                g.DrawLine(p, start, end);
            }
        }

        public void DrawRectangle(Color color, int penWidth, int pointStartX, int pointStartY, int width, int height)
        {
            using (Graphics g = CreateGraphics())
            using (Pen p = new Pen(color, penWidth))
            {
                g.DrawRectangle(p, pointStartX, pointStartY, width, height);
            }
        }

        public void DrawEllipse(Color color, int penWidth, int pointStartX, int pointStartY, int frameWidth, int frameHeight)
        {
            using (Graphics g = CreateGraphics())
            using (Pen p = new Pen(color, penWidth))
            {
                g.DrawEllipse(p, pointStartX, pointStartY, frameWidth, frameHeight);
            }
        }

        public void DrawPolygon(Color color, int penWidth, Point[] points)
        {
            using (Graphics g = CreateGraphics())
            using (Pen p = new Pen(color, penWidth))
            {
                g.DrawPolygon(p, points);
            }
        }

        public void FillRectangle(Color fillingColor, int pointStartX, int pointStartY, int width, int height)
        {
            using (Graphics g = CreateGraphics())
            using (SolidBrush p = new SolidBrush(fillingColor))
            {
                g.FillRectangle(p, pointStartX, pointStartY, width, height);
            }
        }

        public void FillEllipse(Color fillingColor, int pointStartX, int pointStartY, int frameWidth, int frameHeight)
        {
            using (Graphics g = CreateGraphics())
            using (SolidBrush p = new SolidBrush(fillingColor))
            {
                g.FillEllipse(p, pointStartX, pointStartY,frameWidth, frameHeight);
            }
        }

        public void FillPolygon(Color fillingColor, Point[] points)
        {
            using (Graphics g = CreateGraphics())
            using (SolidBrush p = new SolidBrush(fillingColor))
            {
                g.FillPolygon(p, points);
            }
        }
    }
}