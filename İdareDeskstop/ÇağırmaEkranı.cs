using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using Newtonsoft.Json;

namespace İdareDeskstop
{
    public partial class ÇağırmaEkranı : Form
    {

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "qlDUgLSDUYM1OqcOnlecbAEDhbFWJI8MCMUtZpYU",
            BasePath = "https://kkfldatabase-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public ÇağırmaEkranı()
        {
            InitializeComponent();

            
        }

        List<İdareciler> idareciler;
       
        private void ÇağırmaEkranı_Load(object sender, EventArgs e)
        {

            try
            {
                client = new FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("There was an error");
            }


            FirebaseResponse res = client.Get(@"AdministrationList");
            Dictionary<string, İdareciler> data = JsonConvert.DeserializeObject<Dictionary<string, İdareciler>>(res.Body.ToString());
            idareciler = new List<İdareciler>(data.Values);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idareciisim = null;
            string idarecisoyisim = null;
            string idaregorev = null;
            foreach(İdareciler idareci in idareciler)
            {
                if(txt_idareno.Text==idareci.idaresirano.ToString())
                {
                    idareciisim = idareci.idareisim;
                    idarecisoyisim = idareci.idaresoyisim;
                    idaregorev = idareci.görev;
                }
            }
            string selectedText = comboBox1.SelectedItem.ToString();

            ÇağrılanÖğrenci calledStudent = new ÇağrılanÖğrenci(selectedText,txt_öğrenciisim.Text,idareciisim,idarecisoyisim,idaregorev);

            MessageBox.Show($"{selectedText} sınıfından {txt_öğrenciisim.Text} öğrencisini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.OKCancel);

            bool v =Convert.ToBoolean( MessageBoxButtons.OKCancel);

            if (v==true)
            {
                client.Set("CurrentCall/" + "CalledStudent/"+selectedText,calledStudent);
            }
            else
            {

            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
