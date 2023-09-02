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
using System.Net;
using System.Net.Sockets;

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
        List<Öğretmenler> ogretmenler;
        List<Öğrenciler> öğrenciler;
        List<object> çağrılacaklar;
        List<string> çağrılacaklarNo;
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
            foreach(İdareciler idareci in idareciler)
            {
                string idr = idareci.idareisim + " " + idareci.idaresoyisim;
                cmbox_idare.Items.Add(idr);
            }
            

            FirebaseResponse res2 = client.Get(@"TeacherList");
            Dictionary<string, Öğretmenler> data2 = JsonConvert.DeserializeObject<Dictionary<string, Öğretmenler>>(res2.Body.ToString());
            ogretmenler = new List<Öğretmenler>(data2.Values);
            foreach (Öğretmenler öğretmen in ogretmenler)
            {
                string öğr = öğretmen.öğretmenisim + " " + öğretmen.öğretmensoyisim;
                cmbox_idare.Items.Add(öğr);
            }
            FirebaseResponse res3 = client.Get(@"StudentList/2023-2024");
            Dictionary<string, Öğrenciler> data3 = JsonConvert.DeserializeObject<Dictionary<string, Öğrenciler>>(res3.Body.ToString());
            öğrenciler = new List<Öğrenciler>(data3.Values);
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
            string selectedName = cmbox_ogrenci.SelectedItem.ToString();

            DialogResult diaRes= MessageBox.Show($"{selectedText} sınıfından {selectedName} öğrencisini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            selectedText = SınıfNoDegistirme(selectedText);

            ÇağrılanÖğrenci calledStudent = new ÇağrılanÖğrenci(selectedText,selectedName,idareciisim,idarecisoyisim,idaregorev,rtxt_aciklama.Text);

          

            DateTimeConverter dtc = new DateTimeConverter();

            string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
            string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
            string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
            string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
            string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
            string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);

            if (diaRes==DialogResult.Yes)
            {
                client.Set("CurrentCall/" + selectedText,calledStudent);
                client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye), calledStudent);
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
            string selected_ogrtmn = cmbox_ogretmen.SelectedItem.ToString();

            DialogResult diaRes = MessageBox.Show($"{selectedText2} sınıfından {selected_ogrtmn} öğretmenini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            selectedText2 = SınıfNoDegistirme(selectedText2);


            ÇağrılanÖğretmen calledTeacher = new ÇağrılanÖğretmen(selectedText2,selected_ogrtmn, idareciisim, idarecisoyisim, idaregorev, rtxt_ogretmen.Text);

            DateTimeConverter dtc = new DateTimeConverter();

            string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
            string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
            string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
            string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
            string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
            string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);

            if (diaRes==DialogResult.Yes)
            {
                client.Set("CurrentCall/" +selectedText2 , calledTeacher);
                client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye), calledTeacher);
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

            string selected_idareci = cmbox_idare.SelectedItem.ToString();

           Çağrılanİdareci calledAdministration = new Çağrılanİdareci(txt_çağrılanidare.Text,selected_idareci, idarecisoyisim, idareciisim,idaregorev, rtxt_idareaciklama.Text);

            DialogResult diaRes=MessageBox.Show($"{selected_idareci} idarecisini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            

            DateTimeConverter dtc = new DateTimeConverter();

            //string tarih = DateTime.Now;

            string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
            string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
            string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
            string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
            string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
            string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);



            if (diaRes==DialogResult.Yes)
            {
                client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" +("/"+saat+" "+dakika+" "+saniye), calledAdministration);
                client.Set("CurrentCall/" +txt_çağrılanidare.Text , calledAdministration);
               
            }
            else
            {

            }



        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            string sinif = "";
            foreach(Öğrenciler öğrenci in öğrenciler)
            {
                sinif = öğrenci.sınıf.ToString() + öğrenci.şube;
                if (sinif==comboBox1.SelectedItem.ToString())
                {
                    string ogr = öğrenci.isim + " " + öğrenci.soyisim;
                    cmbox_ogrenci.Items.Add(ogr);
                }
            }
           
        }

        private void btn_ogrenciEkleme_Click(object sender, EventArgs e)
        {

            string idareciisim = null;
            string idarecisoyisim = null;
            string idaregorev = null;
            foreach (İdareciler idareci in idareciler)
            {
                if (txt_idareno.Text == idareci.idaresirano.ToString())
                {
                    idareciisim = idareci.idareisim;
                    idarecisoyisim = idareci.idaresoyisim;
                    idaregorev = idareci.görev;
                }
            }
            string selectedText = comboBox1.SelectedItem.ToString();
            string selectedName = cmbox_ogrenci.SelectedItem.ToString();
            DialogResult diaRes = MessageBox.Show($"{selectedText} sınıfından {selectedName} öğrencisini çağırma listesine eklemek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);
            string selectedText_changed = SınıfNoDegistirme(selectedText);
            ÇağrılanÖğrenci calledStudent = new ÇağrılanÖğrenci(selectedText_changed, selectedName, idareciisim, idarecisoyisim, idaregorev, rtxt_aciklama.Text);
            if (diaRes == DialogResult.Yes)
            {
                çağrılacaklar.Add(calledStudent);
                çağrılacaklarNo.Add(calledStudent.çağrılmano);
                dataGridView1.Rows.Add(calledStudent.isimSoyisim, selectedText, "öğrenci", calledStudent.acıklama);
                MessageBox.Show("Öğrenci çağırma listesine eklendi, çağırmak istediğiniz zaman 'Çağırma' bölümünden çağırabilirsiniz.", "Bilgilendirme");
            }
            
        }

        private void btn_ogretmenEkle_Click(object sender, EventArgs e)
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
            string selected_ogrtmn = cmbox_ogretmen.SelectedItem.ToString();

            string öğretmen_ders = null;
            foreach(Öğretmenler öğretmen in ogretmenler)
            {
                string öğretmen_isim = öğretmen.öğretmenisim + " " + öğretmen.öğretmensoyisim;
                if (selected_ogrtmn == öğretmen_isim)
                {
                    öğretmen_ders = öğretmen.öğretmenders;
                }
            }

            DialogResult diaRes = MessageBox.Show($"{selectedText2} sınıfından {selected_ogrtmn} öğretmenini çağırma listesine eklemek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            string selectedText2_changed = SınıfNoDegistirme(selectedText2);


            ÇağrılanÖğretmen calledTeacher = new ÇağrılanÖğretmen(selectedText2_changed, selected_ogrtmn, idareciisim, idarecisoyisim, idaregorev, rtxt_ogretmen.Text);
            if (diaRes == DialogResult.Yes)
            {
                çağrılacaklar.Add(calledTeacher);
                çağrılacaklarNo.Add(calledTeacher.çağrılmano);
                dataGridView1.Rows.Add(calledTeacher.isimSoyisim, selectedText2, $"{öğretmen_ders} öğretmeni", calledTeacher.acıklama);
                MessageBox.Show("Öğretmen çağırma listesine eklendi, çağırmak istediğiniz zaman 'Çağırma' bölümünden çağırabilirsiniz.", "Bilgilendirme");
            }
        }

        private void btn_idareEkle_Click(object sender, EventArgs e)
        {
            string idareciisim = null;
            string idarecisoyisim = null;
            string idaregorev = null;
            string çağrılanGorev = null;
            foreach (İdareciler idareci in idareciler)
            {
                if (txt_çağıranidare.Text == idareci.idaresirano.ToString())
                {
                    idareciisim = idareci.idareisim;
                    idarecisoyisim = idareci.idaresoyisim;
                    idaregorev = idareci.görev;
                }
                if(txt_çağrılanidare.Text==idareci.idaresirano.ToString())
                {
                    çağrılanGorev = idareci.görev;
                }
            }

            string selected_idareci = cmbox_idare.SelectedItem.ToString();

            Çağrılanİdareci calledAdministration = new Çağrılanİdareci(txt_çağrılanidare.Text, selected_idareci, idarecisoyisim, idareciisim, idaregorev, rtxt_idareaciklama.Text);

            DialogResult diaRes = MessageBox.Show($"{selected_idareci} idarecisini çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);
            if (diaRes == DialogResult.Yes)
            {
                çağrılacaklar.Add(calledAdministration);
                çağrılacaklarNo.Add(calledAdministration.çağrılanidarecino);
                dataGridView1.Rows.Add(calledAdministration.idareciisimsoyisim, "idareci",çağrılanGorev, calledAdministration.acıklama);
                MessageBox.Show("İdareci çağırma listesine eklendi, çağırmak istediğiniz zaman 'Çağırma' bölümünden çağırabilirsiniz.", "Bilgilendirme");
            }
        }

        private void btn_ListeCagri_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show($"Listedekileri çağırmak istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);

            if (diaRes == DialogResult.Yes)
            {
                for (int i = 0; i < çağrılacaklar.Count; i++)
                {
                    DateTimeConverter dtc = new DateTimeConverter();


                    string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
                    string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
                    string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
                    string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
                    string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
                    string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);

                    


                    client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye), çağrılacaklar[i]);
                    client.Set("CurrentCall/" + çağrılacaklarNo[i], çağrılacaklar[i]);



                }
            }
            else
            {
                
            }
           
        }

        private void btn_datagridSil_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Çağrılacak kişiyi silmek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);
            if (diaRes == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                çağrılacaklar.Remove(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
