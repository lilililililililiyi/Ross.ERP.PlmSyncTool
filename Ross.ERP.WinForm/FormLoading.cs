using Ross.ERP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
{
    public partial class FormLoading : Form
    {
        private Task[] tasks;
        private bool isMouseDown = false;
        private Point FormLocation;
        private Point mouseOffset;
        private bool taskCompleted = false;
        public FormLoading(string ERPConn, string PLMConn)
        {
            InitializeComponent();
            LoadDatas(ERPConn, PLMConn);
        }

        public void LoadDatas(string ERPConn, string PLMConn)
        {
            progressBarLoad.Value = 0;
            progressBarLoad.Maximum = 100;
            timerLoad.Enabled = true;
            timerLoad.Interval = 1000;

            tasks = new Task[9];
            BasicDatas BscData = new BasicDatas(ERPConn, PLMConn);
            tasks[0] = Task.Run(() =>
            {
                BscData.LoadERPPart();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "ERP_PART数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
            tasks[1] = Task.Run(() =>
            {
                BscData.LoadERPPartMtl();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "ERP_PART_MTL数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
            tasks[2] = Task.Run(() =>
            {
                BscData.LoadPLM_MPART();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "PLM_MPART数据加载完毕";
                    progressBarLoad.Value += 20;
                }));
            });
            tasks[3] = Task.Run(() =>
            {
                BscData.LoadPLM_MBOM();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "PLM_MBOM数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
            tasks[4] = Task.Run(() =>
            {
                BscData.LoadPLM_CONS();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "PLM_CONS数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
            tasks[5] = Task.Run(() =>
            {
                BscData.LoadPLM_CONS_OBJOF();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "PLM_CONS_OBJOF数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
            tasks[6] = Task.Run(() =>
            {
                BscData.LoadPLM_MATERIAL();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "PLM_MATERIAL数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
            tasks[7] = Task.Run(() =>
            {
                BscData.LoadPLM_PRODUCT();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "PLM_PRODUCT数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
            tasks[8] = Task.Run(() =>
            {
                BscData.LoadPLM_MTL();
                this.BeginInvoke(new Action(() =>
                {
                    labelStatus.Text = "PLM_MTL数据加载完毕";
                    progressBarLoad.Value += 10;
                }));
            });
        }

        private void FormLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!tasks[i].IsCompleted)
                {
                    taskCompleted = false;
                    break;
                }
                else
                    taskCompleted = true;
            }
            if (!taskCompleted)
            {
                MessageBox.Show("数据正在加载，不能关闭！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!tasks[i].IsCompleted)
                {
                    taskCompleted = false;
                    break;
                }
                else
                    taskCompleted = true;
            }

            if (taskCompleted)
            {
                labelStatus.Text = "数据加载完毕";
                progressBarLoad.Value = 100;
                this.Close();
            }
        }

        private void FormLoading_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void FormLoading_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }

        private void FormLoading_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
