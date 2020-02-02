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
    public partial class Shape_Editor : Form
    {
        public Shape s;
        public Shape_Editor(Shape sh)
        {
            InitializeComponent();
            s = sh;
        }
        public Color FillColor;
        private void Customize_Shape_Load(object sender, EventArgs e)
        {
            Type type = s.GetType();
            var properties = type.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.DeclaredOnly);
            try
            {
                labelInfoShape.Text = $"{type.Name}:\n{properties[0].Name}/{properties[1].Name}:";
                textBoxCharacteristics.Text = $"{properties[0].GetValue(s)},{properties[1].GetValue(s)}";
            }
            catch (IndexOutOfRangeException)
            {
                labelInfoShape.Text = $"{type.Name}:\n{properties[0].Name}:";
                textBoxCharacteristics.Text = $"{properties[0].GetValue(s)}";
            }
            if(type==typeof(Rectangle)) labelPoint.Text = "Up-left point:";
            else if (type == typeof(Triangle)) labelPoint.Text = "Base starting point:";
            else labelPoint.Text = "Center point:";
            textBoxPoint.Text = $"{s.Position.X},{s.Position.Y}";
            textBoxPen.Text = $"{s.ShapeContourWidth}";
            comboBoxPenColor.Text = $"{s.ShapeContourColor.Name}";
            if (s.filled) comboBoxFillColor.Text = $"{s.FillingColor.Name}";
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string[] chars = textBoxCharacteristics.Text.Split(',');
                if (chars.Length == 2)
                {
                    if (!int.TryParse(chars[0], out int w)) throw new Exception("Enter the shape characteristics as numbers\nseparated by a comma!");
                    if (!int.TryParse(chars[1], out int h)) throw new Exception("Enter the shape characteristics as numbers\nseparated by a comma!");
                    s.Resize(w, h);
                }
                else if (chars.Length == 1)
                {
                    if (!int.TryParse(chars[0], out int w)) throw new Exception("The shape characteristic must be a number!");
                    s.Resize(w);
                }
                string[] point = textBoxPoint.Text.Split(',');
                if (!int.TryParse(point[0], out int x)) throw new Exception("Enter the coordinates as numbers\nseparated by a comma!");
                if (!int.TryParse(point[1], out int y)) throw new Exception("Enter the coordinates as numbers\nseparated by a comma!");
                s.Move(new Point(x, y));
                if (!int.TryParse(textBoxPen.Text, out int pen)) throw new Exception("The pen width must be an integer number!");
                s.ShapeContourWidth = pen;
                if (ChooseColor(comboBoxPenColor) != Color.Empty) s.ShapeContourColor= ChooseColor(comboBoxPenColor);
                if (ChooseColor(comboBoxFillColor) != Color.Empty) s.filled = true;
                else s.filled = false;
                s.FillingColor = ChooseColor(comboBoxFillColor);
            }

            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                labelNote.Text = ex.Message;
            }
        }

        private Color ChooseColor(ComboBox cb)
        {
            switch (cb.SelectedIndex)
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
                default: return Color.Empty;
            }
        }
    }
}
