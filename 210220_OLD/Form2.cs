using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _122_Analysis_StockRise
{
    public partial class Form2 : Analysis_StrockRise
    {
        /*public Form2()
        {
            InitializeComponent();
        }*/

        public void Form2_Load(object sender, EventArgs e)
        {
            //int xxx = 1;
            //Form2_plot(xxx);
        }

        public void Form2_plot(double[,,] plot, double points, string stock_number, string stock_name, double[] file_OKNG)
        {
            string[] recommend_stock = new string[7];

            chart1.Series.Clear();

            for (int i = 0; i < 6; i++)
            {
                recommend_stock[i] = "file" + Convert.ToString(i);

                if (file_OKNG[i] == 1)
                {
                    //
                    //Seriesの作成
                    //
                    chart1.Series.Add(recommend_stock[i]);

                    //
                    //グラフタイプの設定
                    //
                    chart1.Series[recommend_stock[i]].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    //chart1.Series[recommend_stock[i]].IsVisibleInLegend = true;
                }
                else
                {

                }
            }

            for (int l = 1; l < 6; l++)
            {
                if (file_OKNG[l] == 1)
                {
                    for (int j = 0; j <= points + 8; j++)
                    {
                        chart1.Series[recommend_stock[l]].Points.AddXY(plot[l, 1, j]*1.2, plot[l, 2, j]);
                        //chart1.Series["stock_name"].Points.AddXY(plot[l, 1, j], plot[l, 2, j]);

                        //chart1.Series[recommend_stock[l]].Name = stock_name + "file" + ( l - 1 );
                        //chart1.Series["stock_name"].Name = stock_name + "file" + (l - 1);
                    }
                }
                else
                {

                }
            }
            //
            //グラフ下のテキストボックスに銘柄番号、銘柄を記入
            //
            textBox1.Text = stock_number + " " + stock_name;
            //
            //ウィンドウタイトルに銘柄番号、銘柄を記入
            //
            this.Text = stock_number + " " + stock_name;

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}