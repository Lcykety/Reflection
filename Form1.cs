using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_search.ToString()))
            {
                Type T= Type.GetType(tb_search.Text);
                if(T!= null)
                {
                    Ctors(T);
                    props(T);
                    meths(T);
                   
                    
                }
                else
                {
                    MessageBox.Show($"{tb_search.Text} olduğunuz sınıf bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lütfen bilgi almak istediğiniz sınıfın tam adını giriniz.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private  void Ctors(Type T)
        {
           ConstructorInfo  [] ctors =  T.GetConstructors();
            foreach (ConstructorInfo ctor in ctors)
            {
                lb_ctors.Items.Add(ctor.ToString());
            }
        }
        private void props(Type T)
        {
            PropertyInfo [] props = T.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                lb_props.Items.Add(prop.Name);
            }
        }
        private void meths(Type T)
        {
            MethodInfo[] meths = T.GetMethods();
            foreach (MethodInfo meth in meths)
            {
                lb_meths.Items.Add(meth.ToString());
            }
           

        }

    }
}
