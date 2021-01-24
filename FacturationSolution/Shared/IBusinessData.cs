using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacturationSolution.Shared
{
    public interface IBusinessData
    {
        IEnumerable<FactureClient> Factures { get; }
        public void AddFacture(FactureClient facture);
        public int CaDu { get; }
        public int CaSuppose { get; }

    }
}
