using FacturationSolution.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace FacturationSolution.Server.Models
{
    public class BusinessDataSQL : IBusinessData, IDisposable
    {
        private SqlConnection cnct;

        public BusinessDataSQL(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            cnct.Dispose();
        }


        void IBusinessData.AddFacture(FactureClient facture) {
            var p = new DynamicParameters();
            p.Add("@Reference", facture.Numero,DbType.String,ParameterDirection.Input);
            p.Add("@Client", facture.Client, DbType.String,ParameterDirection.Input);
            p.Add("@Emission", facture.Emission, DbType.DateTime, ParameterDirection.Input);
            p.Add("@Reglementation", facture.Reglementation, DbType.DateTime, ParameterDirection.Input);
            p.Add("@MontantDu", facture.MontantDu, DbType.DateTime, ParameterDirection.Input);
            p.Add("@MontantRegler", facture.MontantsRegler, DbType.DateTime, ParameterDirection.Input);
            cnct.Execute(@"INSERT INTO facture(Reference,Client,Emission,Reglementation,MontantDu,MontantRegler) VALUES (@reference,@Client,@Emission,@Reglementation,@MontantDu,@MontantsRegler", p);
        }
        public IEnumerable<FactureClient> Factures => cnct.Query<FactureClient>("Select * FROM factures ORDER BY Reglementation DESC");

        public int CaDu => cnct.QuerySingle<int>("Select SUM(MontantDu) FROM factures");

        public int CaSuppose => cnct.QuerySingle<int>("Select SUM(MontantsRegler) FROM factures");
    }
}
