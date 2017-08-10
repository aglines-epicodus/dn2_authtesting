using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DN2_AuthTesting.Models
{
    [Table("Words")]
    public class Word
    {
        [Key]
        public int WordId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PartOfSpeechId { get; set; }
        public virtual PartOfSpeech PartOfSpeech { get; set; }


    }
}
