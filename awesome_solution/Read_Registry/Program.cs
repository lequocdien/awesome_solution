//*****************************************************************************
// Đọc Registy để lấy đừng dẫn phần mềm cài trong ổ C
//*****************************************************************************
using Microsoft.Win32;
using System;
using System.Security.AccessControl;

namespace Read_Registry
{
    class Program
    {
        private const string ROOT_FOLDER_NODE = "Version";
        private const string ROOT_FOLDER_PATH = @"SOFTWARE\dotnet\Setup\InstalledVersions\x64\sharedhost";

        static void Main(string[] args)
        {
            Console.WriteLine(ReadRegistry(RegistryView.Registry64, ROOT_FOLDER_NODE, ROOT_FOLDER_PATH));
            Console.ReadLine();
        }

        private static string ReadRegistry(RegistryView x_objRegistryView, string x_strNode, string x_strRegPath)
        {
            string strResult = string.Empty;
            if (string.IsNullOrWhiteSpace(x_strNode) || string.IsNullOrWhiteSpace(x_strRegPath))
            {
                return strResult;
            }
            //Read from registry
            try
            {
                RegistryKey objRegKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, x_objRegistryView);
                objRegKey = objRegKey.OpenSubKey(x_strRegPath, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.ReadKey);
                if (objRegKey != null)
                {
                    strResult = (string)objRegKey.GetValue(x_strNode);
                    objRegKey.Close();
                }
            }
            catch
            {
                strResult = string.Empty;
            }
            return strResult;
        }

        public static string ReadRootFolder()
        {
            string strNode = ROOT_FOLDER_NODE;
            string strRegPath = ROOT_FOLDER_PATH;
            string strResult = ReadRegistry(RegistryView.Registry64, strNode, strRegPath);
            if (string.IsNullOrEmpty(strResult) == true)
            {
                strResult = ReadRegistry(RegistryView.Registry32, strNode, strRegPath);
            }
            return strResult;
        }
    }
}
