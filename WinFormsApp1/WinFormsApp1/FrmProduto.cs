using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class FrmProduto : Form
    {
        string stringConexao = "" +
            "data source=localhost;" +
            "initial Catalog= MiniprojetoT13wgt;" +
            "User ID=sa;" +
            "password=123456";
        //"data source=DESKTOP-UKENASA\\SQLEXPRESS;" +
        //"initial catalog= MiniProjeto;" +
        //"User ID=admwellington;" +
        //"password=elaine1988";

        private void testarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
                Application.Exit();

            }

        }

        public FrmProduto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btolimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            cboIdProduto.Text = "-1";
            txtQtde.Text = "";
            txtVcusto.Text = "";
            txtVvenda.Text = "";
            cboStatus.Text = "";
            txtDescricao.Text = "";
            txtObs.Text = "";
            txtCodigo.Focus();
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from Produto where id_Produto= " + txtCodigo.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados exluidos com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update Produto set" +

             " nome_Produto= '" + txtNome.Text + "'," +
             " valorcusto_Produto='" + txtVcusto.Text + "'," +
             " valorvenda_Produto='" + txtVvenda.Text + "'," +
             " descricao_Produto='" + txtDescricao.Text + "'," +
             " qtde_Produto='" + txtQtde.Text + "'," +
             " datacadastro_Produto='" + txtDataCadastro.Text + "'," +
             " obs_Produto='" + txtObs.Text + "'," +
             " status_Produto='" + cboStatus.SelectedItem + "'" +
             " where id_Produto=" + txtCodigo.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados alterados com sucesso.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoCadastro_Click(object sender, EventArgs e)
        {
            string sql = "insert into Produto" +
            "(" +
              " nome_Produto," +
              " valorcusto_Produto," +
              " valorvenda_Produto," +
              " descricao_Produto," +
              " qtde_Produto," +
              " datacadastro_Produto," +
              " obs_Produto," +
              " status_Produto" +
              ")" +
               " values" +
               "(" +
               "'" + txtNome.Text + "'," +
               "'" + txtVcusto.Text + "'," +
               "'" + txtVvenda.Text + "'," +
               "'" + txtDescricao.Text + "'," +
               "'" + txtQtde.Text + "'," +
               "'" + txtDataCadastro.Text + "'," +
               "'" + txtObs.Text + "'," +
               "'" + cboStatus.SelectedItem + "'" +
               ")";
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro de Produto realizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
