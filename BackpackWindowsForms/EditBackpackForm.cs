using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackpackWindowsForms
{
    public partial class EditBackpackForm : Form
    {
        private readonly int _selectedBackpackIndex;
        private readonly string _path;
        private readonly List<Material> _materials;
        private readonly List<Shape> _shapes;
        private readonly List<string> _colors;
        private List<FreeBackpack> _freeBackpack;
        public EditBackpackForm(int selectedBackpackIndex, List<Material> materials, List<Shape> shapes, List<string> colors, List<FreeBackpack> freeBackpack, string path)
        {
            _selectedBackpackIndex = selectedBackpackIndex;
            _materials = materials;
            _shapes = shapes;
            _colors = colors;
            _freeBackpack = freeBackpack;
            _path = path;
            InitializeComponent();
        }

        private void EditBackpackForm_Load(object sender, EventArgs e)
        {
            LoadDataFromBinaryFile();

            foreach (Material material in _materials)
                MaterialComboBox.Items.Add(material.Name);
            foreach (Shape shape in _shapes)
                ShapeComboBox.Items.Add(shape.Name);
            foreach (string color in _colors)
                ColorComboBox.Items.Add(color);

            foreach (Material material in _materials)
                if (material.Name == _freeBackpack[_selectedBackpackIndex].Material)
                    MaterialComboBox.SelectedIndex = MaterialComboBox.Items.IndexOf(material.Name);

            foreach (Shape shape in _shapes)
                if (shape.Name == _freeBackpack[_selectedBackpackIndex].Shape)
                    ShapeComboBox.SelectedIndex = ShapeComboBox.Items.IndexOf(shape.Name);

            foreach (string color in _colors)
                if (color == _freeBackpack[_selectedBackpackIndex].Color)
                    ColorComboBox.SelectedIndex = ColorComboBox.Items.IndexOf(color);

            TagTextBox.Text = _freeBackpack[_selectedBackpackIndex].Tag;
        }

        private void Approve_Click(object sender, EventArgs e)
        {
            string tag;
            Shape shape = null;
            Material material = null;
            string color = null;

            //Проверка на надпись
            if (TagTextBox.Text == string.Empty)
                tag = "AmplitudeBag";
            else
                tag = TagTextBox.Text;

            //Проверка на тип домофона
            if (ShapeComboBox.SelectedIndex != -1)
            {
                foreach (Shape _shape in _shapes)
                    if (_shape.Name == ShapeComboBox.Items[ShapeComboBox.SelectedIndex].ToString())
                        shape = _shape;
            }
            else
            {
                MessageBox.Show("Вы не выбрали тип");
                return;
            }
            //Проверка на материал

            if (MaterialComboBox.SelectedIndex != -1)
            {
                foreach (Material _material in _materials)
                    if (_material.Name == MaterialComboBox.Items[MaterialComboBox.SelectedIndex].ToString())
                        material = _material;
            }
            else
            {
                MessageBox.Show("Вы не выбрали материал");
                return;
            }

            //Проверка на цвет
            if (ColorComboBox.SelectedIndex != -1)
            {
                foreach (string _color in _colors)
                    if (_color == ColorComboBox.Items[ColorComboBox.SelectedIndex].ToString())
                        color = _color;
            }
            else
            {
                MessageBox.Show("Вы не выбрали цвет");
                return;
            }

            _freeBackpack[_selectedBackpackIndex] = new FreeBackpack(tag, shape, material, color);
            SaveDataToBinaryFile();
            MessageBox.Show("Вы успешно изменили товар!");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }
        private void LoadDataFromBinaryFile()
        {
            if (File.Exists($@"{_path}\backpack_data.dat"))
            {
                using (FileStream fileStream = new FileStream($@"{_path}\backpack_data.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    _freeBackpack = (List<FreeBackpack>)formatter.Deserialize(fileStream);
                }
            }
        }
        private void SaveDataToBinaryFile()
        {
            using (FileStream fileStream = new FileStream($@"{_path}\backpack_data.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, _freeBackpack);
            }
        }
    }
}
