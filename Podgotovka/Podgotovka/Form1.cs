using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podgotovka;
using Podgotovka.Entity;
using Podgotovka.Properties;

namespace Podgotovka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPrice();
            LoadSort();
            FillGrid();
            CountOfRows();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }
        private void LoadPrice()
        {
            CbFilterPrice.Items.Add("Все фильтры");
            CbFilterPrice.Items.Add("1-15");
            CbFilterPrice.Items.Add("15-30");
            CbFilterPrice.Items.Add("30-50");
            CbFilterPrice.SelectedItem = CbFilterPrice.Items[0];
        }

        private void LoadSort()
        {
            CbSort.Items.Add("Без сортировки");
            CbSort.Items.Add("По возрастанию");
            CbSort.Items.Add("По убыванию");
            CbSort.SelectedItem = CbSort.Items[0];
        }

        private void CountOfRows()
        {
            using (ObuvEntities obuvEntities = new ObuvEntities())
            {
                label1.Text = $"{dataGridView1.Rows.Count.ToString()} из {obuvEntities.Product.Count()}";
            }
        }

        Bitmap bitmap;
        /// <summary>
        /// Заполнение каталога
        /// </summary>
        private void FillGrid()
        {
            
            string path = @"C:\Users\yuran\source\repos\Podgotovka\Podgotovka\Resources\";
            dataGridView1.Rows.Clear();
            using (ObuvEntities obuvEntities = new ObuvEntities())
            {

                var products = obuvEntities.Product.ToList();

                switch (CbSort.SelectedIndex)
                {
                    default:
                        break;
                    case 1:
                        products = products.OrderBy(x => x.productCost).ToList();
                        break;
                    case 2:
                        products = products.OrderByDescending(x => x.productCost).ToList();
                        break;
                }

                switch (CbFilterPrice.SelectedIndex)
                {
                    default:
                        break;
                    case 1:
                        products = products.Where(x=> x.productActiveDiscountAmount >= 1 && x.productActiveDiscountAmount <= 15).ToList();
                        break;
                    case 2:
                        products = products.Where(x => x.productActiveDiscountAmount >= 15 && x.productActiveDiscountAmount <= 30).ToList();
                        break;
                    case 3:
                        products = products.Where(x => x.productActiveDiscountAmount >= 30 && x.productActiveDiscountAmount <= 50).ToList();
                        break;
                }
       
                for (int i = 0; i < products.Count; i++) 
                {
                    if (i != products.Count() - 1)
                        dataGridView1.Rows.Add();

                    byte? discount = products.Select(x=> x.productActiveDiscountAmount).ToArray()[i];

                    if (!discount.Equals(null)) 
                    {
                        dataGridView1.Rows[i].Cells[1].Value =
                            $"Название продукта {products.Select(x => x.productName).ToArray()[i]}\n" +
                            $"Цена {Math.Round((decimal)products.Select(x => x.productCost).ToArray()[i], 0)}\n" +
                            $"Скидка {products.Select(x => x.productActiveDiscountAmount).ToArray()[i]}\n";
                            
                        dataGridView1.Rows[i].Cells[2].Style.Font = new Font(dataGridView1.Font, FontStyle.Strikeout);
                        dataGridView1.Rows[i].Cells[2].Value = $"Цена со скидкой {Math.Round((decimal)(products.Select(x => x.productCost).ToArray()[i] - products.Select(x => x.productCost).ToArray()[i] * products.Select(x => x.productActiveDiscountAmount).ToArray()[i] / 100), 0)} ";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[1].Value =
                            $"Название продукта {products.Select(x => x.productName).ToArray()[i]}\n" +
                            $"Цена {Math.Round((decimal)products.Select(x => x.productCost).ToArray()[i], 0)}\n";

                    }
                    if(products.Select(x=> x.productActiveDiscountAmount).ToArray()[i]>= 15)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0x96, 0x81, 0x9B); 
                    }

                    var pic = products.Select(x=>x.productPicture).ToArray()[i];
                    if(!String.IsNullOrEmpty(pic))
                    {
                        bitmap = new Bitmap(path + pic + ".jpg");
                        bitmap = new Bitmap(bitmap, 128,128);
                    }
                    else
                    {
                        bitmap = new Bitmap(Resources.empty);
                        bitmap = new Bitmap(bitmap, 128, 128);
                    }
                    dataGridView1.Rows[i].Cells[0].Value = bitmap;
              
                }
            }

            CountOfRows();

        }

        private void CbFilterPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid(); 
        }

        private void CbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
