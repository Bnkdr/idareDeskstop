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
using System.Threading;

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
        List<Çağrılanİdareci> çağrılacak_idareciler;
        List<ÇağrılanÖğretmen> çağrılacak_öğretmenler;
        List<ÇağrılanÖğrenci> çağrılacak_öğrenciler;
        List<string> çağrılacaklarNo;

        List<string> feedbacks;
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
            try
            {
                FirebaseResponse res = client.Get(@"AdministrationList");
                Dictionary<string, İdareciler> data = JsonConvert.DeserializeObject<Dictionary<string, İdareciler>>(res.Body.ToString());
                idareciler = new List<İdareciler>(data.Values);
                foreach (İdareciler idareci in idareciler)
                {
                    string idr = idareci.idareisim + " " + idareci.idaresoyisim;
                    cmbox_idare.Items.Add(idr);
                }
            }
            catch
            {
                MessageBox.Show("Administration data couldn't fetched");
                idareciler = null;
            }
            try
            {
                FirebaseResponse res2 = client.Get(@"TeacherList");
                Dictionary<string, Öğretmenler> data2 = JsonConvert.DeserializeObject<Dictionary<string, Öğretmenler>>(res2.Body.ToString());
                ogretmenler = new List<Öğretmenler>(data2.Values);
                foreach (Öğretmenler öğretmen in ogretmenler)
                {
                    string öğr = öğretmen.öğretmenisim + " " + öğretmen.öğretmensoyisim;
                    cmbox_ogretmen.Items.Add(öğr);
                }
            }
            catch
            {
                MessageBox.Show("Teacher data couldn't fetched");
                ogretmenler = null;
            }
            try
            {
                FirebaseResponse res3 = client.Get(@"StudentList/2023-2024");
                Dictionary<string, Öğrenciler> data3 = JsonConvert.DeserializeObject<Dictionary<string, Öğrenciler>>(res3.Body.ToString());
                if (data3 != null)
                {
                    öğrenciler = new List<Öğrenciler>(data3.Values);
                }
                
            }
            catch
            {
                MessageBox.Show("Student data couldn't fetched");
                öğrenciler = null;
            }
            Feedback();
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
        async void Feedback()
        {

            while (true)
            {
                FirebaseResponse res2 =  await client.GetAsync(@"Feedback");
                Dictionary<string, string> data2 = JsonConvert.DeserializeObject<Dictionary<string, string>>(res2.Body.ToString());
                
                if (data2 != null)
                {
                    feedbacks = new List<string>(data2.Values);
                    int count = 0;
                    if (feedbacks != null)
                    {
                        foreach (string key in feedbacks)
                        {

                            string çagrilan = noDegistirme(data2.ElementAt(count).Key);
                            MessageBox.Show($"{çagrilan} {key} çağrıldı");
                            client.Delete($"Feedback/{data2.ElementAt(count).Key}");
                            data2.Remove(data2.ElementAt(count).Key);
                            count++;

                        }
                        feedbacks = null;
                    }
                    

                }
              
            }

        }
        private string noDegistirme(string no)
        {
            if( no== "1")
            {
                no = "Yadin Çelik'in odası";
                return no;
            }
            else if (no == "2")
            {
                no = "Şenay Öztürk'ün odası";
                return no;
            }
            else if (no == "3")
            {
                no = "Galip Yavuz'un odası";
                return no;
            }
            else if (no == "4")
            {
                no = "İsa Tevfik Kurşun'un odası";
                return no;
            }
            else if (no == "5")
            {
                no = "Fikri Etem'in odası";
                return no;
            }
            else if (no == "6")
            {
                no = "Formatör'ün odası";
                return no;
            }
            else if (no == "091")
            {
                no = "9A";
                return no;
            }
            else if (no == "092")
            {
                no = "9B";
                return no;
            }
            else if (no == "093")
            {
                no = "9C";
                return no;
            }
            else if (no == "094")
            {
                no = "9D";
                return no;
            }
            else if (no == "101")
            {
                no = "10A";
                return no;
            }
            else if (no == "102")
            {
                no = "10B";
                return no;
            }
            else if (no == "103")
            {
                no = "10C";
                return no;
            }
            else if (no == "104")
            {
                no = "10D";
                return no;
            }
            else if (no == "111")
            {
                no = "11A";
                return no;
            }
            else if (no == "112")
            {
                no = "11B";
                return no;
            }
            else if (no == "113")
            {
                no = "11C";
                return no;
            }
            else if (no == "114")
            {
                no = "11D";
                return no;
            }
            else if (no == "121")
            {
                no = "12A";
                return no;
            }
            else if (no == "122")
            {
                no = "12B";
                return no;
            }
            else if (no == "123")
            {
                no = "12C";
                return no;
            }
            else if (no == "124")
            {
                no = "12D";
                return no;
            }
            else
            {
                return "No bulunamadı";
            }
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
            try
            {
                string sinif = "";
                if(öğrenciler!=null)
                {
                    foreach (Öğrenciler öğrenci in öğrenciler)
                    {
                        sinif = öğrenci.sınıf.ToString() + öğrenci.şube;
                        if (sinif == comboBox1.SelectedItem.ToString())
                        {
                            string ogr = öğrenci.isim + " " + öğrenci.soyisim;
                            cmbox_ogrenci.Items.Add(ogr);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci verisi bulunamadı.");
                }
                
            }
            catch
            {
                
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
                if (çağrılacak_öğrenciler == null)
                {
                    çağrılacak_öğrenciler = new List<ÇağrılanÖğrenci>();

                }
                çağrılacak_öğrenciler.Add(calledStudent);
                if (çağrılacaklarNo == null)
                {
                    çağrılacaklarNo = new List<string>();
                }
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
                if (çağrılacak_öğretmenler == null)
                {
                    çağrılacak_öğretmenler = new List<ÇağrılanÖğretmen>();
                }
                çağrılacak_öğretmenler.Add(calledTeacher);
                if (çağrılacaklarNo == null)
                {
                    çağrılacaklarNo = new List<string>();
                }
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

            DialogResult diaRes = MessageBox.Show($"{selected_idareci} idarecisini çağırma listesine eklemek istediğinize emin misiniz?", "Kontrol", MessageBoxButtons.YesNo);
            if (diaRes == DialogResult.Yes)
            {
                if (çağrılacak_idareciler == null)
                {
                    çağrılacak_idareciler = new List<Çağrılanİdareci>();
                }
                
                çağrılacak_idareciler.Add(calledAdministration);
                if (çağrılacaklarNo == null)
                {
                    çağrılacaklarNo = new List<string>();
                }
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
                if (çağrılacak_öğrenciler != null)
                {
                    for (int i = 0; i < çağrılacak_öğrenciler.Count; i++)
                    {
                        DateTimeConverter dtc = new DateTimeConverter();


                        string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
                        string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
                        string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
                        string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
                        string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
                        string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);




                        client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye), çağrılacak_öğrenciler[i]);
                        client.Set("CurrentCall/" + çağrılacaklarNo[i], çağrılacak_öğrenciler[i]);

                    }
                    çağrılacak_öğrenciler = null;
                    çağrılacaklarNo = null;
                }
                if (çağrılacak_öğretmenler != null)
                {
                    for (int i = 0; i < çağrılacak_öğretmenler.Count; i++)
                    {
                        DateTimeConverter dtc = new DateTimeConverter();


                        string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
                        string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
                        string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
                        string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
                        string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
                        string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);




                        client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye), çağrılacak_öğretmenler[i]);
                        client.Set("CurrentCall/" + çağrılacaklarNo[i], çağrılacak_öğretmenler[i]);

                    }
                    çağrılacak_öğretmenler = null;
                    
                }
                if (çağrılacak_idareciler != null)
                {
                    for (int i = 0; i < çağrılacak_idareciler.Count; i++)
                    {
                        DateTimeConverter dtc = new DateTimeConverter();


                        string gün = dtc.ConvertToInvariantString(DateTime.Now.Day);
                        string ay = dtc.ConvertToInvariantString(DateTime.Now.Month);
                        string yıl = dtc.ConvertToInvariantString(DateTime.Now.Year);
                        string saat = dtc.ConvertToInvariantString(DateTime.Now.Hour);
                        string dakika = dtc.ConvertToInvariantString(DateTime.Now.Minute);
                        string saniye = dtc.ConvertToInvariantString(DateTime.Now.Second);




                        client2.Set($"CurrentCall/{(gün + " " + ay + " " + yıl)}" + ("/" + saat + " " + dakika + " " + saniye), çağrılacak_idareciler[i]);
                        client.Set("CurrentCall/" + çağrılacaklarNo[i], çağrılacak_idareciler[i]);

                    }
                    çağrılacak_idareciler = null;
                   
                }
                çağrılacaklarNo = null;
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
                string çağrilan = dataGridView1.CurrentRow.Cells[2].ToString();
                if (çağrilan.Contains("idareci")){
                    çağrılacak_idareciler.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else if (çağrilan.Contains("öğretmen")){
                    çağrılacak_öğretmenler.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else if (çağrilan.Contains("öğrenci")){
                    çağrılacak_öğrenciler.RemoveAt(dataGridView1.CurrentRow.Index);
                }

            }
        }

        private void cmbox_idare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
