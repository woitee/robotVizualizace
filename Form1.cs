using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace robotVizualizace
{
    public partial class Form1 : Form
    {
        string[] filepaths;
        double maxLon; double maxLat;
        double minLon; double minLat;
        double degWidth; double degHeight;
        double mmWidth; double mmHeight;
        double pxLength; //in milimeters
        long ptr = 0;
        public Form1(){
            InitializeComponent();
            ProcessFilenames();
            FindMaxCoords();//finds measures
            RescalePicturebox();
            NextFile();

            
        }

        private void ProcessFilenames(){
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path = path+"\\data";
            filepaths = Directory.GetFiles(path);
            Console.WriteLine(filepaths[0]);
        }
        private void FindMaxCoords(){
            maxLon = double.MinValue;
            maxLat = double.MinValue;
            minLon = double.MaxValue;
            minLat = double.MaxValue;
            for (int i = 0; i < filepaths.Length; i++){
                string s = getXMLvalue(filepaths[i], "lon");
                if(s == "") {continue;}
                double lon = toDouble(s);
                s = getXMLvalue(filepaths[i], "lat");
                if(s == "") {continue;}
                double lat = toDouble(s);

                maxLon = lon > maxLon ? lon : maxLon;
                maxLat = lat > maxLat ? lat : maxLat;
                minLon = lon < minLon ? lon : minLon;
                minLat = lat < minLat ? lat : minLat;
            }
            degWidth = maxLon-minLon;
            degHeight = maxLat-minLat;
            //figure all measures
            mmHeight = 111120000 * degHeight;
            mmWidth = 72731000 * degWidth; //at 49.3 degrees
            pxLength = mmWidth / pictureBox.Width;
        }
        private void RescalePicturebox(){
            minLonLabel.Text = minLon.ToString();
            maxLonLabel.Text = maxLon.ToString();
            minLatLabel.Text = minLat.ToString();
            maxLatLabel.Text = maxLat.ToString();

            double pbHeight = (double)pictureBox.Width * mmHeight / mmWidth;
            pictureBox.Height = (int)Math.Round( pbHeight );
            minLonLabel.Top = pictureBox.Top + pictureBox.Height;
            maxLonLabel.Top = pictureBox.Top + pictureBox.Height;
            minLatLabel.Top = pictureBox.Top + pictureBox.Height-minLatLabel.Height;

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
        }
        int prevX; int prevY;
        private void NextFile(){
            string path = filepaths[ptr++];
            string s = getXMLvalue(path, "lon");
            if (s == "") { return; }
            double lon = toDouble(s);
            s = getXMLvalue(path, "lat");
            if (s == "") { return; }
            double lat = toDouble(s);

            double xpos = pictureBox.Width * (lon-minLon) / degWidth;
            double ypos = pictureBox.Height * (lat-minLat) / degHeight;
            ypos = pictureBox.Height - ypos;

            int x = (int)Math.Round(xpos);
            int y = (int)Math.Round(ypos);

            if (ptr != 1){
                Graphics g = Graphics.FromImage(pictureBox.Image);
                g.DrawLine(Pens.Blue,
                        new Point(prevX, prevY),
                        new Point(x, y)
                    );
                pictureBox.Refresh();
            }
            
            prevX = x;
            prevY = y;

            autoLabel.Text = (ptr-1).ToString();
        }

        private double toDouble(string from){
            return double.Parse(from, System.Globalization.CultureInfo.InvariantCulture);
        }
        public string getXMLvalue(string filepath, string label){
            StreamReader sr = new StreamReader(filepath);
            char c = '\0';
            string s;
            while(!sr.EndOfStream){
                c = (char)sr.Read();
                if (c == '<'){
                    //start label
                    c = (char)sr.Read();
                    s = "";
                    while(c != '>'){
                        s = s + c;
                        c = (char)sr.Read();
                    }
                    if (s == label){
                        s = "";
                        c = (char)sr.Read();
                        while (c != '<'){
                            s = s + c;
                            c = (char)sr.Read();
                        }
                        return s;
                    }
                }
            }
            return "";
        }

        private void nextButton_Click(object sender, EventArgs e){
            if (ptr < filepaths.Length) {
                NextFile();
            }
        }

        private void autoButton_Click(object sender, EventArgs e){
            autoTimer.Start();
        }

        private void autoTimer_Tick(object sender, EventArgs e){
            if (ptr < filepaths.Length) {
                NextFile();
            } else {
                autoTimer.Stop();
            }
        }
    }
}
