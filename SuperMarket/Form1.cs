using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket
{
    public partial class Form1 : Form
    {
        SqlConnection cn=new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBconnection dbcon =new DBconnection();
        public Form1()
        {
            InitializeComponent();
            CustomizedDesighn();
            cn = new SqlConnection(dbcon.Myconnection());
            cn.Open();
            MessageBox.Show("Database connected");
        }
        #region panelSlide
        //כדי להגדיר שההתנהגות הזאת חלה אך ורק על הפקד הזה
        private void CustomizedDesighn()
        {
            panelSubPrudect.Visible = false;
            panelSubRecord.Visible = false;
            panelSubStock.Visible = false;
            panelSubSetting.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelSubPrudect.Visible == true)
                panelSubPrudect.Visible = false;
            if(panelSubRecord.Visible == true)
                panelSubRecord.Visible = false;
            if(panelSubStock.Visible == true)
                panelSubStock.Visible = false;
            if(panelSubSetting.Visible == true)
                panelSubSetting.Visible = false;
        }
        private void ShowSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }
        #endregion panelSlide

        private Form activeForm = null;

        //Defines a function named openChildForm that takes a form (childForm) as a parameter,
        //which is intended to be opened within the main window.
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            childForm.TopLevel = false;

            // הופך את הטופס לתת-טופס (כדי שיוכל להיות מוטמע בתוך פאנלמייו
            //כאשר הטופ לבל מוגדר שקר, הטופס לא יהיה חלון עצמאי אלא חלק מהטופס הראשי.

            childForm.FormBorderStyle = FormBorderStyle.None;

            // מסיר את המסגרת והכותרת של הטופס החדש, כך שהוא ישתלב בצורה חלקה בתוך המיין פאנל

            childForm.Dock = DockStyle.Fill;

            //מותח את הטופס החדש כך שימלא את כלמיין פנאל
            // המשמעות היא שהוא יתאים עצמו לגודל הפאנל, במקום להיות בגודל קבוע.

            lblTitle.Text = childForm.Text;


            panelMain.Controls.Clear();

            // מסיר את כל הבקרות (Controls) בתוך panelMain, כדי לוודא שלא נצברים טפסים ישנים.

            panelMain.Controls.Add(childForm);

            //מוסיף את הטופס החדש שהוא צ'ילדרן פורם לתוך הפאנל מיין כך שיוצג בתוך הפאנל

            panelMain.Tag = childForm;

            lblTitle.Text = childForm.Text;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubPrudect);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
            HideSubMenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
            HideSubMenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            HideSubMenu();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            HideSubMenu();

        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            HideSubMenu();

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            HideSubMenu();

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubRecord);
        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnPostRecord_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubSetting);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
    }
}