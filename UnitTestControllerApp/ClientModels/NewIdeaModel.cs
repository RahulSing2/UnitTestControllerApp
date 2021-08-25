using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace UnitTestControllerApp.ClientModels
{
    public class NewIdeaModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, 1000000)]
        public int SessionId { get; set; }
    }
}
