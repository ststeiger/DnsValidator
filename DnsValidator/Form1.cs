
using System.Windows.Forms;


namespace DnsValidator
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void btnDnDns_Click(object sender, System.EventArgs e)
        {
            DnDnsTest.DnDnsForwardLookup();
        }



        private void btnARSoft_Click(object sender, System.EventArgs e)
        {
            ArSoftTest.ForwardLookup();
        }


        private void btnCheckDomainName_Click(object sender, System.EventArgs e)
        {
            Utils.DomainExists("fdasfasdfasdfjfalsdf.com");
        }


    }


}
