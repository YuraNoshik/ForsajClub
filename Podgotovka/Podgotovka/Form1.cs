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
            AmountOfRows();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void LoadPrice()
        {
            CbFilterPrice.Items.Add("Без фильтров");
            CbFilterPrice.Items.Add("1-15");
            CbFilterPrice.Items.Add("15-30");
            CbFilterPrice.Items.Add("30-50");
            CbFilterPrice.SelectedItem = CbFilterPrice.Items[0];
        }
        private void LoadSort()
        {
            CbSort.Items.Add("Без фильтров");
            CbSort.Items.Add("По воз");
            CbSort.Items.Add("По убыв");
            CbSort.SelectedItem = CbSort.Items[0];

        }

        private void AmountOfRows()
        {
            using (ObuvEntities obuv = new ObuvEntities())
            {
                label1.Text = $"{ dataGridView1.Rows.Count.ToString()} из {obuv.Product.Count()}";
            }
        }

        Bitmap bitmap;
        private void FillGrid()
        {
            dataGridView1.Rows.Clear();
            string path = @"C:\Users\yuran\source\repos\Podgotovka\Podgotovka\Resources\";
            using (ObuvEntities obuv = new ObuvEntities())
            {
                var product = obuv.Product.ToList();

                switch(CbFilterPrice.SelectedIndex)
                {
                    default:
                        break;
                    case 1:
                        product = product.Where(x=> x.productActiveDiscountAmount >= 1 && x.productActiveDiscountAmount <= 15).ToList();
                        break;
                    case 2:
                        product = product.Where(x => x.productActiveDiscountAmount >= 15 && x.productActiveDiscountAmount <= 30).ToList();
                        break;
                    case 3:
                        product = product.Where(x => x.productActiveDiscountAmount >= 30 && x.productActiveDiscountAmount <= 50).ToList();
                        break;
                }

                switch (CbSort.SelectedIndex)
                {
                    default:
                        break;
                    case 1:
                        product = product.OrderBy(x => x.productCost).ToList();
                        break;
                    case 2:
                        product = product.OrderByDescending(x => x.productCost).ToList();
                        break;
                    
                }

                for(int i=0; i< product.Count; i++)
                {
                    if (i != product.Count() - 1)
                        dataGridView1.Rows.Add();

                    byte? discount = product.Select(x=> x.productActiveDiscountAmount).ToArray()[i];
                    if (discount != null)
                    {
                        dataGridView1.Rows[i].Cells[1].Value =
                            $"Наименование: {product.Select(x => x.productName).ToArray()[i]}\n" +
                            $"Стоимость: {product.Select(x => x.productCost).ToArray()[i]}\n" +
                            $"Скидка: {product.Select(x => x.productActiveDiscountAmount).ToArray()[i]}\n";
                           
                        dataGridView1.Rows[i].Cells[2].Style.Font = new Font(dataGridView1.Font, FontStyle.Strikeout);
                        dataGridView1.Rows[i].Cells[2].Value = $"Стоимость со сккидкой: {Math.Round((decimal)(product.Select(x => x.productCost).ToArray()[i] - product.Select(x => x.productCost).ToArray()[i] * product.Select(x => x.productActiveDiscountAmount).ToArray()[i] / 100))}\n";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[1].Value =
                            $"Наименование: {product.Select(x => x.productName).ToArray()[i]}\n" +
                            $"Стоимость: {product.Select(x => x.productCost).ToArray()[i]}\n";
                    }
                    var pic = product.Select(x=> x.productPicture).ToArray()[i];
                    if(!String.IsNullOrEmpty(pic))
                    {
                        bitmap = new Bitmap(path + pic + ".jpg");
                        bitmap = new Bitmap(bitmap, 128, 128);
                    }
                    else
                    {
                        bitmap = new Bitmap(Resources.empty);
                        bitmap = new Bitmap(bitmap, 128, 128);
                    }
                    dataGridView1.Rows[i].Cells[0].Value = bitmap;

                    if(product.Select(x=> x.productActiveDiscountAmount).ToArray()[i]>=15)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0x42, 0x62, 0x27);
                    }

                }





            }


            AmountOfRows();
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
