using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace İdareDeskstop
{
    public partial class Form1 : Form
    {

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "qlDUgLSDUYM1OqcOnlecbAEDhbFWJI8MCMUtZpYU",
            BasePath = "https://kkfldatabase-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        
       
        public Form1()
        {
            InitializeComponent();
        }

        List<İdareciler> idareciler ;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("There was an error");
            }




                FirebaseResponse res= client.Get(@"AdministrationList");
                Dictionary<string, İdareciler> data = JsonConvert.DeserializeObject<Dictionary<string, İdareciler>>(res.Body.ToString());
                idareciler = new List<İdareciler>(data.Values);
            



        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            bool kontrol = false;

            foreach(İdareciler idareci in idareciler)
            {
                if (txt_sifre.Text.ToLower() ==$"{idareci.idaresirano}{idareci.idareisim.ToLower()}")
                {
                    ÇağırmaEkranı çağırmaEkranı = new ÇağırmaEkranı(idareciler);
                    this.Hide();
                    çağırmaEkranı.Show();
                    kontrol = true;
                    break;
                }

            }
            if(kontrol==false)
            {
                MessageBox.Show("Giriş Bilginiz Hatalıdır");
            }

           
        }
    }
}
