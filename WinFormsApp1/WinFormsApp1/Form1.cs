using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string stringConexao = "" +
            "data source=localhost;" +
            "initial Catalog= MiniprojetoT13wgt;"+
            "User ID=sa;" +
            "password=123456";

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
                    MessageBox.Show("Erro:"+ ex.ToString());
                    Application.Exit();
                    
            }
                
        }       
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testarConexao();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            cboStatus.SelectedIndex = -1;
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
            txtObs.Text = "";
            txtCodigo.Focus();
           
        }

        private bool validar()
        {
            if (cboStatus.Text == "")
            {
                MessageBox.Show("Erro.Preencha o campo Status");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("erro,Preencha o campo nome");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Erro,Preencha o campo senha");
                txtSenha.Text = "";
                txtSenha.Focus();
                return false;
            }
            if(txtConfirmarSenha.Text != txtSenha.Text )
            {
               
                    {
                    MessageBox.Show("Erro, Confirmar senha deve ser igual a senha ");
                    txtConfirmarSenha.Text = "";
                    txtConfirmarSenha.Focus();
                    return false;
                    }
            }
                return true;
        }
        private void btoConfirmar_Click(object sender, EventArgs e)
        {
            if (validar())
            { 
            string sql = "insert into Usuario" +
             "(" +
             "nome_Usuario," +
               " login_Usuario," +
               " senha_Usuario," +
               " obs_Usuario," +
               " status_Usuario" +    
               ")" + 
                " values" +
                "(" +
                "'" + txtNome.Text + "'," +
                "'" + txtLogin.Text + "'," +
                "'" + txtSenha.Text + "'," +
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
            }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btoAdd2_Click(object sender, EventArgs e)
        {
            string sql = "insert into Usuario" +
               "(" +
                "nome_Usuario," +
               " login_Usuario," +
               " senha_Usuario," +
               " obs_Usuario," +
               " status_Usuario" +
               ")" +
                " values" +
                "(" +
                "'" + txtNome.Text + "'," +
                "'" + txtLogin.Text + "'," +
                "'" + txtSenha.Text + "'," +
                "'" + txtObs.Text + "'," +
                "'" + cboStatus.SelectedItem + "'" +
                ")Select SCOPE_Identity()"; 

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();
            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO", "codigo gerado" + leitura[0].ToString());
                    txtCodigo.Text = leitura[0].ToString();

                    btoPesquisar.PerformClick();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro" + ex.ToString());
            }
            finally
            {
                conn.Close();
            }



        }
    
        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from Usuario where id_Usuario=" + txtCodigo.Text;  
             
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
                    txtSenha.Text = Reader[2].ToString();
                    txtConfirmarSenha.Text = Reader[3].ToString();
                    txtObs.Text = Reader[4].ToString();
                    cboStatus.SelectedItem = Reader[5].ToString();
                }
                else
                {
                    MessageBox.Show("codigo de usuario inexistente!");
                }
                
            }
           catch(Exception ex)
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
            string sql = "update Usuario set" +

               " nome_Usuario= '" + txtNome.Text + "'," +
               " login_Usuario='" + txtLogin.Text + "'," +
               " senha_Usuario='" + txtSenha.Text + "'," +
               " obs_Usuario='" + txtObs.Text + "'," +
               " status_Usuario='" + cboStatus.SelectedItem + "'" +
               " where id_Usuario=" + txtCodigo.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql,conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();

                int i =cmd.ExecuteNonQuery();
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

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from Usuario where id_Usuario= " + txtCodigo.Text;
            

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql,conexao);
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
            catch(Exception ex)
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
