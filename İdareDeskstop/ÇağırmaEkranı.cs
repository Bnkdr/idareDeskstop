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

        IFirebaseConfig ifc2 = new FirebaseConfig()
        {
            AuthSecret = "2inVCykQM5Pd7bwsaCbMYh38tXU8WcQkMSs1qRhl",
            BasePath = "https://privatedata-506ba-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client2;
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
                client2 = new FirebaseClient(ifc2);
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

         
            ÇağrılanÖğrenci calledStudent = new ÇağrılanÖğrenci(selectedText,txt_öğrenciisim.Text,idareciisim,idarecisoyisim,idaregorev,rtxt_aciklama.Text);

            MessageBox.Show($"{selectedText} sınıfından {txt_öğrenciisim.Text} öğrencisini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.OKCancel);

            selectedText = SınıfNoDegistirme(selectedText);

            bool v =Convert.ToBoolean( MessageBoxButtons.OKCancel);

          if (v==true)
            {
                client.Set("CurrentCall/" + selectedText,calledStudent);
               // client2.Set("CurrentCall/" + DateTime.Now, calledStudent);
            }
            else
            {

            }

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        protected string SınıfNoDegistirme(string selectedText)
        {
            if (selectedText == "9A")
            {
                selectedText = "091";
               

            }
            else if (selectedText == "9B")
            {
                selectedText = "092";
                
            }
            else if (selectedText == "9C")
            {
                selectedText = "093";
              
            }
            else if (selectedText == "9D")
            {
                selectedText = "094";
               
            }
            else if (selectedText == "10A")
            {
                selectedText = "101";
               
            }
            else if (selectedText == "10B")
            {
                selectedText = "102";
              
            }
            else if (selectedText == "10C")
            {
                selectedText = "103";
               
            }
            else if (selectedText == "10D")
            {
                selectedText = "104";
             
            }
            else if (selectedText == "11A")
            {
                selectedText = "111";
               

            }
            else if (selectedText == "11B")
            {
                selectedText = "112";
              
            }
            else if (selectedText == "11C")
            {
                selectedText = "113";
              
            }
            else if (selectedText == "11D")
            {
                selectedText = "114";
               
            }
            else if (selectedText == "12A")
            {
                selectedText = "121";
               
            }
            else if (selectedText == "12B")
            {
                selectedText = "122";
                
            }
            else if (selectedText == "12C")
            {
                selectedText = "123";
                
            }
            else if (selectedText == "12D")
            {
                selectedText = "124";
               
            }
            return selectedText;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idareciisim = null;
            string idarecisoyisim = null;
            string idaregorev = null;
            foreach (İdareciler idareci in idareciler)
            {
                if (txt_oIdareNo.Text == idareci.idaresirano.ToString())
                {
                    idareciisim = idareci.idareisim;
                    idarecisoyisim = idareci.idaresoyisim;
                    idaregorev = idareci.görev;
                }
            }
            string selectedText2 = comboBox2.SelectedItem.ToString();

            

            ÇağrılanÖğretmen calledTeacher = new ÇağrılanÖğretmen(selectedText2, txt_ogretmenismi.Text, idareciisim, idarecisoyisim, idaregorev, rtxt_ogretmen.Text);

            MessageBox.Show($"{selectedText2} sınıfından {txt_ogretmenismi.Text} öğretmenini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.OKCancel);

            selectedText2 = SınıfNoDegistirme(selectedText2);

            bool v = Convert.ToBoolean(MessageBoxButtons.OKCancel);

            if (v == true)
            {
                client.Set("CurrentCall/" +selectedText2 , calledTeacher);
                //client2.Set("CurrentCall/" + DateTime.Now, calledTeacher);
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idareciisim = null;
            string idarecisoyisim = null;
            string idaregorev = null;
            foreach (İdareciler idareci in idareciler)
            {
                if (txt_çağıranidare.Text == idareci.idaresirano.ToString())
                {
                    idareciisim = idareci.idareisim;
                    idarecisoyisim = idareci.idaresoyisim;
                    idaregorev = idareci.görev;
                }
            }


           Çağrılanİdareci calledAdministration = new Çağrılanİdareci(txt_çağrılanidare.Text,txt_idareciisim.Text, idareciisim, idarecisoyisim, idaregorev, rtxt_idareaciklama.Text);

            MessageBox.Show($"{txt_idareciisim.Text} idarecisini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.OKCancel);

            bool v = Convert.ToBoolean(MessageBoxButtons.OKCancel);

            DateTimeConverter dtc = new DateTimeConverter();

            //string tarih = DateTime.Now;

            string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
            string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
            string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
            string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
            string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
            string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);



            if (v == true)
            {
                client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" +("/"+saat+" "+dakika+" "+saniye), calledAdministration);
                client.Set("CurrentCall/" +txt_çağrılanidare.Text , calledAdministration);
               
            }
            else
            {

            }



        }


    }
}
