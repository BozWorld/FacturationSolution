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
        public string client { get; set; }
        [Required]
        public DateTime emission { get; set; }
        [Required]
        public DateTime reglementation { get; set; }
        [Required]
        public int numero { get; set; }
        [Required]
        public int montants_du { get; set; }
        [Required]
        public int montants_regler { get; set; }

        public FactureClient(string client, DateTime emission, DateTime reglementation, int numero, int montants_du, int montantsRegler)
        {
            this.client = client;
            this.emission = emission;
            this.reglementation = reglementation;
            this.numero = numero;
            this.montants_du = montants_du;
            this.montants_regler = montantsRegler;
        }
    }
}
