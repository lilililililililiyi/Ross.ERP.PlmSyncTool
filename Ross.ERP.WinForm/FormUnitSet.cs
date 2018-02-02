using Newtonsoft.Json;
using Ross.ERP.Entity;
using Ross.ERP.Entity.RossLive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
{
    public partial class FormUnitSet : Form
    {
        private RossLiveRespository RLD;
        private RossConfig RossCfg;
        public FormUnitSet()
        {
            InitializeComponent();
            RLD = new RossLiveRespository();
            RossCfg = RLD.GetRossCfg();

            List<Entity.DTO.DTO_Unit> lists = JsonConvert.DeserializeObject<List<Entity.DTO.DTO_Unit>>(RossCfg.Units);
            if (lists == null)
                lists = new List<Entity.DTO.DTO_Unit>();
            dataGridViewUnit.DataSource = lists;
        }

        private void ToolStripMenuItem_AddNew_Click(object sender, EventArgs e)
        {
            List<Entity.DTO.DTO_Unit> lists = JsonConvert.DeserializeObject<List<Entity.DTO.DTO_Unit>>(RossCfg.Units);
            if (lists == null)
                lists = new List<Entity.DTO.DTO_Unit>();
            Entity.DTO.DTO_Unit row = new Entity.DTO.DTO_Unit();
            row.ClassId = "Count";
            lists.Add(row);
            dataGridViewUnit.DataSource = lists;
            dataGridViewUnit.CurrentCell = dataGridViewUnit.Rows[dataGridViewUnit.Rows.Count - 1].Cells[0];
        }

        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            List<Entity.DTO.DTO_Unit> lists = (List<Entity.DTO.DTO_Unit>)dataGridViewUnit.DataSource;
            string contents = JsonConvert.SerializeObject(lists);
            RossCfg.Units = contents;
            string result = RLD.UpdateRossCfg(RossCfg);
            if (result == null)
                MessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(result, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ToolStripMenuItem_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<Entity.DTO.DTO_Unit> lists = JsonConvert.DeserializeObject<List<Entity.DTO.DTO_Unit>>(RossCfg.Units);
                string[] delItem = new string[dataGridViewUnit.SelectedRows.Count];
                for (int i = this.dataGridViewUnit.SelectedRows.Count; i > 0; i--)
                {
                    string name = dataGridViewUnit.SelectedRows[i - 1].Cells["Name"].Value.ToString();
                    delItem[i - 1] = name;
                }
                List<Entity.DTO.DTO_Unit> newLists = new List<Entity.DTO.DTO_Unit>();
                foreach (var item in lists)
                {
                    if (!delItem.Contains(item.Name))
                    {
                        newLists.Add(item);
                    }
                }
                string contents = JsonConvert.SerializeObject(newLists);
                RossCfg.Units = contents;
                RLD.UpdateRossCfg(RossCfg);
                dataGridViewUnit.DataSource = newLists;
            }
        }

    }
}
