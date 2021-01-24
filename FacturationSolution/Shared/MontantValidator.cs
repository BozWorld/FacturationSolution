using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationSolution.Shared
{
    class MontantValidator : ValidationAttribute
    {
        private int montantDu { get; set; }
        private int montantsRegler { get; set; }
        public override bool IsValid(object value )
        {
            if (value == null)
                return false;
            if (montantDu < montantsRegler)
                return false;
            return true;
        }
    }
}
