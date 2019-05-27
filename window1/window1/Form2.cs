/*
 * Created by SharpDevelop.
 * User: zied
 * Date: 27-May-19
 * Time: 18:36
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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
		string StrCnn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base.mdb"; //Création de l'objet de connexion
            OleDbConnection  cnn = new OleDbConnection(StrCnn);
            //ouverture de la connexion
            cnn.Open();    
            String req="SELECT  * FROM identif";
                     OleDbCommand cmd=new OleDbCommand(req,cnn);
                     OleDbDataAdapter DA =new OleDbDataAdapter();
                     DA.SelectCommand=cmd;
                     DataSet DS=new DataSet();
                     DA.Fill(DS,"identif");
                    textBox1.Text=DS.Tables["identif"].Rows[comboBox1.SelectedIndex]["age"].ToString();
                    textBox2.Text=DS.Tables["identif"].Rows[comboBox1.SelectedIndex]["annee"].ToString();   
			
		}
		
		void Form2Load(object sender, EventArgs e)
		{
			string StrCnn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Base.mdb"; //Création de l'objet de connexion
            OleDbConnection  cnn = new OleDbConnection(StrCnn);
            //ouverture de la connexion
            cnn.Open();    
            String req="SELECT  * FROM identif";
                     OleDbCommand cmd=new OleDbCommand(req,cnn);
                     OleDbDataAdapter DA =new OleDbDataAdapter();
                     DA.SelectCommand=cmd;
                     DataSet DS=new DataSet();
                     DA.Fill(DS,"identif");
                    
                     comboBox1.DataSource=DS.Tables["identif"];
                    comboBox1.DisplayMember="titre"; 
                    textBox1.Text=DS.Tables["identif"].Rows[comboBox1.SelectedIndex]["age"].ToString();
                    textBox2.Text=DS.Tables["identif"].Rows[comboBox1.SelectedIndex]["annee"].ToString();

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form3 F3=new Form3();
			F3.Show(); this.Hide();
		}
	}
}
