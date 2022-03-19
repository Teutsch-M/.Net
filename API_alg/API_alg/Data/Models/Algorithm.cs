using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static API_alg.Data.Models.Enums;

namespace API_alg.Data.Models
{
    public class Algorithm
    {
        
        public int Id;
        public string Name;
        public string Description;
        public AlgorithmType Type;
        public string Icon;
        public string Url;
        public string AlgorithmNickname;
        public bool IsPublished;
        public DateTime CreationDate;

        public int Id { get; set; }

    }
}
