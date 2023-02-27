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
    public partial class FrmCategoria : Form
    {
        string stringConexao = "" +
        "data source=localhost;" +
        "initial Catalog= MiniprojetoT13wgt;"+
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
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtObs.Text = "";
            txtDescricao.Text = "";
            txtCodigo.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)//botão excluir
        {
            string sql = "delete from Categoria where id_Categoria= " + txtCodigo.Text;


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

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "insert into Categoria" +
             "(" +
             "nome_Categoria," +
               " descricao_Categoria," +
               " obs_Categoria," +
               " status_Categoria" +
               ")" +
                " values" +
                "(" +
                "'" + txtNome.Text + "'," +
                "'" + txtDescricao.Text + "'," +
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
                    MessageBox.Show("Cadastro realizado com sucesso");
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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update Categoria set" +

              " nome_Categoria= '" + txtNome.Text + "'," +
              " descricao_Categoria='" + txtDescricao.Text + "'," +
              " obs_Categoria='" + txtObs.Text + "'," +
              " status_Categoria='" + cboStatus.SelectedItem + "'" +
              " where id_Categoria=" + txtCodigo.Text;


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

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from Categoria where id_Categoria=" + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader Reader;
            conexao.Open();
            try
            {
                Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {

                    txtNome.Text = Reader[1].ToString();
                    txtDescricao.Text = Reader[2].ToString();
                    txtObs.Text = Reader[3].ToString();
                    cboStatus.SelectedItem = Reader[4].ToString();
                }
                else
                {
                    MessageBox.Show("codigo de Categoria inexistente!");
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
    }
}
