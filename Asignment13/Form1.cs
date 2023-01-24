using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNWelcome_Click(object sender, EventArgs e)
        {
            //من فضلك يا يوسف اقرأ الكود بعناية حتى التعليقات علشان تفهم مقاصدي جيدا
            try
            {
                if (string.IsNullOrEmpty(TXTName.Text) && string.IsNullOrEmpty(TXTAge.Text))
                {
                    MessageBox.Show("لا يمكن ترك أماكن الكتابة خالية");
                }
                else if (string.IsNullOrEmpty(TXTName.Text))
                {
                    MessageBox.Show("لا يمكن ترك مربع الاسم خاليا");
                }
                else if (string.IsNullOrEmpty(TXTAge.Text))
                {
                    MessageBox.Show("لا يمكن ترك مربع العمر خاليا");
                }
                else
                {
                    MessageBox.Show("مرحبا يا " + TXTName.Text.Trim() + "، " + "إن عمرك هو: " + int.Parse(TXTAge.Text.Trim())+"عاما، متعك الله بالصحة والعافية");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("من فضلك أدخل عمرك بالأرقام الصحيحة فقط");
            }
            //على فكرة كان ممكن أعمل الكود اللي جاي  من غير finally بس حبيت اختبر نفسي هل أنا فاهم finally واللا لا
            finally
            {
                TXTName.Clear();
                TXTAge.Clear();
                TXTName.Focus();
            }
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTName.Text) || string.IsNullOrEmpty(TXTAge.Text))
            {                
                if (MessageBox.Show("هل أنت متأكد حقاً من رغبتك في الخروج؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                {
                    MessageBox.Show("شكرا لاستخدامك هذا البرنامج، جاري الخروج... مع السلامة");
                    Application.Exit();
                }
                else
                {
                    TXTName.Focus();
                }
            }
            else
            {
                MessageBox.Show("لا يمكن الخروج الآن، بسبب وجود بعض البيانات، من فضلك قم بمراجعتها ثم مسحها إذا أردت الخروج ثم أعد المحاولة");
                TXTName.Focus();
            }
        }
    }
}
