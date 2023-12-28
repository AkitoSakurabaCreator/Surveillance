using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surveillance
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Color.Green;
            this.Opacity = 0.85;
        }

        private System.IO.FileSystemWatcher watcher = null;
        private System.IO.FileSystemWatcher downloadwatcher = null;
        private System.IO.FileSystemWatcher romingwatcher = null;
        private System.IO.FileSystemWatcher localwatcher = null;
        private System.IO.FileSystemWatcher localtempwatcher = null;

        private void watcher_Changed(System.Object source,
            System.IO.FileSystemEventArgs e)
        {
            switch (e.ChangeType)
            {
                case System.IO.WatcherChangeTypes.Changed:
                    Show();
                    richTextBox1.ForeColor = Color.Orange;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が変更されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Created:
                    Show();
                    richTextBox1.ForeColor = Color.Orange;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が作成されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Deleted:
                    Show();
                    richTextBox1.ForeColor = Color.Orange;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が削除されました。" + "\r\n");
                    timer1.Start();
                    break;
            }
        }

        private void downloadwatcher_Changed(System.Object source,
            System.IO.FileSystemEventArgs e)
        {

            switch (e.ChangeType)
            {
                case System.IO.WatcherChangeTypes.Changed:
                    Show();
                    richTextBox1.ForeColor = Color.Aquamarine;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が変更されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Created:
                    Show();
                    richTextBox1.ForeColor = Color.Aquamarine;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が作成されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Deleted:
                    Show();
                    richTextBox1.ForeColor = Color.Aquamarine;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が削除されました。" + "\r\n");
                    timer1.Start();
                    break;
            }
        }

        private void romingwatcher_Changed(System.Object source,
           System.IO.FileSystemEventArgs e)
        {

            switch (e.ChangeType)
            {
                case System.IO.WatcherChangeTypes.Changed:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が変更されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Created:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が作成されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Deleted:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が削除されました。" + "\r\n");
                    timer1.Start();
                    break;
            }
        }

        private void localwatcher_Changed(System.Object source,
          System.IO.FileSystemEventArgs e)
        {

            switch (e.ChangeType)
            {
                case System.IO.WatcherChangeTypes.Changed:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が変更されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Created:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が作成されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Deleted:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が削除されました。" + "\r\n");
                    timer1.Start();
                    break;
            }
        }
        private void localtempwatcher_Changed(System.Object source,
          System.IO.FileSystemEventArgs e)
        {

            switch (e.ChangeType)
            {
                case System.IO.WatcherChangeTypes.Changed:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が変更されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Created:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が作成されました。" + "\r\n");
                    timer1.Start();
                    break;
                case System.IO.WatcherChangeTypes.Deleted:
                    Show();
                    richTextBox1.ForeColor = Color.Red;
                    richTextBox1.AppendText(
                        "「" + e.FullPath + "」が削除されました。" + "\r\n");
                    timer1.Start();
                    break;
            }
        }
        bool Begin = true;
        private void BeginV()
        {
            if (Begin == true)
            {
                Hide();
            }
        }
        private void watcher_Renamed(System.Object source,
            System.IO.RenamedEventArgs e)
        {
            richTextBox1.ForeColor = Color.Orange;
            Show();
            richTextBox1.AppendText(
                "「" + e.FullPath + "」の名前が変更されました。" + "\r\n");
            timer1.Start();
        }

        private void downloadwatcher_Renamed(System.Object source,
            System.IO.RenamedEventArgs e)
        {
            Show();
            richTextBox1.ForeColor = Color.Aquamarine;
            richTextBox1.AppendText(
                "「" + e.FullPath + "」の名前が変更されました。" + "\r\n");
            timer1.Start();
        }
        string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string Roming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string LocalTempPath = Path.GetTempPath();

        private void roming_Renamed(System.Object source,
    System.IO.RenamedEventArgs e)
        {
            Show();
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.AppendText(
                "「" + e.FullPath + "」の名前が変更されました。" + "\r\n");
            timer1.Start();
        }
        private void local_Renamed(System.Object source,
    System.IO.RenamedEventArgs e)
        {
            Show();
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.AppendText(
                "「" + e.FullPath + "」の名前が変更されました。" + "\r\n");
            timer1.Start();
        }
        private void localtemp_Renamed(System.Object source,
    System.IO.RenamedEventArgs e)
        {
            Show();
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.AppendText(
                "「" + e.FullPath + "」の名前が変更されました。" + "\r\n");
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (watcher != null) return;

            watcher = new System.IO.FileSystemWatcher();
            //監視するディレクトリを指定
            watcher.Path = DesktopPath;
            //最終アクセス日時、最終更新日時、ファイル、フォルダ名の変更を監視する
            watcher.NotifyFilter =
                (System.IO.NotifyFilters.LastAccess
                | System.IO.NotifyFilters.LastWrite
                | System.IO.NotifyFilters.FileName
                | System.IO.NotifyFilters.DirectoryName);
            //すべてのファイルを監視
            watcher.Filter = "";
            //UIのスレッドにマーシャリングする
            //コンソールアプリケーションでの使用では必要ない
            watcher.SynchronizingObject = this;

            //イベントハンドラの追加
            watcher.Changed += new System.IO.FileSystemEventHandler(watcher_Changed);
            watcher.Created += new System.IO.FileSystemEventHandler(watcher_Changed);
            watcher.Deleted += new System.IO.FileSystemEventHandler(watcher_Changed);
            watcher.Renamed += new System.IO.RenamedEventHandler(watcher_Renamed);

            //監視を開始する
            watcher.EnableRaisingEvents = true;

            //--------------------[Downloads]----------------------

            var instanceType = Type.GetTypeFromProgID("Shell.Application");
            dynamic shell = Activator.CreateInstance(instanceType);
            var folder = shell.Namespace("shell:Downloads");
            string DownloadPath = folder.Self.Path;

            if (downloadwatcher != null) return;

            downloadwatcher = new System.IO.FileSystemWatcher();
            //監視するディレクトリを指定
            downloadwatcher.Path = DownloadPath;
            //最終アクセス日時、最終更新日時、ファイル、フォルダ名の変更を監視する
            downloadwatcher.NotifyFilter =
                (System.IO.NotifyFilters.LastAccess
                | System.IO.NotifyFilters.LastWrite
                | System.IO.NotifyFilters.FileName
                | System.IO.NotifyFilters.DirectoryName);
            //すべてのファイルを監視
            downloadwatcher.Filter = "";
            //UIのスレッドにマーシャリングする
            //コンソールアプリケーションでの使用では必要ない
            downloadwatcher.SynchronizingObject = this;

            //イベントハンドラの追加
            downloadwatcher.Changed += new System.IO.FileSystemEventHandler(downloadwatcher_Changed);
            downloadwatcher.Created += new System.IO.FileSystemEventHandler(downloadwatcher_Changed);
            downloadwatcher.Deleted += new System.IO.FileSystemEventHandler(downloadwatcher_Changed);
            downloadwatcher.Renamed += new System.IO.RenamedEventHandler(downloadwatcher_Renamed);

            //監視を開始する
            downloadwatcher.EnableRaisingEvents = true;

            //--------------------[Roming]----------------------

            if (romingwatcher != null) return;

            romingwatcher = new System.IO.FileSystemWatcher();
            //監視するディレクトリを指定
            romingwatcher.Path = Roming;
            //最終アクセス日時、最終更新日時、ファイル、フォルダ名の変更を監視する
            romingwatcher.NotifyFilter =
                (System.IO.NotifyFilters.LastAccess
                | System.IO.NotifyFilters.LastWrite
                | System.IO.NotifyFilters.FileName
                | System.IO.NotifyFilters.DirectoryName);
            //すべてのファイルを監視
            romingwatcher.Filter = "";
            //UIのスレッドにマーシャリングする
            //コンソールアプリケーションでの使用では必要ない
            romingwatcher.SynchronizingObject = this;

            //イベントハンドラの追加
            romingwatcher.Changed += new System.IO.FileSystemEventHandler(romingwatcher_Changed);
            romingwatcher.Created += new System.IO.FileSystemEventHandler(romingwatcher_Changed);
            romingwatcher.Deleted += new System.IO.FileSystemEventHandler(romingwatcher_Changed);
            romingwatcher.Renamed += new System.IO.RenamedEventHandler(romingwatcher_Changed);

            //監視を開始する
            romingwatcher.EnableRaisingEvents = true;

            //--------------------[Local]----------------------

            if (localwatcher != null) return;

            localwatcher = new System.IO.FileSystemWatcher();
            //監視するディレクトリを指定
            localwatcher.Path = Roming;
            //最終アクセス日時、最終更新日時、ファイル、フォルダ名の変更を監視する
            localwatcher.NotifyFilter =
                (System.IO.NotifyFilters.LastAccess
                | System.IO.NotifyFilters.LastWrite
                | System.IO.NotifyFilters.FileName
                | System.IO.NotifyFilters.DirectoryName);
            //すべてのファイルを監視
            localwatcher.Filter = "";
            //UIのスレッドにマーシャリングする
            //コンソールアプリケーションでの使用では必要ない
            localwatcher.SynchronizingObject = this;

            //イベントハンドラの追加
            localwatcher.Changed += new System.IO.FileSystemEventHandler(localwatcher_Changed);
            localwatcher.Created += new System.IO.FileSystemEventHandler(localwatcher_Changed);
            localwatcher.Deleted += new System.IO.FileSystemEventHandler(localwatcher_Changed);
            localwatcher.Renamed += new System.IO.RenamedEventHandler(localwatcher_Changed);

            //監視を開始する
            localwatcher.EnableRaisingEvents = true;
            //--------------------[LocalTemp]----------------------

            if (localtempwatcher != null) return;

            localtempwatcher = new System.IO.FileSystemWatcher();
            //監視するディレクトリを指定
            localtempwatcher.Path = LocalTempPath;
            //最終アクセス日時、最終更新日時、ファイル、フォルダ名の変更を監視する
            localtempwatcher.NotifyFilter =
                (System.IO.NotifyFilters.LastAccess
                | System.IO.NotifyFilters.LastWrite
                | System.IO.NotifyFilters.FileName
                | System.IO.NotifyFilters.DirectoryName);
            //すべてのファイルを監視
            localtempwatcher.Filter = "";
            //UIのスレッドにマーシャリングする
            //コンソールアプリケーションでの使用では必要ない
            localtempwatcher.SynchronizingObject = this;

            //イベントハンドラの追加
            localtempwatcher.Changed += new System.IO.FileSystemEventHandler(localtempwatcher_Changed);
            localtempwatcher.Created += new System.IO.FileSystemEventHandler(localtempwatcher_Changed);
            localtempwatcher.Deleted += new System.IO.FileSystemEventHandler(localtempwatcher_Changed);
            localtempwatcher.Renamed += new System.IO.RenamedEventHandler(localtempwatcher_Changed);

            //監視を開始する
            localwatcher.EnableRaisingEvents = true;

            this.DesktopLocation = new Point(1380, 5);
        }

        int time = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time <= 0)
            {
                timer1.Stop();
                time = 5;
                Hide();
            }
            else
            {
                time--;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
