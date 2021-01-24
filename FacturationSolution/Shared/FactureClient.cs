using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturationSolution.Shared
{
    public class FactureClient
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Client { get; set; }
        [Required]
        public DateTime Emission { get; set; }
        [Required]
        public DateTime Reglementation { get; set; }
        [Required]
        [Range(100, 400,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int? Numero { get; set; }
        [Required]
        public int MontantDu { get; set; }
        [Required]
        public int MontantsRegler { get; set; }

        public FactureClient() { }

        public FactureClient(string client, DateTime emission, DateTime reglementation, int numero, int montants_du, int montantsRegler)
        {
            this.Client = client;
            this.Emission = emission;
            this.Reglementation = reglementation;
            this.Numero = numero;
            this.MontantDu = montants_du;
            this.MontantsRegler = montantsRegler;
        }
    }
}
