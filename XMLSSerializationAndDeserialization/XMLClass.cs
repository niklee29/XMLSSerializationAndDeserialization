using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLSSerializationAndDeserialization
{
    public class XMLDataClass
    {
        public XMLroot ReadXMLdata(string xmlfile)
        {
            //string readPathname = @"D:\ARRAY_APCSPCDT.xml";
            XmlSerializer deserializer = new XmlSerializer(typeof(XMLroot));
            TextReader reader = new StreamReader(xmlfile);

            try
            {
                object obj = deserializer.Deserialize(reader);
                XMLroot XmlData = (XMLroot)obj;
                reader.Close();
                return XmlData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{nameof(ReadXMLdata)}: XML file {xmlfile} read fail: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }


    public class Shift_array
    {
        public string eqpt_id { get; set; }
        public string eqpt_unit_id { get; set; }
        public string rep_unit { get; set; }
        public string data_pat { get; set; }
        public string mes_id { get; set; }
        public string sht_id { get; set; }
        public string slot_no { get; set; }
        public string mes_link_id { get; set; }
        public string lot_id { get; set; }
        public string splt_id { get; set; }
        public string crr_id { get; set; }
        public string product_id { get; set; }
        public string pfcd { get; set; }
        public string ec_code { get; set; }
        public string route_id { get; set; }
        public string route_ver { get; set; }
        public string proc_id { get; set; }
        public string ope_id { get; set; }
        public string ope_ver { get; set; }
        public string ope_no { get; set; }
        public string rpt_user { get; set; }
        public string ds_recipe_id { get; set; }
        public string ac_recipe_id { get; set; }
        public string ce_id { get; set; }
        public string pnp { get; set; }
        public string run_mode { get; set; }
        public string owner { get; set; }
        public string prod_flg { get; set; }
        public string spec_check_only { get; set; }
        public string cross_shop { get; set; }
        public string subentity { get; set; }
        public string up_eqpt_id { get; set; }
        public string up_ope_id { get; set; }
        public string up_subentity { get; set; }
        public string up_recipe_id { get; set; }
        public string clm_date { get; set; }
        public string clm_time { get; set; }
        public string kind_id { get; set; }
        public string process_tm { get; set; }
        public string comment { get; set; }
        public string recycle_cnt { get; set; }
        public string rework_cnt { get; set; }
        public string rgb_rework_cnt { get; set; }
        public string ito_rework_cnt { get; set; }
        public string res_field_1 { get; set; }
        public string res_field_2 { get; set; }
        public string data_cnt { get; set; }
        public string key_material_id { get; set; }
        public string resist_src { get; set; }
        public string mes_link_key { get; set; }
        public string group_id { get; set; }
        public string prod_flag { get; set; }
        public string ng_mark { get; set; }



        [XmlElement("data_ary")]
        public Data_array[] data_ary { get; set; }

    }


    public class Data_array
    {
        public string clm_flg { get; set; }
        public string tcs_label { get; set; }
        public string data_group { get; set; }
        public string data_type { get; set; }

        public string data_value { get; set; }
        public string r2r_flg { get; set; }
    }


    [XmlRoot("transaction")]
    public class XMLroot
    {
        public string trx_id;
        public string type_id { get; set; }
        public string ec_code { get; set; }
        public string orig_opi_flg { get; set; }
        public string sht_cnt { get; set; }

        [XmlElement("sht_ary")]
        public Shift_array[] sht_ary { get; set; }
    }
}
