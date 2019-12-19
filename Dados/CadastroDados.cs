using Login.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CadastroDados
    {
        public bool IncluirCadastro(Cadastro cadastro)
        {
            var SqlQuery = $@"INSERT INTO [dbo].[tb_Cadastro]
                              ([Nome]
                              ,[CPF]
                              ,[Endereco]
                              ,[email]
                              ,[telefone]
                              ,[Login]
                              ,[Senha])
                        VALUES {cadastro.Nome}, {cadastro.CPF}, {cadastro.Endereco}, {cadastro.email}, {cadastro.telefone}, {cadastro.Login}, {cadastro.Senha} ";
        }
        
    }
}
