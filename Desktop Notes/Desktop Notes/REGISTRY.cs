using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public static class REGISTRY
    {
        // 数据存储目录：%AppData%\Desktop_Notes\
        private static readonly string DATA_DIR = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Desktop_Notes");

        private static readonly string NOTES_DIR = Path.Combine(DATA_DIR, "notes");
        private const string DEFAULT_SETTINGS_FILE = "_DefaultSettings.json";

        // 旧版注册表路径（用于迁移存量用户数据）
        private const string OLD_REG_PATH = @"Software\Sand Soft\Desktop Notes";

        static REGISTRY()
        {
            // 确保数据目录存在
            if (!Directory.Exists(DATA_DIR))
                Directory.CreateDirectory(DATA_DIR);
            if (!Directory.Exists(NOTES_DIR))
                Directory.CreateDirectory(NOTES_DIR);

            // 检测并迁移存量用户的注册表数据
            MigrateFromRegistry();
        }

        #region 注册表数据迁移

        /// <summary>
        /// 检测注册表中是否有旧版数据，如果有则迁移到文件存储
        /// </summary>
        private static void MigrateFromRegistry()
        {
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey(OLD_REG_PATH, true);
                if (regKey == null) return;

                string[] valueNames = regKey.GetValueNames();
                if (valueNames.Length == 0)
                {
                    regKey.Close();
                    return;
                }

                bool hasMigratedData = false;

                foreach (string name in valueNames)
                {
                    try
                    {
                        object val = regKey.GetValue(name, null);
                        if (val == null) continue;
                        string json = (string)val;

                        if (name == "_DefaultSettings")
                        {
                            // 迁移默认设置
                            string settingsPath = Path.Combine(DATA_DIR, DEFAULT_SETTINGS_FILE);
                            if (!File.Exists(settingsPath))
                            {
                                File.WriteAllText(settingsPath, json);
                                hasMigratedData = true;
                            }
                        }
                        else if (!name.StartsWith("_"))
                        {
                            // 迁移便签数据
                            string notePath = Path.Combine(NOTES_DIR, name + ".json");
                            if (!File.Exists(notePath))
                            {
                                File.WriteAllText(notePath, json);
                                hasMigratedData = true;
                            }
                        }
                    }
                    catch { }
                }

                // 迁移成功后清理注册表中的旧数据
                if (hasMigratedData)
                {
                    foreach (string name in valueNames)
                    {
                        try { regKey.DeleteValue(name, false); }
                        catch { }
                    }
                }

                regKey.Close();

                // 尝试清理空的注册表键
                try
                {
                    RegistryKey parentKey = Registry.CurrentUser.OpenSubKey(@"Software\Sand Soft", true);
                    if (parentKey != null)
                    {
                        RegistryKey check = parentKey.OpenSubKey("Desktop Notes");
                        if (check != null && check.GetValueNames().Length == 0 && check.SubKeyCount == 0)
                        {
                            check.Close();
                            parentKey.DeleteSubKey("Desktop Notes", false);
                        }
                        else if (check != null)
                        {
                            check.Close();
                        }
                        parentKey.Close();
                    }
                }
                catch { }
            }
            catch { }
        }

        #endregion

        #region 便签数据存储（文件）

        public static string[] OPENED_NOTES
        {
            get
            {
                List<string> notes = new List<string>();
                if (!Directory.Exists(NOTES_DIR)) return notes.ToArray();

                foreach (string file in Directory.GetFiles(NOTES_DIR, "*.json"))
                {
                    string name = Path.GetFileNameWithoutExtension(file);
                    notes.Add(name);
                }
                return notes.ToArray();
            }
        }

        public static void SetData(string id, FormData data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                string path = Path.Combine(NOTES_DIR, id + ".json");
                File.WriteAllText(path, json);
            }
            catch { }
        }

        public static FormData GetData(string id)
        {
            try
            {
                string path = Path.Combine(NOTES_DIR, id + ".json");
                if (!File.Exists(path)) return null;
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<FormData>(json);
            }
            catch { return null; }
        }

        public static void Delete(string id)
        {
            try
            {
                string path = Path.Combine(NOTES_DIR, id + ".json");
                if (File.Exists(path)) File.Delete(path);
            }
            catch { }
        }

        public static void DeleteAll()
        {
            try
            {
                if (!Directory.Exists(NOTES_DIR)) return;
                foreach (string file in Directory.GetFiles(NOTES_DIR, "*.json"))
                {
                    File.Delete(file);
                }
            }
            catch { }
        }

        #endregion

        #region 默认便签设置（文件）

        public static void SaveDefaultSettings(DefaultNoteSettings settings)
        {
            try
            {
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                string path = Path.Combine(DATA_DIR, DEFAULT_SETTINGS_FILE);
                File.WriteAllText(path, json);
            }
            catch { }
        }

        public static DefaultNoteSettings GetDefaultSettings()
        {
            try
            {
                string path = Path.Combine(DATA_DIR, DEFAULT_SETTINGS_FILE);
                if (!File.Exists(path)) return new DefaultNoteSettings();
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<DefaultNoteSettings>(json);
            }
            catch
            {
                return new DefaultNoteSettings();
            }
        }

        #endregion

        #region 系统设置（仍使用注册表）

        public static RegistryKey START_KEY = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public static bool StartWithWindows
        {
            get
            {
                object obj = START_KEY.GetValue("Desktop Notes", null);
                if (obj == null) return false;
                return true;
            }
            set
            {
                if (value) { START_KEY.SetValue("Desktop Notes", Application.ExecutablePath); }
                else
                {
                    try { START_KEY.DeleteValue("Desktop Notes", false); }
                    catch { }
                }
            }
        }

        public static bool FirstRun
        {
            get
            {
                object obj = START_KEY.GetValue("First Run", null);
                if (obj == null) return true;
                START_KEY.SetValue("First Run", 0);
                return false;
            }
        }

        #endregion
    }
}
