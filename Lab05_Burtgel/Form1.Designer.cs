namespace Lab05_Burtgel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode8 = new TreeNode("Компьютерын ухаан");
            TreeNode treeNode9 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode10 = new TreeNode("Программ хангамж");
            TreeNode treeNode11 = new TreeNode("Мэдээллийн технологийн сургууль", new TreeNode[] { treeNode8, treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("Математик");
            TreeNode treeNode13 = new TreeNode("Физик");
            TreeNode treeNode14 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode12, treeNode13 });
            checkedListBox1 = new CheckedListBox();
            listView1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            treeView1 = new TreeView();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            linkLabel1 = new LinkLabel();
            labelTotal = new Label();
            progressBar1 = new ProgressBar();
            notifyIcon1 = new NotifyIcon(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(12, 110);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(112, 94);
            checkedListBox1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(290, 55);
            listView1.Name = "listView1";
            listView1.Size = new Size(190, 90);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Овог";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Утас";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Нас";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(290, 170);
            treeView1.Name = "treeView1";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Компьютерын ухаан";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Мэдээллийн технологи";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Программ хангамж";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Мэдээллийн технологийн сургууль";
            treeNode12.Name = "Node5";
            treeNode12.Text = "Математик";
            treeNode13.Name = "Node6";
            treeNode13.Text = "Физик";
            treeNode14.Name = "Node4";
            treeNode14.Text = "Байгалийн ухааны сургууль";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode11, treeNode14 });
            treeView1.Size = new Size(190, 130);
            treeView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "M.IT24D032";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 50);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Тэтгэлэгтэй";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 225);
            numericUpDown1.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 200;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 285);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 315);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(120, 23);
            maskedTextBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 345);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(12, 385);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 10;
            button1.Text = "Бүртгэх";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "  Монгол", "  Англи", "  Орос", "  Хятад", "  Япон", "  Солонгос" });
            listBox1.Location = new Point(160, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(115, 79);
            listBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 148);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 12;
            label1.Text = "Цээж зураг";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(160, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(160, 310);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(320, 205);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "Оюутны бүртгэл";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(290, 15);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 15);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх,";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(160, 15);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(47, 15);
            labelTotal.TabIndex = 16;
            labelTotal.Text = "Нийт: 0";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 535);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(470, 22);
            progressBar1.TabIndex = 17;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 570);
            Controls.Add(progressBar1);
            Controls.Add(labelTotal);
            Controls.Add(linkLabel1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Controls.Add(checkedListBox1);
            Name = "Form1";
            Text = "Оюутны бүртгэлийн программ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private ListView listView1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TreeView treeView1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel1;
        private Label labelTotal;
        private ProgressBar progressBar1;
        private NotifyIcon notifyIcon1;
        private ToolTip toolTip1;
    }
}
