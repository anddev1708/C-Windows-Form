using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFacebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wvMain.Navigate("www.facebook.com");
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var accessToken = "EAACEdEose0cBAIUAnZCRckSvPeQmWDVXdfOz6N5UiFqaSj8ZBIS3hN5EaZAygCxbOhwg87hcJypoQ87dhF5ZCpdqvgZAk2BfGFgl8pJy07qSCdW5ZB3cLH8EZCV3kcGZCYdLJ8npTssfBZAN58QarTpoZB60DVTx0g4E5f7LOZCiINNzckrgTvAz46e0Oo9JBvZBXmFiQFXt7A9vY1CyXvQjJn4ZA";


            var fb = new FacebookClient(accessToken);
            string url = string.Format("{0}/{1}", "100003675982767", "feed");
            var argList = new Dictionary<string, object>();
            argList["message"] = "Hello!";
            fb.Post(url, argList);
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            String email = "loicuoi@gmail.com";
            String password = "@#h4ck3r#@";

            wvMain.Document.GetElementById("email").InnerText = email;
            wvMain.Document.GetElementById("pass").InnerText = password;
            wvMain.Document.Forms[0].InvokeMember("submit");
        }

        private void wvMain_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            label1.Text = wvMain.Url.AbsolutePath.ToString();
        }

        private void btnGetFriend_Click(object sender, EventArgs e)
        {

        }
    }
}
