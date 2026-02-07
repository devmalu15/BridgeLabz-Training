using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using BridgeLabsTrainingVS.ScenarioBased.AddressBook;

namespace BridgeLabsTrainingVS.ScenarioBased.AddressBookSystem
{
    public static class FileStore
    {
        private static string GetDataDir()
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AddressBookData");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            return dir;
        }

        private static string FilePathText(string bookName) => Path.Combine(GetDataDir(), $"{bookName}.txt");
        private static string FilePathCsv(string bookName) => Path.Combine(GetDataDir(), $"{bookName}.csv");
        private static string FilePathJson(string bookName) => Path.Combine(GetDataDir(), $"{bookName}.json");

        public static void SaveAllFormats(AddressBook book)
        {
            SaveAsText(book);
            SaveAsCsv(book);
            SaveAsJson(book);
        }

        public static void SaveAsText(AddressBook book)
        {
            var path = FilePathText(book.bookName);
            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine($"Book:{book.bookName}");
                foreach (var c in book.contacts)
                {
                    if (c != null)
                    {
                        // pipe-separated to keep human readable
                        sw.WriteLine($"{c.firstName}|{c.lastName}|{c.address}|{c.city}|{c.state}|{c.zip}|{c.phoneNumber}|{c.eMail}");
                    }
                }
            }
        }

        public static void SaveAsCsv(AddressBook book)
        {
            var path = FilePathCsv(book.bookName);
            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine("FirstName,LastName,Address,City,State,Zip,Phone,Email");
                foreach (var c in book.contacts)
                {
                    if (c != null)
                    {
                        string Escape(string s) => $"\"{s?.Replace("\"", "\"\"")}\"";
                        sw.WriteLine($"{Escape(c.firstName)},{Escape(c.lastName)},{Escape(c.address)},{Escape(c.city)},{Escape(c.state)},{Escape(c.zip)},{Escape(c.phoneNumber)},{Escape(c.eMail)}");
                    }
                }
            }
        }

        public static void SaveAsJson(AddressBook book)
        {
            var path = FilePathJson(book.bookName);
            var dto = new BookDto
            {
                bookName = book.bookName,
                contacts = book.contacts.Where(c => c != null).ToList()
            };
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(path, JsonSerializer.Serialize(dto, options), Encoding.UTF8);
        }

        public static void LoadIfExists(AddressBook book)
        {
            // Prefer JSON when loading (most useful), but methods are available for CSV/TXT as well.
            var jsonPath = FilePathJson(book.bookName);
            if (File.Exists(jsonPath))
            {
                LoadFromJson(book);
                return;
            }

            var csvPath = FilePathCsv(book.bookName);
            if (File.Exists(csvPath))
            {
                LoadFromCsv(book);
                return;
            }

            var txtPath = FilePathText(book.bookName);
            if (File.Exists(txtPath))
            {
                LoadFromText(book);
                return;
            }
        }

        public static void LoadFromJson(AddressBook book)
        {
            var path = FilePathJson(book.bookName);
            if (!File.Exists(path)) return;
            var json = File.ReadAllText(path, Encoding.UTF8);
            try
            {
                var dto = JsonSerializer.Deserialize<BookDto>(json);
                if (dto != null)
                {
                    book.bookName = dto.bookName ?? book.bookName;
                    book.contacts = new Contact[1000];
                    int idx = 0;
                    foreach (var c in dto.contacts)
                    {
                        if (idx >= book.contacts.Length) break;
                        book.contacts[idx++] = c;
                    }
                }
            }
            catch
            {
                // ignore parsing errors
            }
        }

        public static void LoadFromCsv(AddressBook book)
        {
            var path = FilePathCsv(book.bookName);
            if (!File.Exists(path)) return;
            var lines = File.ReadAllLines(path);
            var list = new List<Contact>();
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;
                // Very simple CSV parse that handles quoted values
                var values = ParseCsvLine(line);
                while (values.Count < 8) values.Add(string.Empty);
                list.Add(new Contact(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]));
            }
            book.contacts = new Contact[1000];
            for (int i = 0; i < list.Count && i < book.contacts.Length; i++) book.contacts[i] = list[i];
        }

        public static void LoadFromText(AddressBook book)
        {
            var path = FilePathText(book.bookName);
            if (!File.Exists(path)) return;
            var lines = File.ReadAllLines(path);
            var list = new List<Contact>();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;
                if (line.StartsWith("Book:")) continue;
                var parts = line.Split('|');
                while (parts.Length < 8) Array.Resize(ref parts, 8);
                list.Add(new Contact(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]));
            }
            book.contacts = new Contact[1000];
            for (int i = 0; i < list.Count && i < book.contacts.Length; i++) book.contacts[i] = list[i];
        }

        public static void DeleteBookFiles(string bookName)
        {
            TryDelete(FilePathJson(bookName));
            TryDelete(FilePathCsv(bookName));
            TryDelete(FilePathText(bookName));
        }

        private static void TryDelete(string path)
        {
            try { if (File.Exists(path)) File.Delete(path); } catch { }
        }

        private static List<string> ParseCsvLine(string line)
        {
            var res = new List<string>();
            var cur = new StringBuilder();
            bool inQuotes = false;
            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];
                if (ch == '"' && (i == 0 || line[i - 1] != '\\'))
                {
                    inQuotes = !inQuotes;
                    continue;
                }
                if (ch == ',' && !inQuotes)
                {
                    res.Add(cur.ToString().Replace("\"\"", "\""));
                    cur.Clear();
                }
                else
                {
                    cur.Append(ch);
                }
            }
            res.Add(cur.ToString().Replace("\"\"", "\""));
            return res;
        }

        private class BookDto
        {
            public string bookName { get; set; }
            public List<Contact> contacts { get; set; } = new List<Contact>();
        }
    }
}