using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CamadaModelos;
using System.Data;
using System.Data.OleDb;


namespace CamadaDados
{
    public class ctlEmpresa
    {
        public bool EmpresaPesquisar(string CNPJ)
        {
            bool RetornoPesquisar = false;
            return RetornoPesquisar;
        }

        public static bool VerificarDuplicidade(string CNPJ)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string qexiste = "select count(1) from tb_empresas where CNPJ = @CNPJ";
            OleDbCommand cmdver = new OleDbCommand(qexiste, ConexaoDB);

            cmdver.CommandType = CommandType.Text;
            OleDbParameter pmtcnpj = cmdver.CreateParameter();
            pmtcnpj.ParameterName = "@CNPJ";
            pmtcnpj.DbType = DbType.String;
            pmtcnpj.Value = CNPJ;
            cmdver.Parameters.Add(pmtcnpj);

            int verif = (int)cmdver.ExecuteScalar();
            if (verif > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CadastrarEmpresa(string CNPJ, string Nome, string Telefone)
        {
            bool RetornoInserir = false;
            return RetornoInserir;
        }

        public bool CadastrarEmpresaMDL(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "insert into tb_empresas(CNPJ, Nome, Telefone) values(@CNPJ, @Nome, @Telefone)";
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            var pmtCNPJ = cmd.CreateParameter();
            pmtCNPJ.ParameterName = "@CNPJ";
            pmtCNPJ.DbType = DbType.String;
            pmtCNPJ.Value = _mdlEmpresa.CNPJ;
            cmd.Parameters.Add(pmtCNPJ);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = _mdlEmpresa.Nome;
            cmd.Parameters.Add(pmtNome);

            var pmtTelefone = cmd.CreateParameter();
            pmtTelefone.ParameterName = "@Telefone";
            pmtTelefone.DbType = DbType.String;
            pmtTelefone.Value = _mdlEmpresa.Telefone;
            cmd.Parameters.Add(pmtTelefone);

            if (cmd.ExecuteNonQuery() > 0)
            {
                ConexaoDB.Close();
                return true;
            }
            else
            {
                ConexaoDB.Close();
                return false;
            }
        }

        public DataTable EmpresaPesquisarMDL(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "select * from tb_empresas where ";

            if(_mdlEmpresa.FiltroAbrirChamado == "CNPJ")
            {
                Query += "cnpj LIKE \"%\" + @Filtro + \"%\"";
            }
            else if(_mdlEmpresa.FiltroAbrirChamado == "Nome")
            {
                Query += "nome LIKE \"%\" + @Filtro + \"%\"";
            }
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtFiltro = cmd.CreateParameter();
            pmtFiltro.ParameterName = "@Filtro";
            pmtFiltro.DbType = DbType.String;
            pmtFiltro.Value = _mdlEmpresa.FiltrotxtProcurar;
            cmd.Parameters.Add(pmtFiltro);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            return empresas;
        }

        public bool EmpresaAbrirChamado(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();


            string Query = "insert into tb_chamados(aberto, fk_idempresa, data) values(@aberto, @fk_idempresa, @data)";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);
       //     cmd.CommandType = CommandType.Text;

            var pmtAbrirChamado = cmd.CreateParameter();
            pmtAbrirChamado.ParameterName = "@aberto";
            pmtAbrirChamado.DbType = DbType.String;
            pmtAbrirChamado.Value = "1";
            cmd.Parameters.Add(pmtAbrirChamado);

            var pmtfkidempresa = cmd.CreateParameter();
            pmtfkidempresa.ParameterName = "@fk_idempresa";
            pmtfkidempresa.DbType = DbType.String;
            pmtfkidempresa.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtfkidempresa);

            DateTime dataAtu = DateTime.Now;
            var pmtData = cmd.CreateParameter();
            pmtData.ParameterName = "@data";
            pmtData.DbType = DbType.String;
            pmtData.Value = dataAtu;
            cmd.Parameters.Add(pmtData);

             if (cmd.ExecuteNonQuery() > 0)
            {
                ConexaoDB.Close();
                return true;
            }
            else
            {
                ConexaoDB.Close();
                return false;
            }
        }

        public DataTable CarregarOutrosChamados(CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "select * from tb_chamados where fk_idempresa=@empresaid AND aberto='0' order by dataFinal desc";
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtempresa = cmd.CreateParameter();
            pmtempresa.ParameterName = "@empresaid";
            pmtempresa.DbType = DbType.String;
            pmtempresa.Value = _mdlEmpresa.txtEmpresaID;
            cmd.Parameters.Add(pmtempresa);
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            return empresas;

        }

        public bool FinalizarChamado(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "update tb_chamados " +
                "set " +
                "aberto=@aberto, " +
                "fk_idtecnico=@tec, " +
                "atendimento=@atendimento, " +
                "resumo=@resumo, " +
                "dataFinal=@dataFinal, " +
                "telefone=@telefone, " +
                "contato=@contato " +
                "where id = @id";
           
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);
            cmd.CommandType = CommandType.Text;

            var pmtFecharChamado = cmd.CreateParameter();
            pmtFecharChamado.ParameterName = "@aberto";
            pmtFecharChamado.DbType = DbType.String;
            pmtFecharChamado.Value = "0";
            cmd.Parameters.Add(pmtFecharChamado);

            var pmttec = cmd.CreateParameter();
            pmttec.ParameterName = "@tec";
            pmttec.DbType = DbType.String;
            pmttec.Value = _mdlEmpresa.cbbTecnico;
            cmd.Parameters.Add(pmttec);

            var pmtAtendimento = cmd.CreateParameter();
            pmtAtendimento.ParameterName = "@atendimento";
            pmtAtendimento.DbType = DbType.String;
            pmtAtendimento.Value = _mdlEmpresa.Atendimento;
            cmd.Parameters.Add(pmtAtendimento);

            var pmtResumo = cmd.CreateParameter();
            pmtResumo.ParameterName = "@resumo";
            pmtResumo.DbType = DbType.String;
            pmtResumo.Value = _mdlEmpresa.Resumo;
            cmd.Parameters.Add(pmtResumo);

            DateTime dataFim = DateTime.Now;
            var pmtDataF = cmd.CreateParameter();
            pmtDataF.ParameterName = "@dataFinal";
            pmtDataF.DbType = DbType.String;
            pmtDataF.Value = dataFim;
            cmd.Parameters.Add(pmtDataF);

            var pmtTelefone = cmd.CreateParameter();
            pmtTelefone.ParameterName = "@telefone";
            pmtTelefone.DbType = DbType.String;
            pmtTelefone.Value = _mdlEmpresa.Telefone;
            cmd.Parameters.Add(pmtTelefone);

            var pmtContato = cmd.CreateParameter();
            pmtContato.ParameterName = "@contato";
            pmtContato.DbType = DbType.String;
            pmtContato.Value = _mdlEmpresa.Contato;
            cmd.Parameters.Add(pmtContato);

            var pmtID = cmd.CreateParameter();
            pmtID.ParameterName = "@id";
            pmtID.DbType = DbType.String;
            pmtID.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtID);

            cmd.ExecuteNonQuery();
            int resultado = cmd.ExecuteNonQuery();
            ConexaoDB.Close();
            return resultado > 0; 
        } 

        public DataTable ListarChamado(CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "select tb_empresas.id, tb_empresas.nome, tb_chamados.fk_idempresa, tb_chamados.data, tb_chamados.id " +
                           "FROM tb_empresas" +
                           " inner join tb_chamados " +
                           "on tb_chamados.fk_idempresa = tb_empresas.id where tb_chamados.aberto = '1' order by tb_chamados.id desc";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable lista = new DataTable();
            da.Fill(lista);
            return lista;

        }

        public DataTable ListagemResultado(CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica\Dropbox\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosmdb.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "select * from tb_chamados ";

            if (_mdlEmpresa.FiltrotxtProcurar == "" && _mdlEmpresa.cbbTecnico != "Todos")
            {
                Query += "where fk_idtecnico=@tecnico";

                OleDbCommand cmdT = new OleDbCommand(Query, ConexaoDB);

                var pmtTecnicoSelecionadoT = cmdT.CreateParameter();
                pmtTecnicoSelecionadoT.ParameterName = "@tecnico";
                pmtTecnicoSelecionadoT.DbType = DbType.String;
                pmtTecnicoSelecionadoT.Value = _mdlEmpresa.cbbTecnico;
                cmdT.Parameters.Add(pmtTecnicoSelecionadoT);

                OleDbDataAdapter daT = new OleDbDataAdapter(cmdT);
                DataTable empresasT = new DataTable();
                daT.Fill(empresasT);
                return empresasT;

            }
            else if (_mdlEmpresa.FiltrotxtProcurar == "" && _mdlEmpresa.cbbTecnico == "Todos")
            {
                Query += "";
            }
            else if (_mdlEmpresa.cbbTecnico == "Todos")
            {
                Query += "where fk_idempresa=@EmpresaSelecionada";
            }

            else 
            {
                Query += "where fk_idempresa=@EmpresaSelecionada AND fk_idtecnico=@tecnico";
            }


            Query += " order by data desc";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            var pmtEmpresaSelecionada = cmd.CreateParameter();
            pmtEmpresaSelecionada.ParameterName = "@EmpresaSelecionada";
            pmtEmpresaSelecionada.DbType = DbType.String;
            pmtEmpresaSelecionada.Value = _mdlEmpresa.FiltrotxtProcurar;
            cmd.Parameters.Add(pmtEmpresaSelecionada);

            var pmtTecnicoSelecionado = cmd.CreateParameter();
            pmtTecnicoSelecionado.ParameterName = "@tecnico";
            pmtTecnicoSelecionado.DbType = DbType.String;
            pmtTecnicoSelecionado.Value = _mdlEmpresa.cbbTecnico;
            cmd.Parameters.Add(pmtTecnicoSelecionado);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            return empresas;


        }


        /* public void AtenderChamado()
        {
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                mdlChamados.Chamado.Resposta = reader["chamado_resposta"].ToString();
                mdlChamados.Chamado.Status = reader["chamado_status"].ToString();
                mdlChamados.Chamado.Descricao = reader["descricao"].ToString();
                mdlChamados.Chamado.Motivo = reader["descricao_motivo"].ToString();
                mdlChamados.Chamado.Empresa = reader["nome_empresa"].ToString();
                mdlChamados.Chamado.NomeUsuario = reader["nome_usuario"].ToString();
                mdlChamados.Chamado.Aberto = reader["Aberto"].ToString();
                mdlChamados.Chamado.Fechado = reader["Fechado"].ToString();
            }
            reader.Close();
            conexao.Fechar();

        } */
    }


}
