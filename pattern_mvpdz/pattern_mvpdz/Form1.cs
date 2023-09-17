using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPV_END
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ListBox SearchResultsListBox { get { return SearchResultsListBox; } }
        public string name
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public string age
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }

        public event EventHandler<EventArgs> buttonsave;
        public event EventHandler<EventArgs> show;
        public void AddItemToListBox(string item)
        {
            listBox1.Items.Add(item);

        }
        public void ShowInfoPersone(string name, string age)
        {
            this.name = name;
            this.age = age;
            listBox1.Text = $"Name:{name}\tAge:{age}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonsave?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show?.Invoke(this, EventArgs.Empty);
        }
    }
}
