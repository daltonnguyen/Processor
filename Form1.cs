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
using Newtonsoft.Json;
using System.Web.Script.Serialization;


namespace Processor
{
    public partial class Form1 : Form
    {
        List<data> datas = new List<data>();
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Group duplicate object by type, event_id, create_timestamp and send_timestamp.
            var duplicatedtime = from p in datas
                                 group p by new
                                 {
                                     p.type,
                                     p.event_id,
                                     p.time.createTimestamp,
                                     p.time.sendTimestamp,
                                 } into g
                                 where g.Count() > 1
                                 select g.Key;
           // Disply information of duplicated events (type, event_id, create_timestamp) on the application
            foreach (var a in duplicatedtime)
            {
                rtxt_Duplication.Text += a.type + " - " + a.event_id + " - " + a.createTimestamp + "\n";
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Collect list of unique device_id
            List<string> multipleID = datas.GroupBy(i => i.device.deviceId).Select(g => g.First().device.deviceId).ToList();
            long longestDuration = 0; string device_id="";
                foreach (string a in multipleID.Take(200))
                {
                    // Get the activity time for each device_id
                    long duration = long.Parse(datas.Where(x => x.device.deviceId.Equals(a)).Max(z => z.time.createTimestamp)) - long.Parse(datas.Where(x => x.device.deviceId.Equals(a)).Min(z => z.time.createTimestamp)) ;

                    //If the activity time is the biggest. Put them into variables and  display on applicatioon
                    if (duration > longestDuration)
                    {
                        longestDuration = duration;
                        device_id = a;
                    }
                    datas.RemoveAll(y => y.device.deviceId.Equals(a));
                }
                
            rtxt_LongestActivity.Text = "The device with id : " + device_id + " has the longest activity " + longestDuration.ToString() + " milliseconds";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_LaunchTimeResult.Text = "This product has been launched " + datas.Where(m=>m.type.Equals("launch") && m.source.Equals(txt_id.Text)).Count().ToString() +" times in this period" ;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Free memory before loading new data
                datas.Clear();
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                }

                using (StreamReader sr = new StreamReader(@path))
                {
                    //Deserialize to JSON objects by reading line by line of dataset
                    while (sr.Peek() >= 0)
                    {
                        data result = JsonConvert.DeserializeObject<data>(sr.ReadLine());
                        datas.Add(result);
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
           
          
        }


    }
}
