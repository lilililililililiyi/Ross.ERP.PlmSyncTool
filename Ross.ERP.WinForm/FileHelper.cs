using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ross.ERP.PlmSyncTool
{
    public class FileHelper
    {
        /// <summary>
        /// 文件是否存在
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool IsExist(string filePath)
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool CreateFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    File.Create(filePath).Close();
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="FilePathName"></param>
        /// <returns></returns>
        public static bool DeleteFile(string FilePathName)
        {
            try
            {
                FileInfo DeleFile = new FileInfo(FilePathName);
                if (DeleFile.Exists)
                {
                    DeleFile.Delete();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="dirPath"></param>
        public static void CreateDir(string dirPath, string activeDir = "")
        {
            if (!Directory.Exists(activeDir + dirPath))
            {
                if (activeDir == "")
                {
                    Directory.CreateDirectory(dirPath);
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(activeDir);
                    di.CreateSubdirectory(dirPath);
                }
            }
        }

        /// <summary>
        /// 获取文件类型
        /// </summary>
        /// <param name="fileurl"></param>
        /// <returns></returns>
        public static string GetFileType(string fileurl)
        {
            if (fileurl != null)
            {
                FileInfo file = new FileInfo(fileurl);
                if (file.Exists)
                {
                    return file.Extension.Replace('.', ' ').Trim();
                }
                else
                    return "";
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 获取文件名
        /// </summary>
        /// <param name="fileurl"></param>
        /// <returns></returns>
        public static string GetFileName(string fileurl)
        {
            if (fileurl != null)
            {
                FileInfo file = new FileInfo(fileurl);
                if (file.Exists)
                {
                    return file.Name;
                }
                else
                    return "";
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="fileurl"></param>
        /// <returns></returns>
        public static long GetFileSize(string fileurl)
        {
            if (fileurl != null)
            {
                FileInfo file = new FileInfo(fileurl);
                if (file.Exists)
                {
                    long filesize = file.Length / 1024;
                    return filesize;
                }
                else
                    return 0;
            }
            else
            {
                return 0;
            }
        }
    }
}
