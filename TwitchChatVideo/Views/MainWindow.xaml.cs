using System.Windows;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Reflection;
using System;

namespace TwitchChatVideo
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Directory.CreateDirectory(TwitchEmote.BaseDir);
            Directory.CreateDirectory(Badges.BaseDir);
            Directory.CreateDirectory(Bits.BaseDir);
            Directory.CreateDirectory(FFZ.BaseDir);
            Directory.CreateDirectory(BTTV.BaseDir);
            Directory.CreateDirectory(ChatVideo.OutputDirectory);
            Directory.CreateDirectory(ChatVideo.LogDirectory);
            Directory.CreateDirectory(ChatVideo.FFmpegDirectory);
            if(Directory.Exists(Updater.OldVersion))
            {
                Directory.Delete(Updater.OldVersion, true);
            }
            if(!File.Exists("./ffmpeg/ffmpeg.exe"))
            {
                MessageBox.Show("FFmpeg executable not found. Please download and extract ffmpeg.exe into the ffmpeg folder.\nA browser window will open and lead you directly to the download page when you close this notice.");
                Process.Start("https://ffmpeg.zeranoe.com/builds/");
                Application.Current.Shutdown();
            }
        }
    }
}
