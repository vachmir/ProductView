using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductView
{
    public partial class ProdProvider : Form
    {
        public ProdProvider()
        {
            InitializeComponent();
        }

        private void prodProviderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodProviderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.warehouseDataSet2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDataSet2.ProdProvider' table. You can move, or remove it, as needed.
            this.prodProviderTableAdapter.Fill(this.warehouseDataSet2.ProdProvider);
            // TODO: This line of code loads data into the 'warehouseDataSet1.ProdProvider' table. You can move, or remove it, as needed.
            this.prodProviderTableAdapter.Fill(this.warehouseDataSet2.ProdProvider);
            // TODO: This line of code loads data into the 'warehouseDataSet.ProdProvider' table. You can move, or remove it, as needed.
            this.prodProviderTableAdapter.Fill(this.warehouseDataSet2.ProdProvider);
            // TODO: This line of code loads data into the 'warehouseDataSet.ProdProvider' table. You can move, or remove it, as needed.
            this.prodProviderTableAdapter.Fill(this.warehouseDataSet2.ProdProvider);
        }       
               

        private void prodProviderBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.prodProviderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.warehouseDataSet2);
        }

        private void prodProviderBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.prodProviderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.warehouseDataSet2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void providerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }      

        private void providerNameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void serialNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodProviderBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.prodProviderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.warehouseDataSet2);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=vachmirlaptop;Initial Catalog=Warehouse;Integrated Security=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("Insert Into ProdProvider values( @ProviderName, @SerialNumber)", conn);
            //comm.Parameters.AddWithValue("@ID", int.Parse(iDTextBox.Text));
            comm.Parameters.AddWithValue("@ProviderName", providerNameTextBox.Text);
            comm.Parameters.AddWithValue("@SerialNumber", serialNumberTextBox.Text);
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Completed Successfully");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=vachmirlaptop;Initial Catalog=Warehouse;Integrated Security=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * From ProdProvider", conn);
        }
    }
}
