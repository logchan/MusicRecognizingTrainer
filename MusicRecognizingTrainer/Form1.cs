using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicRecognizingTrainer
{
    public partial class Form1 : Form
    {
        private string[] extensions = { ".wav", ".mp3", ".m4a", ".aac", ".mp4", ".avi", ".wma" };

        private List<FileInfo> musics;
        private int[] indexies;
        private int[] randIdx;
        private int playing = 0;
        private int lastLoaded = -1;
        private int total = 0;
        private double currBegin = -1;

        private WMPLib.WindowsMediaPlayer wmp;

        public Form1()
        {
            InitializeComponent();

            wmp = new WMPLib.WindowsMediaPlayer();
            browseBtn.Focus();
        }

        private void SetPlaylistText()
        {
            playlistLbl.Text = String.Format("{0} / {1}", playing + 1, total);
        }

        private void ResetPlaylist()
        {
            wmp.controls.stop();
            currBegin = -1;
            playing = 0;
            if (total < 1)
                return;

            Random rnd = new Random();
            randIdx = indexies.OrderBy(x => rnd.Next()).ToArray();
            SetPlaylistText();
        }

        private void SetUIEnabled(bool v)
        {
            playControlGrp.Enabled = v;
            browseBtn.Enabled = v;
        }

        private async Task LoadMusic()
        {
            if (playing != lastLoaded)
            {
                wmp.URL = musics[randIdx[playing]].FullName;

                // wait for wmp to load information
                int maxWait = 100;
                while (maxWait > 0 && wmp.currentMedia.duration == 0)
                {
                    await Task.Run(() => { System.Threading.Thread.Sleep(100); });
                }
                
                lastLoaded = playing;
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            if (!Directory.Exists(dialog.SelectedPath))
                return;

            musics = new List<FileInfo>();

            DirectoryInfo di = new DirectoryInfo(dialog.SelectedPath);
            foreach (FileInfo fi in di.GetFiles())
            {
                foreach (string ext in extensions)
                {
                    if (String.Compare(fi.Extension, ext, true) == 0)
                    {
                        musics.Add(fi);
                        break;
                    }
                }
            }

            pathBox.Text = di.FullName;
            playlistLbl.Text = "0/0";
            lastLoaded = -1;
            total = musics.Count;
            if (total < 1)
            {
                MessageBox.Show("No recognized file is found in the given directory.");
                return;
            }

            indexies = new int[total];
            for (int i = 0; i < total; ++i)
                indexies[i] = i;

            ResetPlaylist();
        }

        private async Task BeginPlaying()
        {
            await LoadMusic();

            SetUIEnabled(false);

            if (rndBeginBox.Checked)
            {
                if (currBegin < 0)
                {
                    Random rnd = new Random();
                    double length = (int)wmp.currentMedia.duration;
                    length -= 60; // at least one minute clip
                    if (length > 0)
                        currBegin = rnd.NextDouble() * length;
                    else
                        currBegin = 0;
                }
                wmp.controls.currentPosition = currBegin;
            }

            wmp.controls.play();

            SetUIEnabled(true);
        }

        private async void playClipBtn_Click(object sender, EventArgs e)
        {
            if (playing >= total)
                return;

            await BeginPlaying();
        }

        private async Task MovePlaying(int dir)
        {
            int newplaying = playing + dir;
            if (newplaying < 0 || newplaying >= total)
                return;

            playing = newplaying;
            wmp.controls.stop();
            playingLbl.Text = "[Click to Reveal]";
            SetPlaylistText();
            currBegin = -1;

            if (autoPlayChk.Checked)
            {
                await BeginPlaying();
            }
        }

        private async void playNextBtn_Click(object sender, EventArgs e)
        {
            await MovePlaying(1);
        }

        private void resetPlaylistBtn_Click(object sender, EventArgs e)
        {
            ResetPlaylist();
        }

        private void playingLbl_Click(object sender, EventArgs e)
        {
            if (playing >= total)
                return;

            playingLbl.Text = musics[randIdx[playing]].Name;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }

        private async void playPrevBtn_Click(object sender, EventArgs e)
        {
            await MovePlaying(-1);
        }

        private void sourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/logchan/MusicRecognizingTrainer");
        }
    }
}
