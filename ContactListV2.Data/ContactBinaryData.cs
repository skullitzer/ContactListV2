using ContactListV2.Business;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListV2.Data
{
    public static class ContactBinaryData
    {
        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"\Contacts.bin";
        }

        public static List<Contact> Load()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
                return new List<Contact>();

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var bf = new BinaryFormatter();
                return (List<Contact>)bf.Deserialize(stream);
            }
        }

        public static void Save(List<Contact> list)
        {
            string filePath = GetFilePath();
            using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(stream, list);
                stream.Close();
            }
        }
    }
}
