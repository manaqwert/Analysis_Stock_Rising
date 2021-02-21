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
    public partial class Analysis_StrockRise : Form
    {
        int ave_frame = 25; //初期値は25日//
        double rise_fall_rate = 0;

        //入力する配列定義
        string[,] File1cont = new string[300, 10000];
        string[,] File2cont = new string[300, 10000];
        string[,] File3cont = new string[300, 10000];
        int days2 = 0;
        int File1row = 0;
        int File2row = 0;
        int File3row = 0;

        //出力する配列定義
        string[,,] recomend_stock = new string[365, 10000, 6];

        string dt;

        string dname;


        public Analysis_StrockRise()
        {
            InitializeComponent();
        }

        //
        //ファイルを選択する
        //
        string Open_file()
        {
            //フォルダ選択ダイアログの初期値指定
            //string file_sel.SelectedPath = @"C:\Data\OneDrive\stock";

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            string folder_name = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

            //dnameにテキストボックスのフォルダ名を入れる
            dname = openFileDialog1.FileName;

            if (System.IO.File.Exists(dname) == false)
            {
                MessageBox.Show(dname + "が見つかりません。", "通知");
                return dname;
            }

            return dname;

        }

        //
        //ファイルを読み込む
        //
        public string[,] Read_file(string dname)
        {
            int days = 1;
            int days3 = 1;
            int stock_num = 1;
            string[,] in_data_file_temp = new string[370, 10000];
            string[,] in_data_file = new string[370, 10000];

            System.IO.StreamReader sr = new System.IO.StreamReader(dname, Encoding.GetEncoding("Shift_JIS"));

            for (days = 1; days <= 369; days++)
            {
                if (sr.EndOfStream == false)
                {
                    //ファイル一行読み込み、カンマ区切り毎にfield[]に格納
                    string file_contents_2 = sr.ReadLine();

                    string[] fields = file_contents_2.Split(',');

                    //
                    //列方向に文字があるだけ読んで配列に格納。要素数はfileds.Length
                    //
                    for (stock_num = 0; stock_num < fields.Length; stock_num++)
                    {
                        in_data_file_temp[days, stock_num] = fields[stock_num];
                    }
                }
                else
                {
                    //最後の行まで読み終わった場合の終了処置
                    //file_contents_Box.Items.Add(days + ", " + stock_num + ", " + "EndOfStream");
                    days2 = days;
                    days = 369;
                }
                //days3 = days3++;
            }

            //
            //列番号を銘柄番号に並び替え
            //
            for (int stock_num2 = 0; stock_num2 < 10000; stock_num2++)
            {
                for (stock_num = 0; stock_num < 10000; stock_num++)
                {
                    string stock_num_string;
                    stock_num_string = stock_num.ToString();
                    if (in_data_file_temp[1, stock_num2] == stock_num_string)
                    {
                        //stock_numと１行目が一致すれば格納
                        days3 = 1;
                        for (days = 1; days < 369; days++)
                        {
                           in_data_file[days3, stock_num] = in_data_file_temp[days, stock_num2];
                            days3 = days3 + 1;
                        }
                    }
                    else
                    {
                        //stock_numと１行目が一致しなければ空欄
                    }
                }
            }

            ListBox.Items.Add("178行目 dname = " + dname + ", days3 = " + days3 + ", days2 = " + days2 + ", ");


            //days2は年初から年末までの営業日数
            int days4 = 0;

            for (double n2 = 0; n2 <= 369; n2++)
            {
                if (n2 > days2 - 2)
                {
                    in_data_file[(int)n2, 0] = "end";
                    //
                    //データの最終行識別のため（2018/1/21）
                    //
                    n2 = 370;
                }
                else
                {
                }

                days4 = days4 + 1;
            }

            //
            //デバッグ用ファイル書き出し(in_data_file)
            //
            //
            //新たなファイルを用意する前に既存ファイル削除
            //
            dt = DateTime.Now.ToString($"yyyyMMddMHHmmss");

            System.IO.File.Delete(@dname + "_" + dt + "_indatafile_122.csv");

            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            //sjisEnc = Encoding.GetEncoding("Shift_JIS");
            System.IO.StreamWriter writer = new System.IO.StreamWriter(@dname + "_" + dt + "_indatafile_122.csv", true, sjisEnc);
            //writer = new System.IO.StreamWriter(@dname + "_" + "_indatafile_122.csv", true, sjisEnc);

            //
            //計算結果の書き出し
            //
            for (int n3 = 1; n3 <= days2; n3++)
            {
                for (stock_num = 0; stock_num < 10000; stock_num++)
                {
                    writer.Write(in_data_file[n3, stock_num] + ",");
                }
                writer.Write("\r\n");

            }

            writer.Close();

            //
            //ここまでファイル書き出し
            //

            //
            //ここまでファイル内容読み込み＆配列格納
            //

            return in_data_file;
        }




        private void Analyss_StockRise_Load(object sender, EventArgs e)
        {

        }


        private void Compute_Button_Click(object sender, EventArgs e)
        {

            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int totaldays = 0;
            int file1notnull = 0;
            int file2notnull = 0;
            int file3notnull = 0;
            int stocknum = 0;
            int stockrisingcount = 0;

            totaldays = 0;

            //
            //読み込んだファイルの個数に従い、計算用配列の日数を設定
            //
            if(File1cont == null)
            {
            }
            else
            {
                totaldays = totaldays + 300;
                file1notnull = 1;
            }
            if (File2cont == null)
            {
            }
            else
            {
                totaldays = totaldays + 300;
                file2notnull = 1;
            }
            if (File3cont == null)
            {
            }
            else
            {
                totaldays = totaldays + 300;
                file3notnull = 1;
            }

            string[,] ComputeFile = new string[totaldays, 10000];

            //
            //選択されたファイルのデータを配列ComputeFileに格納
            //
            int ComputeFilerow = 0;

            if (file1notnull == 1)
            {
                for(l = 0; l <= 300; ++l)
                {
                    for(stocknum = 0; stocknum <= 10000; ++stocknum)
                    {
                        ComputeFile[l, stocknum] = File1cont[l, stocknum];
                        ComputeFilerow = ComputeFilerow + File1row;
                    }
                }
            }
            else
            {
            }
            if (file2notnull == 1)
            {
                for (l = 0; l <= 300; ++l)
                {
                    for (stocknum = 0; stocknum <= 10000; ++stocknum)
                    {
                        ComputeFile[l + File1row + 7, stocknum] = File2cont[l + 7, stocknum];
                        ComputeFilerow = ComputeFilerow + File2row;
                    }
                }
            }
            else
            {
            }
            if (file3notnull == 1)
            {
                for (l = 0; l <= 300; ++l)
                {
                    for (stocknum = 0; stocknum <= 10000; ++stocknum)
                    {
                        ComputeFile[l + File1row + 7 + File2row + 7, stocknum] = File3cont[l + 7, stocknum];
                        ComputeFilerow = ComputeFilerow + File3row;
                    }
                }
            }
            else
            {
            }

            double AVE_B = 0;
            double AVE_A = 0;
            double endofaveframe = 0;
            double AVE_ratio = 0;

            for (stocknum = 1; stocknum <= 10000; ++stocknum)
            {
                for(i = 7; i <= ComputeFilerow + 7; ++i)
                {
                    if(ComputeFile[i, stocknum] != null)
                    {
                        //
                        //前区間平均算出
                        //
                        for (j = 0; j < ave_frame; ++j)
                        {
                            if (i - j <= 7)
                            {
                            }
                            else if (i - j <= ComputeFilerow)
                            {
                                AVE_B = AVE_B + Convert.ToDouble(ComputeFile[i - j, stocknum]);//株価//;
                                endofaveframe = endofaveframe + 1;
                            }
                            else
                            {
                            }
                        }
                        AVE_B = AVE_B / endofaveframe;

                        //
                        //後区間平均算出（ave_frame分インターバル確保）
                        //
                        for (j = ave_frame; j < 2 * ave_frame; ++j)
                        {
                            if (i + j <= 7)
                            {
                            }
                            else if (i + j <= ComputeFilerow)
                            {
                                AVE_B = AVE_B + Convert.ToDouble(ComputeFile[i + j, stocknum]);//株価//;
                                endofaveframe = endofaveframe + 1;
                            }
                            else
                            {
                            }
                        }
                        AVE_A = AVE_A / endofaveframe;

                        //
                        //前区間平均と後区間平均の割合を算出
                        //
                        AVE_ratio = AVE_A / AVE_B;

                        if(AVE_ratio >= 1 + (rise_fall_rate / 100))
                        {
                            ListBox.Items.Add(ComputeFile[0, stocknum] +", " + ComputeFile[1, stocknum] + ", " + ComputeFile[i, 0] + ", " + ComputeFile[i, stocknum] + ", " + AVE_ratio);
                            stockrisingcount = stockrisingcount + 1;
                            //
                            //書き出し
                            //

                        }
                        else
                        {
                        }


                    }
                    else
                    {
                    }
                }
            }

            /*
            //
            //データプロット
            //
            Form2 form2 = new Form2();
            form2.Show();

            for (int i = 1; i < 6; i++)
            {
                if (fileOKNG[i] == 1)
                {
                    if (days_count[i] < 240)
                    {
                        days_count[i] = max_days_count_file;
                    }
                    else
                    {

                    }

                    for (int j = 8; j <= days_count[i]; j++)
                    {
                        plot[i, 1, j] = (j - 8) / (days_count[i] - 10);
                        if (String.IsNullOrEmpty(Plot_file_cont[i, j, plot_stock_num_int]))
                        {
                            plot[i, 2, j] = plot[i, 2, (j - 1)];
                            //plot[i, 2, j] = Convert.ToDouble(Plot_file_cont[i, (j - 1), plot_stock_num_int]);

                            //listBox1.Items.Add("431行目 plot[i, 1, j] = " + plot[i, 1, j] + ", plot[i, 2, j] = " + plot[i, 2, j] + ", ");
                        }
                        else
                        {
                            plot[i, 2, j] = Convert.ToDouble(Plot_file_cont[i, j, plot_stock_num_int]);

                            //listBox1.Items.Add("437行目 plot[i, 1, j] = " + plot[i, 1, j] + ", plot[i, 2, j] = " + plot[i, 2, j] + ", ");
                        }

                        //listBox1.Items.Add("407行目 days_count[i] = " + days_count[i] + ", i =" + i + ", j = " + j + ", ");
                        //listBox1.Items.Add("408行目 plot[i, 1, j] = " + plot[i, 1, j] + " , plot[i, 2, j] = " + plot[i, 2, j] + ", ");

                        //listBox1.Items.Add("443行目 max_days_count_file = " + max_days_count_file + ", ");
                        //listBox1.Items.Add("444行目 days_count[i] = " + days_count[i] + ", ");
                    }
                    form2.Form2_plot(plot, (days_count[i] - 8), Plot_file_cont[1, 1, plot_stock_num_int], Plot_file_cont[1, 2, plot_stock_num_int], fileOKNG);
                }
                else
                {

                }
            }
            */

        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("終了します。", "通知");
            //アプリケーションを終了する。
            Application.Exit();

        }

        //
        //ここからWindow生成関係
        //
        private void File1_label_Click(object sender, EventArgs e)
        {

        }

        private void File2_label_Click(object sender, EventArgs e)
        {

        }

        private void File3_label_Click(object sender, EventArgs e)
        {

        }

        private void File1_Sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void File2_Sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void File3_Sel_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void File1_Sel_Button_Click(object sender, EventArgs e)
        {
            string File1;
            File1 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File1_Sel_Box.Text = File1;

            //ファイルを読み込む
            //string[,] File1cont = new string[300, 5000];
            File1cont = Read_file(File1);
            File1row = days2;
        }

        private void File2_Sel_Button_Click(object sender, EventArgs e)
        {
            string File2;
            File2 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File2_Sel_Box.Text = File2;

            //ファイルを読み込む
            //string[,] File2cont = new string[300, 5000];
            File2cont = Read_file(File2);
            File2row = days2;
        }

        private void File3_Sel_button_Click(object sender, EventArgs e)
        {
            string File3;
            File3 = Open_file();

            //テキストボックスに選択したファイル名を表示する
            File3_Sel_Box.Text = File3;

            //ファイルを読み込む
            //string[,] File3cont = new string[300, 5000];
            File3cont = Read_file(File3);
            File3row = days2;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rise_and_Fall_Rate_label_Click(object sender, EventArgs e)
        {
            rise_fall_rate = Convert.ToDouble(Rise_and_Fall_Rate_Box.Text);
        }

        private void Ave_frames_label_Click(object sender, EventArgs e)
        {

        }

        private void Ave_frames_Box_TextChanged(object sender, EventArgs e)
        {
            ave_frame = Convert.ToInt32(Ave_frames_Box.Text);
        }
    }
}
