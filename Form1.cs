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
        public Form1(){
            InitializeComponent();
            ProcessFilenames();
            FindMaxCoords();
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
                double lon = double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
                s = getXMLvalue(filepaths[i], "lat");
                double lat = double.Parse(s, System.Globalization.CultureInfo.InvariantCulture);

                maxLon = lon > maxLon ? lon : maxLon;
                maxLat = lat > maxLat ? lat : maxLat;
                minLon = lon < minLon ? lon : minLon;
                minLat = lat < minLat ? lat : minLat;
            }
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
                    if (s == "label"){
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
    }
}
