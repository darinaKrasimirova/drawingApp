using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryShapes;
using Rectangle = LibraryShapes.Rectangle;

namespace Project
{
    public partial class Shape_Creator : Form
    {
        public Shape_Creator()
        {
            InitializeComponent();
        }
        public Shape shape;
        public Color color;
        public int pen;
        private void Shape_Creator_Load(object sender, EventArgs e)
        {
            listBoxShapes.Items.Add("Rectangle");
            listBoxShapes.Items.Add("Square");
            listBoxShapes.Items.Add("Triangle");
            listBoxShapes.Items.Add("Ellipse");
            listBoxShapes.Items.Add("Circle");
            listBoxShapes.Items.Add("Hexagon");
            listBoxShapes.Items.Add("Octagon");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if ((listBoxShapes.SelectedIndex < 0 || listBoxShapes.SelectedIndex > 6)) throw new Exception("Select a shape");

                string[] point = textBoxPosition.Text.Split(',');
                if (point.Length != 2) throw new Exception("Wrong coordinates");
                if (!int.TryParse(point[0], out int x)) throw new Exception("Wrong coordinates");
                if (!int.TryParse(point[1], out int y)) throw new Exception("Wrong coordinates");

                switch (listBoxShapes.SelectedIndex)
                {
                    case 0:
                        {
                            string[] chars = textBoxCharacteristics.Text.Split(',');
                            if (chars.Length!=2) throw new Exception("Enter the rectangle width and height\nseparated by a comma");
                            if (!int.TryParse(chars[0], out int a)) throw new Exception("The sides must be integer numbers");
                            if (!int.TryParse(chars[1], out int b)) throw new Exception("The sides must be integer numbers");
                            shape = new Rectangle(new Point(x,y), a,b);
                        }
                        break;
                    case 1:
                        {
                            if (!int.TryParse(textBoxCharacteristics.Text, out int a)) throw new Exception("The side must be an integer number");
                            shape = new Rectangle(new Point(x, y), a, a);
                        }
                        break;
                    case 2:
                        {
                            string[] chars = textBoxCharacteristics.Text.Split(',');
                            if (chars.Length != 2) throw new Exception("Enter the triangle baseline and height\nseparated by a comma");
                            if (!int.TryParse(chars[0], out int a)) throw new Exception("The baseline must be an integer number");
                            if (!int.TryParse(chars[1], out int h)) throw new Exception("The height must be an integer number");
                            shape = new Triangle(new Point(x, y), a, h);
                        }
                        break;
                    case 3:
                        {
                            string[] chars = textBoxCharacteristics.Text.Split(',');
                            if (chars.Length != 2) throw new Exception("Enter the two radiuses separated by a comma");
                            if (!int.TryParse(chars[0], out int a)) throw new Exception("The radiuses must be integer numbers");
                            if (!int.TryParse(chars[1], out int b)) throw new Exception("The radiuses must be integer numbers");
                            shape = new Ellipse(new Point(x, y), a, b);
                        }
                        break;
                    case 4:
                        {
                            if (!int.TryParse(textBoxCharacteristics.Text, out int a)) throw new Exception("The radius must be an integer number");
                            shape = new Ellipse(new Point(x, y), a, a);
                        }
                        break;
                    case 5:
                        {
                            if (!int.TryParse(textBoxCharacteristics.Text, out int a)) throw new Exception("The side must be an integer number");
                            shape = new Hexagon(new Point(x, y), a);
                        }
                        break;
                    case 6:
                        {
                            if (!int.TryParse(textBoxCharacteristics.Text, out int a)) throw new Exception("The side must be an integer number");
                            shape = new Octagon(new Point(x, y), a);
                        }
                        break;
                }
                color = ChooseColor();
                if (!int.TryParse(textBoxPen.Text, out pen)) throw new Exception("The pen width must be an integer number"); ;
            }
            catch (Exception ex)
            { 
                DialogResult = DialogResult.None;
                labelException.Text = ex.Message;
            }
            
        }

        private void listBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxShapes.SelectedIndex)
            {
                case 0:
                    {
                        labelPosition.Text = "Position X,Y of the upper left point:";
                        labelCharacteristics.Text = "Width, height: ";
                    }
                    break;
                case 1:
                    {
                        labelPosition.Text = "Position X,Y of the upper left point:";
                        labelCharacteristics.Text = "Width: ";
                    }
                    break;
                case 2:
                    {
                        labelPosition.Text = "Position X,Y of the baseline start:";
                        labelCharacteristics.Text = "Baseline, height: ";
                    }
                    break;
                case 3:
                    {
                        labelPosition.Text = "Position X,Y of the center:";
                        labelCharacteristics.Text = "Radius x, Radius y:";
                    }
                    break;
                case 4:
                    {
                        labelPosition.Text = "Position X,Y of the center:";
                        labelCharacteristics.Text = "Radius:";
                    }
                    break;
                case 5:
                case 6:
                    {
                        labelPosition.Text = "Position X,Y of the center:";
                        labelCharacteristics.Text = "Side:";
                    }
                    break;
            }
        }

        private Color ChooseColor()
        {
            switch (boxColors.SelectedIndex)
            {
                case 0: return Color.Black;
                case 1: return Color.Blue;
                case 2: return Color.Brown;
                case 3: return Color.Cyan;
                case 4: return Color.DarkBlue;
                case 5: return Color.DarkGray;
                case 6: return Color.DarkRed;
                case 7: return Color.Gray;
                case 8: return Color.Green;
                case 9: return Color.LightGray;
                case 10: return Color.Orange;
                case 11: return Color.Pink;
                case 12: return Color.Red;
                case 13: return Color.Violet;
                case 14: return Color.Yellow;
                default: return Color.Black;
            }
        }
    }
}
