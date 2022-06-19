using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        ZipArchiveEntry[] mas;
        char l = char.Parse(@"\");
        public static string dir = @"C:\Users\N0rdye\Desktop\Game.zip";
        bool ext = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void read()
        {
            try
            {
                using (var fileStream = System.IO.File.Open(dir, System.IO.FileMode.Open))
                {
                    var archive = new ZipArchive(fileStream);
                    mas = archive.Entries.ToArray();
                    load();
                }
            }
            catch (ArgumentNullException)
            {

            }
        }

        void load()
        {
            listView2.Clear();
            listView1.Clear();
            listView2.Items.Add("/");
            foreach (var c in mas)
            {
                if (c.FullName.ToCharArray()[c.FullName.ToCharArray().Length - 1] == '/')
                {
                    listView2.Items.Add(c.FullName);
                }
                else if (c.FullName.ToCharArray()[c.FullName.ToCharArray().Length - 1] != '/')
                {
                    if (c.FullName.Split('/').Length<2)
                    {
                        listView1.Items.Add(c.Name);
                    }
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (dir != null) { ActiveForm.Text = "загрузка"; }
            read();
            if (dir != null) { ActiveForm.Text = dir.Split(l)[dir.Split(l).Length - 1]; }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            loadfiles();
        }

        void loadfiles()
        {
            try
            {
                listView1.Clear();
                if (listView2.SelectedItems[0].Text != "/")
                {
                    try { питьToolStripMenuItem.Text = listView2.SelectedItems[0].Text; } catch { }
                    string path = питьToolStripMenuItem.Text;
                    foreach (var c in mas)
                    {
                        if (c.FullName.ToCharArray()[c.FullName.ToCharArray().Length - 1] != '/')
                        {
                            if (c.FullName.Split('/').Length > 1 && c.FullName.Split('/')[c.FullName.Split('/').Length - 2].Contains(path.Split('/')[path.Split('/').Length - 2]))
                            {
                                listView1.Items.Add(c.Name);

                                if (c.FullName.Split('/').Length > 2 && c.FullName.Split('/')[c.FullName.Split('/').Length - 3].Contains(path.Split('/')[path.Split('/').Length - 3]))
                                {
                                    listView1.Items.RemoveAt(listView1.Items.Count - 1);
                                    listView1.Items.Add(c.Name);
                                }
                            }
                        }
                    }
                }
                else
                {
                    try { питьToolStripMenuItem.Text = ""; } catch { }
                    string path = питьToolStripMenuItem.Text;
                    foreach (var c in mas)
                    {
                        if (c.FullName.ToCharArray()[c.FullName.ToCharArray().Length - 1] != '/')
                        {
                            if (c.FullName.Split('/')[c.FullName.Split('/').Length - 1].Contains(path.Split('/')[path.Split('/').Length - 1]))
                            {
                                if (c.FullName.Split('/').Length < 2)
                                {
                                    listView1.Items.Add(c.Name);
                                }
                            }
                        }
                    }
                }
                string j2 = "";
                int i = 0;
                foreach (ListViewItem j in listView1.Items)
                {
                    if (j2 == j.ToString())
                    {
                        listView1.Items.Remove(j);
                    }
                    else
                    {
                        j2 = j.ToString();
                    }
                    i++;
                }
            }
            catch { }
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void распаковатьВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            состояниеToolStripMenuItem1.Text = "выполняется";
            folderBrowserDialog1.ShowDialog();
            ZipFile.ExtractToDirectory(dir,folderBrowserDialog1.SelectedPath);
            состояниеToolStripMenuItem1.Text = "готово";
        }

        private void архивироватьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            состояниеToolStripMenuItem1.Text = "выполняется";
            folderBrowserDialog1.ShowDialog();
            string s1 = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.ShowDialog();
            string s2 = folderBrowserDialog1.SelectedPath;
            ZipFile.CreateFromDirectory(s1, s2);
            состояниеToolStripMenuItem1.Text = "готово";
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (ext)
            {
                e.Effect = DragDropEffects.Copy;
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                vs = files;
                int j = 0;
                foreach (var i in files)
                {
                    string[] g = files[j].Split(l);
                    if (g[g.Length - 1].Split('.').Length > 1)
                    {
                        listView1.Items.Add(g[g.Length - 1]);
                    }
                    j++;
                }
            }
        }
            string[] vs;

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            add();
        }

        private void listView1_DragLeave(object sender, EventArgs e)
        {
            if (ext)
            {
                foreach (var i in vs)
                {
                    listView1.Items.RemoveAt(listView1.Items.Count - 1);
                }
            }
        }

        void add()
        {
            состояниеToolStripMenuItem1.Text = "выполняется";
            int j = 0;
            using (ZipArchive archive = ZipFile.Open(dir, ZipArchiveMode.Update))
            {
                foreach (var i in vs)
                {
                    string[] g = i.Split(l);
                    archive.CreateEntryFromFile(vs[j], питьToolStripMenuItem.Text + g[g.Length - 1]);
                    mas = archive.Entries.ToArray();
                    j++;
                }
            }
            listView1.Clear();
            read();
            состояниеToolStripMenuItem1.Text = "готово";
        }

        void extfile()
        {
            using (ZipArchive archive = ZipFile.OpenRead(dir))
            {
                string[] d = new string[listView1.SelectedIndices.Count];
                Directory.CreateDirectory(@"C:\Users\N0rdye\Documents\data&temp");
                int j = 0;
                foreach (ListViewItem h in listView1.SelectedItems)
                {
                    d[j] = @"C:\Users\N0rdye\Documents\data&temp\" + h.Text;
                    j++;
                }
                foreach (ListViewItem h in listView1.SelectedItems)
                {
                    ZipArchiveEntry entry = archive.GetEntry(питьToolStripMenuItem.Text + h.Text);
                    string destinationPath = Path.GetFullPath(Path.Combine(@"C:\Users\N0rdye\Documents\data&temp", entry.Name));
                    entry.ExtractToFile(destinationPath);
                }
                listView1.DoDragDrop(new DataObject(DataFormats.FileDrop, d), DragDropEffects.Move);
                Directory.Delete(@"C:\Users\N0rdye\Documents\data&temp", true);
            }
            ext = true;
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            ext = false;
            extfile();
        }

        private void удалитьВыбраноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ZipArchive archive = ZipFile.Open(dir, ZipArchiveMode.Update))
            {
                foreach (ListViewItem h in listView1.SelectedItems)
                {
                    ZipArchiveEntry entry = archive.GetEntry(питьToolStripMenuItem.Text + h.Text);
                    entry.Delete();
                }
            }
            listView1.Clear();
            read();
        }

        private void добавитьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            состояниеToolStripMenuItem1.Text = "выполняется";
            using (ZipArchive archive = ZipFile.Open(dir, ZipArchiveMode.Update))
            {
                Directory.CreateDirectory(@"C:\Users\N0rdye\Documents\data&temp\folder");
                archive.CreateEntry(питьToolStripMenuItem.Text+имяПапкиToolStripMenuItem.Text+"/");
            }
            listView1.Clear();
            read();
            состояниеToolStripMenuItem1.Text = "готово";
        }

        private void удалитьВыбраныеПапкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ZipArchive archive = ZipFile.Open(dir, ZipArchiveMode.Update))
            {
                foreach (ListViewItem h in listView2.SelectedItems)
                {
                    ZipArchiveEntry entry = archive.GetEntry(питьToolStripMenuItem.Text + h.Text);
                    entry.Delete();
                }
            }
            listView1.Clear();
            read();
        }
    }
}
