using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBank
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BankAccount ba = new BankAccount();
            ba.accountNumber = 12345;
            ba.balance = 123.45f;

            Label1.Text = ba.accountNumber.ToString();
        }
    }
}
