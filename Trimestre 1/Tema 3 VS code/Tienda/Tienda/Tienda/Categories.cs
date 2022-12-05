using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Categories : Form
    {
        CategoriesController categoriesController = new CategoriesController();
        public Categories()
        {
            int i = 1;
            foreach (Category category in categoriesController.getAllCategories())
            {

                Button b = new Button();

                b.Font = new Font(Font.FontFamily, 16);
                b.ForeColor = Color.White;
                b.Text = category.description;
                b.Margin = new Padding(4, 3, 4, 3);
                b.BackColor = Color.Black;
                b.Location = new Point(30, 60 + i * 60);
                b.Size = new Size(125, 54);
                b.Name = "btn" + category.id_category;
                if (i == 2)
                {
                    b.Click += new EventHandler(b2_click);
                }
                this.Controls.Add(b);
                i++;
            }
            InitializeComponent();
        }

        private void b2_click(object sender, EventArgs e)
        {
            CategoryMan categoryMan = new CategoryMan();
            categoryMan.ShowDialog();
            this.Close();
        }
    }
}
