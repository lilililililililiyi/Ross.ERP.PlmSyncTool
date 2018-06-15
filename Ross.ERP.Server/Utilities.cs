using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

namespace Ross.ERP.Server
{
    public class Utilities
    {
        public void TxtWrite(string path, string contents)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(contents);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public string TxtRead(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            StringBuilder sb = new StringBuilder();
            while (!sr.EndOfStream)
            {
                sb.AppendLine(sr.ReadLine());
            }
            return sb.ToString();
        }

        public Entity.DTO.DTO_Config GetSysCfg()
        {
            string Cfg = TxtRead(Application.StartupPath + "\\Config.txt");
            return JsonConvert.DeserializeObject<Entity.DTO.DTO_Config>(Cfg);
        }
        public DataTable ListToDataTable<T>(List<T> items, string oldRpChar = "", string newRpChar = "")
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                if (!string.IsNullOrEmpty(oldRpChar) && !string.IsNullOrEmpty(newRpChar))
                {
                    tb.Columns.Add(prop.Name.Replace(oldRpChar, newRpChar), t);
                }
                else
                    tb.Columns.Add(prop.Name, t);
            }

            foreach (T item in items)
            {
                var values = new object[props.Length];

                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }
        public Type GetCoreType(Type t)
        {
            if (t != null && IsNullable(t))
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }
        public bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
        public string ExportExcel(DataTable dt, string filePath, string fileName = "")
        {
            if (string.IsNullOrEmpty(filePath)) return null;
            try
            {
                //创建Excel文件的对象  
                NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();

                NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("Sheet1");
                NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    row1.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        rowtemp.CreateCell(j).SetCellValue(dt.Rows[i][j].ToString().Trim());
                    }
                }
                // 写入到客户端   
                //MemoryStream ms = new MemoryStream();
                //book.Write(ms);
                //ms.Seek(0, SeekOrigin.Begin);

                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                book.Write(fs);
                fs.Dispose();
                book = null;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filePath;
        }

        public static bool CheckNonStock(string PartNum)
        {
            try
            {
                if (PartNum.StartsWith("13") || PartNum.StartsWith("14"))
                {
                    return false;
                }
                else
                {
                    return Entity.BasicDatas.StockPart.Where(o => o.PartNum == PartNum).Count() <= 0;
                }
            }
            catch
            {
                return true;
            }
        }
    }
}
