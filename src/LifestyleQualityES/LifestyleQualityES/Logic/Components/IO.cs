using System.Text.Json;
using System.Windows.Forms;
using System.IO;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System;

namespace LifestyleQualityES.Model
{
    internal static class IO
    {
        public static (KnowledgeBase, string) LoadFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ES Files(*.es)|*.es|All files(*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                var reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                var serializer = new DataContractSerializer(typeof(KnowledgeBase));
                KnowledgeBase knowledgeBase = (KnowledgeBase)serializer.ReadObject(reader, true);
                reader.Close();
                fs.Close();
                return (knowledgeBase, fileName);
            }
            else return (null, null);
        }

        public static void ReWriteFile(string fileName, KnowledgeBase knowledgeBase)
        {
            using FileStream writeStream = File.Create(fileName);
            var a = new DataContractSerializerSettings { PreserveObjectReferences = true };
            var serializer = new DataContractSerializer(typeof(KnowledgeBase), a);
            serializer.WriteObject(writeStream, knowledgeBase);
            writeStream.Close();
        }

        public static string SaveNewFile(KnowledgeBase knowledgeBase)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ES Files(*.es)|*.es|All files(*.*)|*.*";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string fileName = saveFileDialog.FileName;
                using FileStream writeStream = File.Create(fileName);
                var a = new DataContractSerializerSettings { PreserveObjectReferences = true };
                var serializer = new DataContractSerializer(typeof(KnowledgeBase), a);
                serializer.WriteObject(writeStream, knowledgeBase);
                writeStream.Close();
                return fileName;
            }
            return null;
        }
    }
}
