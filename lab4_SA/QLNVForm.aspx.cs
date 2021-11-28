using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4_SA
{
    public partial class QLNVForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ChitietNV> nhanviens = new NV_BUS().laydanhsach();
            GridView1.DataSource = nhanviens;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String keyword = TextBox1.Text.Trim();
            List<ChitietNV> nhanviens = new NV_BUS().Search(keyword);
            GridView1.DataSource = nhanviens;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Manv = int.Parse(GridView1.SelectedRow.Cells[1].Text.Trim());
            ChitietNV nhanvien =new NV_BUS().Getdetails(Manv);
            if(nhanvien !=null)
            {
                TextBox2.Text = nhanvien.Manv.ToString();
                TextBox3.Text = nhanvien.Ten;
                TextBox4.Text = nhanvien.Chucvu;
                TextBox5.Text = nhanvien.Phongban;
                TextBox6.Text = nhanvien.Chuthich;
            }    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ChitietNV newnhanvien = new ChitietNV()
            {
                Manv = 0,
                Ten = TextBox3.Text.Trim(),
                Chucvu = TextBox4.Text.Trim(),
                Phongban = TextBox5.Text.Trim(),
                Chuthich = TextBox6.Text.Trim()
            };

            bool result = new NV_BUS().Addnew(newnhanvien);
            if(result)
            {
                List<ChitietNV> nhanviens = new NV_BUS().laydanhsach();
                GridView1.DataSource = nhanviens;
                GridView1.DataBind();
            }    
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int Manv = int.Parse(TextBox2.Text.Trim());
            bool result = new NV_BUS().Delete(Manv);
            if (result)
            {
                List<ChitietNV> nhanviens = new NV_BUS().laydanhsach();
                GridView1.DataSource = nhanviens;
                GridView1.DataBind();
            }else
            {
                WebMsgBox.Show("SORRY BAE");
            }    
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ChitietNV newnhanvien = new ChitietNV()
            {
                Manv = int.Parse(TextBox2.Text.Trim()),
                Ten = TextBox3.Text.Trim(),
                Chucvu = TextBox4.Text.Trim(),
                Phongban = TextBox5.Text.Trim(),
                Chuthich = TextBox6.Text.Trim()
            };

            bool result = new NV_BUS().Update(newnhanvien);
            if (result)
            {
                List<ChitietNV> nhanviens = new NV_BUS().laydanhsach();
                GridView1.DataSource = nhanviens;
                GridView1.DataBind();
            }
            else
            {
                WebMsgBox.Show("SORRY BAE");
            }
        }
    }
}