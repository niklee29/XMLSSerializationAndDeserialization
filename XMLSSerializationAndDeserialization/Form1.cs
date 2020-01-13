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
using System.Xml.Serialization;

namespace XMLSSerializationAndDeserialization
{
    public partial class Form1 : Form
    {
        XMLDataClass xls = new XMLDataClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XMLroot xroot = xls.ReadXMLdata(@"D:\ARRAY_APCSPCDT.xml");
        }
    }
}
