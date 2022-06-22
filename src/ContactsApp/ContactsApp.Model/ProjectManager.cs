using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public static class ProjectManager
    {
        /// <summary>
        /// Название файла.
        /// </summary>
        private const string _fileName = "ContactsApp.notes";

        /// <summary>
        /// Папка.
        /// </summary>
        private static readonly string _folder = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\DNA\\ContactsApp\\";

        /// <summary>
        /// Путь сохранения файла.
        /// </summary>
        private static readonly string _path = _folder + _fileName;

        /// <summary>
        /// Путь по умолчанию.
        /// </summary>
        public static string DefaultPath { get; set; } = _path;

        /// <summary>
        /// Сохранение файла.
        /// </summary>
        /// <param name="data"></param>
        public static void SaveToFile(Project data)
        {
            if (!File.Exists(DefaultPath))
            {
                CreatePath(_folder, _fileName);
            }
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (var sw = new StreamWriter(DefaultPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Загрузка файла.
        /// </summary>
        /// <returns></returns>
        public static Project LoadFromFile()
        {
            var serializer = new JsonSerializer();
            try
            {
                using (var sr = new StreamReader(DefaultPath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    Project project = (Project)serializer.Deserialize<Project>(reader);
                    if (project == null)
                    {
                        return new Project();
                    }

                    return project;
                }
            }
            catch
            {
                return new Project();
            }
        }
        /// <summary>
        /// Создает файл.
        /// </summary>
        /// <param name="folder">Расположение папки</param>
        /// <param name="fileName">Название файла</param>
        public static void CreatePath(string folder, string fileName)
        {
            if (folder == null)
            {
                folder = _folder;
            }
            if (fileName == null)
            {
                fileName = _fileName;
            }
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(folder + fileName))
            {
                File.Create(folder + fileName).Close();
            }

            DefaultPath = folder + fileName;
        }
    }
}
