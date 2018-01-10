using Newtonsoft.Json;
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
    public partial class FormUnitSet : Form
    {
        private Utilities Utility;
        public FormUnitSet()
        {
            InitializeComponent();
            Utility = new Utilities();            
            string units = Utility.TxtRead(Application.StartupPath + "\\ConfigUnit.txt");
            List<Entity.DTO.DTO_Unit> lists = JsonConvert.DeserializeObject<List<Entity.DTO.DTO_Unit>>(units);
            if (lists == null)
                lists = new List<Entity.DTO.DTO_Unit>();
            dataGridViewUnit.DataSource = lists;
        }

        private void ToolStripMenuItem_AddNew_Click(object sender, EventArgs e)
        {
            string units = Utility.TxtRead(Application.StartupPath + "\\ConfigUnit.txt");
            List<Entity.DTO.DTO_Unit> lists = JsonConvert.DeserializeObject<List<Entity.DTO.DTO_Unit>>(units);
            if (lists == null)
                lists = new List<Entity.DTO.DTO_Unit>();
            Entity.DTO.DTO_Unit row = new Entity.DTO.DTO_Unit();
            row.ClassId = "Count";
            lists.Add(row);
            dataGridViewUnit.DataSource = lists;
        }

        private void ToolStripMenuItem_Save_Click(object sender, EventArgs e)
        {
            List<Entity.DTO.DTO_Unit> lists = (List<Entity.DTO.DTO_Unit>)dataGridViewUnit.DataSource;
            string contents = JsonConvert.SerializeObject(lists);
            Utility.TxtWrite(Application.StartupPath + "\\ConfigUnit.txt", contents);
            MessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItem_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string units = Utility.TxtRead(Application.StartupPath + "\\ConfigUnit.txt");
                List<Entity.DTO.DTO_Unit> lists = JsonConvert.DeserializeObject<List<Entity.DTO.DTO_Unit>>(units);
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
                Utility.TxtWrite(Application.StartupPath + "\\ConfigUnit.txt", contents);
                dataGridViewUnit.DataSource = newLists;
            }
        }
        
    }
}
