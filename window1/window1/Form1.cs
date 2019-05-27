/*
 * Created by SharpDevelop.
 * User: zied
 * Date: 27-May-19
 * Time: 17:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
namespace window1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button3Click(object sender, EventArgs e)
		{
string StrCnn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base.mdb"; //Création de l'objet de connexion
            OleDbConnection  cnn = new OleDbConnection(StrCnn);
            //ouverture de la connexion
            String a,b,c;
            a=textBox1.Text;
            b=textBox2.Text;
            c=textBox3.Text;    
         try{
                cnn.Open();
                String req="SELECT  * FROM identif WHERE titre = '"+a+"'";
         OleDbCommand cmd=new OleDbCommand(req,cnn);
         OleDbDataReader dr =cmd.ExecuteReader();
         if(dr.HasRows==true){
             while(dr.Read()){
                 textBox3.Text=dr.GetString(1);
                 textBox2.Text=dr.GetString(2);
             }
            }else MessageBox.Show("le premier  champs n'existe pas  ");
                     dr.Close();
         }catch(Exception ex)
            {MessageBox.Show(ex.Message+"errrrur");}
            finally
            { 
                cnn.Close();}
			
		}
	}
}
