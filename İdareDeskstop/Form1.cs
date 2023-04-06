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

        Form1 form1 = new Form1();
        ÇağırmaEkranı çağırmaEkranı= new ÇağırmaEkranı();
        public Form1()
        {
            InitializeComponent();
        }

        List<İdareciler> idareciler = new List<İdareciler>();
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




            for(int i=0;i<5;i++)
            {
                FirebaseResponse res= client.Get(@"AdministrationList" + ("İdareci" + i));

                İdareciler idr = res.ResultAs<İdareciler>();

                idareciler.Add(idr);
            }



        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            bool kontrol = false;

            foreach(İdareciler idareci in idareciler)
            {
                if (txt_sifre.Text ==$"{idareci.idaresirano}{idareci.idareisim}")
                {
                    form1.Hide();
                    çağırmaEkranı.Show();
                    kontrol = true;
                    break;
                }
            }
            if(kontrol=false)
            {
                MessageBox.Show("Giriş Bilginiz Hatalıdır");
            }

           
        }
    }
}
