/*
 * Created by SharpDevelop.
 * User: zied
 * Date: 27-May-19
 * Time: 18:51
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
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string StrCnn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base.mdb"; //Création de l'objet de connexion
            OleDbConnection  cnn = new OleDbConnection(StrCnn);
            //ouverture de la connexion
            cnn.Open();    
            String req="SELECT  * FROM identif";
                     OleDbCommand cmd=new OleDbCommand(req,cnn);
                     OleDbDataAdapter DA =new OleDbDataAdapter();
                     DataTable dt =new DataTable();
                     DA.SelectCommand=cmd;
                    
                     DA.Fill(dt);
                     dataGridView1.DataSource=dt;
                     cnn.Close();
			
		}
	}
}
