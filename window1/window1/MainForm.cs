/*
 * Created by SharpDevelop.
 * User: zied
 * Date: 27-May-19
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace window1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		String b,a;
            a=textBox1.Text; b=textBox2.Text;
            //Création de la chaine de connexion
		string StrCnn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Base.mdb"; //Création de l'objet de connexion
		OleDbConnection  cnn = new OleDbConnection(StrCnn);
		//ouverture de la connexion
					try{ 
			    cnn.Open();
			string req="SELECT COUNT(*)  from T1 where login='"+a+"' and password='"+b+"'";
			OleDbCommand cmd=new OleDbCommand(req,cnn);
			int n=Convert.ToInt32(cmd.ExecuteScalar());
					if(n==1){
					    Form1 F=new Form1();
					    F.Show();
					    this.Hide();
					}else MessageBox.Show(" adress ou bien mot de pass faux ");}
			            catch(Exception ex)
			            {MessageBox.Show(ex.Message+"  errrrrreerr");}
			            finally
			            {
			                cnn.Close();}
	
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		//Création de la chaine de connexion
		string StrCnn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Base.mdb"; //Création de l'objet de connexion
		OleDbConnection  cnn = new OleDbConnection(StrCnn);
		//ouverture de la connexion
				try{
				    cnn.Open();
						string req="insert into T1 values('"+textBox1.Text+"','"+textBox2.Text+"')";
						OleDbCommand cmd=new OleDbCommand(req,cnn);
						cmd.ExecuteNonQuery();
						MessageBox.Show("ajout avec succès");}
				            catch(Exception ex)
				            {MessageBox.Show(ex.Message+"errrrur");}
				            finally
				            {
				                cnn.Close();}
			
		}
	}
}
