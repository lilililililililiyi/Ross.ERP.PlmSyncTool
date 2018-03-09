using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ross.ERP.PlmSyncTool
{
    public class Utilities
    {
        public Entity.DTO.DTO_Config GetSysCfg()
        {
            string Cfg = TxtRead(Application.StartupPath + "\\Config.txt");
            return JsonConvert.DeserializeObject<Entity.DTO.DTO_Config>(Cfg);
        }
        public string ExportExcel(DataTable dt, string filePath, string fileName = "")
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = GetSaveFilePath(fileName);
            }
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
                Log(err);
                MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filePath;
        }

        public string ExportExcel(DataTable[] dts, string[] sheetNames, string filePath, string fileName = "")
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = GetSaveFilePath(fileName);
            }
            if (string.IsNullOrEmpty(filePath)) return null;
            //创建Excel文件的对象  
            NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();

            for (int k = 0; k < dts.Length; k++)
            {
                DataTable dt = dts[k];
                NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet(sheetNames[k]);
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
            }

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            book.Write(fs);
            fs.Dispose();
            book = null;

            return filePath;
        }

        private static string GetSaveFilePath(string fileName = "")
        {
            SaveFileDialog saveFileDig = new SaveFileDialog();
            saveFileDig.Filter = "Excel Office97-2003(*.xls)|.xls|Excel Office2007及以上(*.xlsx)|*.xlsx";
            saveFileDig.FilterIndex = 0;
            saveFileDig.OverwritePrompt = true;
            saveFileDig.InitialDirectory = "D:\\PLMExportData\\";
            saveFileDig.FileName = fileName; //默认文件名
            string filePath = null;
            if (saveFileDig.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDig.FileName;
            }

            return filePath;
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

        public DataTable DgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换  
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行  
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
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

        public static T MapTo<T>(object type)
        {
            string jsonText = JsonConvert.SerializeObject(type);
            T obj = JsonConvert.DeserializeObject<T>(jsonText);
            return obj;
        }

        public bool CompareObj(object objA, object objB)
        {
            bool result = object.ReferenceEquals(objA, objB);
            return result;
        }

        public bool CompareType<T>(T objA, T objB)
        {
            #region
            bool result = true;
            Type typeOne = objA.GetType();
            Type typeTwo = objB.GetType();
            if (!typeOne.Equals(typeTwo)) { return false; }
            PropertyInfo[] pisOne = typeOne.GetProperties();
            PropertyInfo[] pisTwo = typeTwo.GetProperties();
            //如果长度为0返回false
            if (pisOne.Length <= 0 || pisTwo.Length <= 0)
            {
                return false;
            }
            //如果长度不一样，返回false
            if (!(pisOne.Length.Equals(pisTwo.Length))) { return false; }
            //遍历两个T类型，遍历属性，并作比较
            for (int i = 0; i < pisOne.Length; i++)
            {
                //获取属性名
                string oneName = pisOne[i].Name;
                string twoName = pisTwo[i].Name;
                //获取属性的值
                object oneValue = pisOne[i].GetValue(objA, null);
                object twoValue = pisTwo[i].GetValue(objB, null);
                //比较,只比较值类型
                if ((pisOne[i].PropertyType.IsValueType || pisOne[i].PropertyType.Name.StartsWith("String")) && (pisTwo
[i].PropertyType.IsValueType || pisTwo[i].PropertyType.Name.StartsWith("String")))
                {
                    if (oneName.Equals(twoName))
                    {
                        if (oneValue == null)
                        {
                            if (twoValue != null)
                            {
                                result = false;
                                break; //如果有不一样的就退出循环
                            }
                        }
                        else if (oneValue != null)
                        {
                            if (twoValue != null)
                            {
                                if (!oneValue.Equals(twoValue))
                                {
                                    result = false;
                                    break; //如果有不一样的就退出循环
                                }
                            }
                            else if (twoValue == null)
                            {
                                result = false;
                                break; //如果有不一样的就退出循环
                            }
                        }
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    //如果对象中的属性是实体类对象，递归遍历比较
                    bool b = CompareType(oneValue, twoValue);
                    if (!b) { result = b; break; }
                }
            }
            return result;
            #endregion
        }

        public static void Log(string contents)
        {
            contents = DateTime.Now.ToString() + " System Log: " + contents;
            string path = Application.StartupPath + "\\SysLog.txt";
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine(contents);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void Log(Exception error)
        {
            string strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString();
            string contents = string.Format(strDateInfo + " Application UnhandledException:{0};堆栈信息:{1}", error.Message, error.StackTrace);
            string path = Application.StartupPath + "\\SysLog.txt";
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine(contents);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public bool CheckUpdate(string AutoUpdateURL)
        {
            bool result = false;
            try
            {
                string Cfg = TxtRead(AutoUpdateURL + "\\Config.txt");
                var ConfigRemote = JsonConvert.DeserializeObject<Entity.DTO.DTO_Config>(Cfg);
                int VersionRemote = int.Parse(ConfigRemote.Version.Replace(".", ""));
                int VersionLocal = int.Parse(Application.ProductVersion.Replace(".", ""));
                result = VersionRemote > VersionLocal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public static bool CheckNonStock(string PartNum)
        {
            try
            {
                if (PartNum.StartsWith("13") || PartNum.StartsWith("14") || PartNum.StartsWith("16"))
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
