using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05_Burtgel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
            textBox1.TextChanged += Input_Changed;
            maskedTextBox1.TextChanged += Input_Changed;
            comboBox1.SelectedIndexChanged += Input_Changed;
            listBox1.SelectedIndexChanged += Input_Changed;
            checkBox1.CheckedChanged += Input_Changed;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            treeView1.AfterSelect += treeView1_AfterSelect;
            pictureBox1.Click += pictureBox1_Click;
            button1.Click += button1_Click;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Бүртгэх";
            maskedTextBox1.Mask = "0000-0000";
            notifyIcon1.Icon = SystemIcons.Information;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] {
                "-- Тэнхим сонгох --",
                "Компьютерын ухаан", "Мэдээллийн технологи", "Программ хангамж",
                "Математик", "Физик" });
            comboBox1.SelectedIndex = 0;

            dateTimePicker1.MaxDate = DateTime.Today;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

            UpdateProgress();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void Input_Changed(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(UpdateProgress));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value.Date > DateTime.Today.AddYears(-age)) age--;
            if (age >= numericUpDown1.Minimum && age <= numericUpDown1.Maximum)
                numericUpDown1.Value = age;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.Show("Зөвхөн тоо оруулна уу", maskedTextBox1, 0, maskedTextBox1.Height, 1500);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int idx = comboBox1.Items.IndexOf(e.Node.Text);
            if (idx > 0) comboBox1.SelectedIndex = idx;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Зураг|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    UpdateProgress();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Warn("Оюутны кодоо оруулна уу.");
                textBox1.Focus();
                return;
            }
            if (!maskedTextBox1.MaskCompleted)
            {
                Warn("Утасны дугаараа бүрэн оруулна уу.");
                maskedTextBox1.Focus();
                return;
            }
            if (comboBox1.SelectedIndex <= 0)
            {
                Warn("Тэнхимээ сонгоно уу.");
                comboBox1.Focus();
                return;
            }

            Student s = new Student
            {
                StudentCode = textBox1.Text.Trim(),
                Phone = maskedTextBox1.Text,
                Age = (int)numericUpDown1.Value,
                BirthDate = dateTimePicker1.Value.Date,
                IsDayStudy = radioButton1.Checked,
                Department = comboBox1.Text,
                HasScholarship = checkBox1.Checked,
                Language = listBox1.SelectedItem?.ToString() ?? "-",
                Photo = pictureBox1.Image != null ? new Bitmap(pictureBox1.Image) : null
            };
            foreach (var item in checkedListBox1.CheckedItems)
                s.Courses.Add(item.ToString());

            ShowInRichText(s);

            ListViewItem lvi = new ListViewItem(s.StudentCode);
            lvi.SubItems.Add(s.Phone);
            lvi.SubItems.Add(s.Age.ToString());
            lvi.Tag = s;
            listView1.Items.Add(lvi);

            labelTotal.Text = "Нийт: " + listView1.Items.Count;

            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(2000, "Бүртгэл", s.StudentCode + " бүртгэгдлээ", ToolTipIcon.Info);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1 &&
                listView1.SelectedItems[0].Tag is Student s)
            {
                ShowInRichText(s);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = 0;
            checkBox1.Checked = false;
            radioButton1.Checked = true;
            listBox1.ClearSelected();
            foreach (int i in checkedListBox1.CheckedIndices.Cast<int>().ToList())
                checkedListBox1.SetItemChecked(i, false);
            dateTimePicker1.Value = DateTime.Today;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;
            richTextBox1.Text = "Бүртгэлийн мэдээлэл энд харагдана...";
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            int done = 0;
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) done++;
            if (maskedTextBox1.MaskCompleted) done++;
            if (comboBox1.SelectedIndex > 0) done++;
            if (checkedListBox1.CheckedItems.Count > 0) done++;
            if (listBox1.SelectedIndex >= 0) done++;
            if (pictureBox1.Image != null) done++;
            progressBar1.Value = done * 100 / 6;
        }

        private void Warn(string msg)
        {
            MessageBox.Show(msg, "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInRichText(Student s)
        {
            richTextBox1.Clear();
            AppendRich("ОЮУТНЫ БҮРТГЭЛ\n", new Font("Segoe UI", 14, FontStyle.Bold), Color.Navy);
            AppendRich("────────────────────\n", new Font("Segoe UI", 9), Color.Gray);

            AddLine("Код: ", s.StudentCode);
            AddLine("Утас: ", s.Phone);
            AddLine("Нас: ", s.Age.ToString());
            AddLine("Төрсөн өдөр: ", s.BirthDate.ToString("yyyy-MM-dd"));
            AddLine("Сургалт: ", s.IsDayStudy ? "Өдрийн" : "Бусад");
            AddLine("Тэнхим: ", s.Department);
            AddLine("Тэтгэлэг: ", s.HasScholarship ? "Тийм" : "Үгүй");
            AddLine("Хичээл: ", s.Courses.Count > 0 ? string.Join(", ", s.Courses) : "-");
            AddLine("Хэл: ", s.Language);
        }

        private void AddLine(string label, string value)
        {
            AppendRich(label, new Font("Segoe UI", 10, FontStyle.Bold), Color.Black);
            AppendRich(value + "\n", new Font("Segoe UI", 10), Color.SeaGreen);
        }

        private void AppendRich(string text, Font font, Color color)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionFont = font;
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(text);
        }
    }
}