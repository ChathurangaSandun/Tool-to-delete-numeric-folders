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

namespace Tooltodeletenumericfolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            DateTime benchmarkDate = DateTimePicker.Value.Date;
            //TimeSpan benchmarkTime = TimePicker.Value.TimeOfDay;
            String path = FilePathTextBox.Text.ToString();

            DirectoryInfo[] directoryInfos = DirectorySearcher.GetDirectories(path,benchmarkDate);
            foreach (var file in directoryInfos)
            {
                Console.WriteLine(file.Name+" "+file.LastAccessTime);
                
            }


        }
    }
}
