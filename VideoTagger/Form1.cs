using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System.IO;


namespace VideoTagger
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bw;
        private string videoFile = "";
        private string videoSettingFile = "";
        private double videoSpeed = 1.0;
        private bool videoPlaying = false;
        private bool trackBarModified = false;
        private double trackBarPos = 0.0;
        private bool positionMsModified = false;
        private int positionMs = 0;
        private string settingFile = "setting.txt";
        double maxFps;
        private int intervalMsMin = 100;
        private string[] tags = new string[9];
        private int posFrame = 0;
        private int posMs = 0;
        private SortedDictionary<int, string> timeKeys = new SortedDictionary<int, string>();


        public Form1()
        {
            InitializeComponent();

            this.Text = "VideoTagger";

            this.KeyPreview = true;

            // 設定読み出し
            readSettings();

            // Tagsメニューを設定
            setTagsMenu();

            this.FormClosing += Form1_FormClosing; ;
        }


        // 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSetting();
        }


        // 設定読み
        private void readSettings()
        {
            if (File.Exists(settingFile))
            {
                using (StreamReader sr = new StreamReader(settingFile, Encoding.GetEncoding("utf-8")))
                {
                    // 再生可能最大FPS
                    if (!double.TryParse(sr.ReadLine(), out maxFps))
                    {
                        maxFps = 35.0;
                    }
                    tags[0] = sr.ReadLine();  // Tags
                    tags[1] = sr.ReadLine();
                    tags[2] = sr.ReadLine();
                    tags[3] = sr.ReadLine();
                    tags[4] = sr.ReadLine();
                    tags[5] = sr.ReadLine();
                    tags[6] = sr.ReadLine();
                    tags[7] = sr.ReadLine();
                    tags[8] = sr.ReadLine();
                }
            }
            else
            {
                maxFps = 35.0;
                for (int i = 0; i < tags.Length; i++)
                {
                    tags[i] = i.ToString();
                }
            }
            intervalMsMin = (int)(1000 / maxFps);
            toolStripMenuItemFps.Text = maxFps.ToString();  // Max FPS
        }


        // Tagsメニューを設定
        private void setTagsMenu()
        {
            toolStripMenuItemT1.Text = "1:" + tags[0];
            toolStripMenuItemT2.Text = "2:" + tags[1];
            toolStripMenuItemT3.Text = "3:" + tags[2];
            toolStripMenuItemT4.Text = "4:" + tags[3];
            toolStripMenuItemT5.Text = "5:" + tags[4];
            toolStripMenuItemT6.Text = "6:" + tags[5];
            toolStripMenuItemT7.Text = "7:" + tags[6];
            toolStripMenuItemT8.Text = "8:" + tags[7];
            toolStripMenuItemT9.Text = "9:" + tags[8];
        }


        // 設定保存
        private void saveSetting()
        {
            using (StreamWriter sw = new StreamWriter(settingFile, false, Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(maxFps);
                sw.WriteLine(tags[0]);
                sw.WriteLine(tags[1]);
                sw.WriteLine(tags[2]);
                sw.WriteLine(tags[3]);
                sw.WriteLine(tags[4]);
                sw.WriteLine(tags[5]);
                sw.WriteLine(tags[6]);
                sw.WriteLine(tags[7]);
                sw.WriteLine(tags[8]);
            }
        }


        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            videoSpeed = 1.0;
            videoPlaying = true;
            try
            {
                // 動画を再生
                using (var capture = new VideoCapture(videoFile))
                {
                    int frameWidth = capture.FrameWidth;
                    int frameHeight = capture.FrameHeight;
                    int frames = capture.FrameCount;

                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            pictureBox1.Left = 0;
                            pictureBox1.Top = 0;
                            pictureBox1.Width = frameWidth;
                            pictureBox1.Height = frameHeight;
                            labelTotalFrame.Text = "/ " + frames.ToString() + "[frame]  ";
                            labelTotalSec.Text = string.Format("/ {0:F3}[s]", ((double)frames / capture.Fps));
                        }));
                    }
                    else
                    {
                        pictureBox1.Left = 0;
                        pictureBox1.Top = 0;
                        pictureBox1.Width = frameWidth;
                        pictureBox1.Height = frameHeight;
                        labelTotalFrame.Text = "/ " +  frames.ToString() + "[frame]  ";
                        labelTotalSec.Text = string.Format("/ {0:F3}[s]", ((double)frames / capture.Fps));
                    }

                    var mat = new Mat();
                    while (true)
                    {
                        if (videoPlaying || trackBarModified || positionMsModified)
                        {
                            // 最大FPS以上のフレームレートになるものは、間引きして再生する
                            int intervalMs = (int)((1000 / capture.Fps) / videoSpeed);
                            int skip = (int)Math.Ceiling((double)intervalMsMin / intervalMs);
                            if (skip > 1)
                            {
                                capture.PosFrames += skip - 1;
                                intervalMs = (int)(1000 / capture.Fps);
                            }
                            // トラックバーの位置が変更された
                            if (trackBarModified)
                            {
                                trackBarModified = false;
                                capture.PosFrames = (int)(capture.FrameCount * trackBarPos);
                            }
                            // 何らかの方法でミリ秒指定された
                            if (positionMsModified)
                            {
                                positionMsModified = false;
                                capture.PosMsec = positionMs;
                            }
                            posFrame = capture.PosFrames;
                            posMs = capture.PosMsec;
                            if (capture.Read(mat))
                            {
                                bw.ReportProgress(0, mat);
                                if (this.InvokeRequired)
                                {
                                    this.Invoke((MethodInvoker)(() =>
                                    {
                                        labelSpeed.Text = string.Format("Speed x{0:F3} ", videoSpeed);
                                        labelInterval.Text = string.Format("interval {0:F3}[s] ", ((double)intervalMs)/1000);
                                        labelFPS.Text = string.Format("{0:F1}[fps]", 1000 / intervalMs);
                                        labelPosFrame.Text = posFrame.ToString();
                                        labelPosSec.Text = (((double)posMs) / 1000).ToString();
                                        trackBar1.Value = (int)((double)100 * capture.PosFrames / capture.FrameCount);
                                    }));
                                }
                                else
                                {
                                    labelSpeed.Text = string.Format("Speed x{0:F3} ", videoSpeed);
                                    labelInterval.Text = string.Format("interval {0:F3}[s] ", ((double)intervalMs) / 1000);
                                    labelFPS.Text = string.Format("{0:F1}[fps]", 1000 / intervalMs);
                                    labelPosFrame.Text = posFrame.ToString();
                                    labelPosSec.Text = (((double)posMs) / 1000).ToString();
                                    trackBar1.Value = (int)((double)100 * capture.PosFrames / capture.FrameCount);
                                }
                                Thread.Sleep(intervalMs);
                            }
                            else
                            {
                                e.Cancel = false;
                                break;
                            }
                            if (capture.PosFrames == capture.FrameCount)
                            {
                                videoPlaying = false;  // 最終フレームを再生したら、一時停止しておく
                            }
                            if (bw.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                var mat = e.UserState as Mat;
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }
                if (mat.IsContinuous())
                {
                    pictureBox1.Image = BitmapConverter.ToBitmap(mat);
                }
            }
            catch (Exception)
            { }
        }


        // 動画を開く
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            var dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // 動画を再生中であれば終了させる
                if (bw != null)
                {
                    if (bw.IsBusy)
                    {
                        bw.CancelAsync();
                        while (bw.IsBusy)
                        {
                            Thread.Sleep(500);
                        }
                    }
                }
                bw = null;
                bw = new BackgroundWorker();
                bw.WorkerSupportsCancellation = true;
                bw.WorkerReportsProgress = true;
                bw.DoWork += bw_DoWork;
                bw.ProgressChanged += bw_ProgressChanged;

                videoFile = fd.FileName;
                videoSettingFile = videoFile + ".config.txt";
                // 指定動画の固有設定やタイムスタンプを読み出し
                readVideoSettings();

                bw.RunWorkerAsync();
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9)
            {
                string tag = "";
                if (e.KeyCode == Keys.D1)
                {
                    tag = tags[0];
                }
                else if (e.KeyCode == Keys.D2)
                {
                    tag = tags[1];
                }
                else if (e.KeyCode == Keys.D3)
                {
                    tag = tags[2];
                }
                else if (e.KeyCode == Keys.D4)
                {
                    tag = tags[3];
                }
                else if (e.KeyCode == Keys.D5)
                {
                    tag = tags[4];
                }
                else if (e.KeyCode == Keys.D6)
                {
                    tag = tags[5];
                }
                else if (e.KeyCode == Keys.D7)
                {
                    tag = tags[6];
                }
                else if (e.KeyCode == Keys.D8)
                {
                    tag = tags[7];
                }
                else if (e.KeyCode == Keys.D9)
                {
                    tag = tags[8];
                }
                try
                {
                    timeKeys.Add(posMs, tag);
                }
                catch (Exception)
                { }
                listBox1.Items.Clear();
                foreach (KeyValuePair<int, string> pair in timeKeys)
                {
                    listBox1.Items.Add((((double)pair.Key) / 1000).ToString() + "/" + pair.Value);
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (videoSpeed < 0.02)
                {
                    videoSpeed = 0.02;
                }
                else if (videoSpeed <= 0.2)
                {
                    videoSpeed -= 0.02;
                }
                else if (videoSpeed <= 1)
                {
                    videoSpeed -= 0.1;
                }
                else if (videoSpeed <= 2)
                {
                    videoSpeed -= 0.1;
                }
                else if (videoSpeed <= 4)
                {
                    videoSpeed -= 0.5;
                }
                else if (videoSpeed <= 10)
                {
                    videoSpeed -= 1;
                }
                else
                {
                    videoSpeed -= 10;
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                videoSpeed = 1.0;
            }
            else if (e.KeyCode == Keys.D)
            {
                if (videoSpeed >= 20)
                {
                    videoSpeed = 20;
                }
                else if (videoSpeed >= 10)
                {
                    videoSpeed += 10;
                }
                else if (videoSpeed >= 4)
                {
                    videoSpeed += 1;
                }
                else if (videoSpeed >= 2)
                {
                    videoSpeed += 0.5;
                }
                else if (videoSpeed >= 0.2)
                {
                    videoSpeed += 0.1;
                }
                else
                {
                    videoSpeed += 0.02;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                videoPlaying = !videoPlaying;
            }
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarPos = (double)trackBar1.Value / trackBar1.Maximum;
            trackBarModified = true;
        }


        private void toolStripMenuItemFps_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("最大FPSを入力");
            if (s != "")
            {
                double r;
                if (Double.TryParse(s, out r))
                {
                    maxFps = r;
                    toolStripMenuItemFps.Text = r.ToString();
                    intervalMsMin = (int)(1000 / maxFps);
                }
            }
        }

        private void toolStripMenuItemT1_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 1 を入力");
            if (s != "")
            {
                tags[0] = s;
                toolStripMenuItemT1.Text = s;
            }
        }

        private void toolStripMenuItemT2_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 2 を入力");
            if (s != "")
            {
                tags[1] = s;
                toolStripMenuItemT2.Text = s;
            }
        }

        private void toolStripMenuItemT3_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 3 を入力");
            if (s != "")
            {
                tags[2] = s;
                toolStripMenuItemT3.Text = s;
            }
        }

        private void toolStripMenuItemT4_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 4 を入力");
            if (s != "")
            {
                tags[3] = s;
                toolStripMenuItemT4.Text = s;
            }
        }

        private void toolStripMenuItemT5_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 5 を入力");
            if (s != "")
            {
                tags[4] = s;
                toolStripMenuItemT5.Text = s;
            }
        }

        private void toolStripMenuItemT6_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 6 を入力");
            if (s != "")
            {
                tags[5] = s;
                toolStripMenuItemT6.Text = s;
            }
        }

        private void toolStripMenuItemT7_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 7 を入力");
            if (s != "")
            {
                tags[6] = s;
                toolStripMenuItemT7.Text = s;
            }
        }

        private void toolStripMenuItemT8_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 8 を入力");
            if (s != "")
            {
                tags[7] = s;
                toolStripMenuItemT8.Text = s;
            }
        }

        private void toolStripMenuItemT9_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("タグ 9 を入力");
            if (s != "")
            {
                tags[8] = s;
                toolStripMenuItemT9.Text = s;
            }
        }


        // 動画固有の設定を保存する
        private void button1_Click(object sender, EventArgs e)
        {
            // 保存
            using (StreamWriter sw = new StreamWriter(videoSettingFile, false, Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(tags[0]);
                sw.WriteLine(tags[1]);
                sw.WriteLine(tags[2]);
                sw.WriteLine(tags[3]);
                sw.WriteLine(tags[4]);
                sw.WriteLine(tags[5]);
                sw.WriteLine(tags[6]);
                sw.WriteLine(tags[7]);
                sw.WriteLine(tags[8]);
                foreach (KeyValuePair<int, string> pair in timeKeys)
                {
                    sw.WriteLine((((double)pair.Key) / 1000).ToString() + "/" + pair.Value);
                }
            }
            trackBar1.Focus();
        }


        // 動画固有の設定を読む(読み直しの意味合い)
        private void button2_Click(object sender, EventArgs e)
        {
            // 読出
            readVideoSettings();
            trackBar1.Focus();
        }


        // 動画固有の設定やタグを読む
        private void readVideoSettings()
        {
            readSettings();
            timeKeys.Clear();
            if (File.Exists(videoSettingFile))
            {
                using (StreamReader sr = new StreamReader(videoSettingFile, Encoding.GetEncoding("utf-8")))
                {
                    tags[0] = sr.ReadLine();
                    tags[1] = sr.ReadLine();
                    tags[2] = sr.ReadLine();
                    tags[3] = sr.ReadLine();
                    tags[4] = sr.ReadLine();
                    tags[5] = sr.ReadLine();
                    tags[6] = sr.ReadLine();
                    tags[7] = sr.ReadLine();
                    tags[8] = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string aLine = sr.ReadLine();
                        string[] kv = aLine.Split(new char[] { '/' }, 2);
                        if (kv.Length == 2)
                        {
                            timeKeys.Add((int)(double.Parse(kv[0]) * 1000), kv[1]);
                        }
                    }
                }
            }
            else
            {
                timeKeys.Clear();
            }
            setTagsMenu();
            listBox1.Items.Clear();
            foreach (KeyValuePair<int, string> pair in timeKeys)
            {
                listBox1.Items.Add((((double)pair.Key) / 1000).ToString() + "/" + pair.Value);
            }
        }


        // クリックしたらそのフレームに飛ぶ
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox1.SelectedIndex >= 0)
            {
                string[] kv = ((string)listBox1.Items[listBox1.SelectedIndex]).Split(new char[] { '/' }, 2);
                positionMs = (int)Math.Round(double.Parse(kv[0]) * 1000);
                positionMsModified = true;
            }
        }


        // DELキーでタグ付け削除
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listBox1.Items.Count > 0 && listBox1.SelectedIndex >= 0)
                {
                    string[] kv = ((string)listBox1.Items[listBox1.SelectedIndex]).Split(new char[] { '/' }, 2);
                    if (kv.Length == 2)
                    {
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        int k = (int)Math.Round(double.Parse(kv[0]) * 1000);
                        timeKeys.Remove(k);
                    }
                }
            }
        }
    }
}

