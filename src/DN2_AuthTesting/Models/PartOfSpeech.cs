using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DN2_AuthTesting.Models
{
    [Table("PartofSpeeches")]
    public class PartOfSpeech
    {
        [Key]
        public int PartOfSpeechId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Word> Words { get; set; }

    }
}
