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
    public partial class MainForm : Form
    {
        private readonly string _path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\BackpackWindowsForms";
        private List<Material> _materials;
        private List<Shape> _shapes;
        private List<string> _colors;

        private List<FreeBackpack> _freeBackpack = new List<FreeBackpack>();
        private int _autoIncrement = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(_path);
            LoadDataFromBinaryFile();
            UpdateList();

            _shapes = new List<Shape>()
            {
                new Shape("Анатомический", 2000),
                new Shape("Станковый", 3500)
            };

            _materials = new List<Material>()
            {
                new Material("Полиэстер", 1500),
                new Material("Оксфорд", 2000),
                new Material("Нейлон", 2000),
                new Material("Кордура", 3000)
            };
            _colors = new List<string>()
            {
                "чёрный",
                "белый",
                "жёлтый",
                "зелёный",
                "фиолетовый"
            };
        }
        private void UpdateList()
        {
            BackpackList.Items.Clear();

            foreach (FreeBackpack freeBackpack in _freeBackpack)
                BackpackList.Items.Add($"{freeBackpack.Shape} ({freeBackpack.Material}, {freeBackpack.Color}, подпись: {freeBackpack.Tag}, {freeBackpack.Price}руб)");
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackpackList.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали рюкзак", "Ошибка");
                return;
            }

            EditBackpackForm form = new EditBackpackForm(BackpackList.SelectedIndex, _materials, _shapes, _colors, _freeBackpack, _path);
            form.Show();
            form.FormClosing += Form_FormClosing;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackpackList.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали рюкзак", "Ошибка");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                _freeBackpack.RemoveAt(BackpackList.SelectedIndex);

            SaveDataToBinaryFile();
            UpdateList();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBackpackForm form = new AddBackpackForm(_materials, _shapes, _colors, _freeBackpack, _path);
            form.Show();
            form.FormClosing += Form_FormClosing;
        }

        private void ByPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeBackpack = _freeBackpack.OrderBy(x => x.Price).ToList();
            else
                _freeBackpack = _freeBackpack.OrderByDescending(x => x.Price).ToList();

            _autoIncrement++;
            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeBackpack = _freeBackpack.OrderBy(x => x.Shape).ToList();
            else
                _freeBackpack = _freeBackpack.OrderByDescending(x => x.Shape).ToList();

            _autoIncrement++;
            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByMateraialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeBackpack = _freeBackpack.OrderBy(x => x.Material).ToList();
            else
                _freeBackpack = _freeBackpack.OrderByDescending(x => x.Material).ToList();

            _autoIncrement++;
            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeBackpack = _freeBackpack.OrderBy(x => x.Color).ToList();
            else
                _freeBackpack = _freeBackpack.OrderByDescending(x => x.Color).ToList();

            _autoIncrement++;
            SaveDataToBinaryFile();
            UpdateList();
        }

        private void ByTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_autoIncrement % 2 == 0)
                _freeBackpack = _freeBackpack.OrderBy(x => x.Tag).ToList();
            else
                _freeBackpack = _freeBackpack.OrderByDescending(x => x.Tag).ToList();

            _autoIncrement++;
            SaveDataToBinaryFile();
            UpdateList();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadDataFromBinaryFile();
            UpdateList();
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

    [Serializable]
    public class FreeBackpack : Backpack
    {
        public FreeBackpack(string tag, Shape shape, Material material, string color) : base(tag, shape, material, color) { }
    }
}
