using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFake.DTOs
{
    public class UpdateCreatorInputModel : SaveCreatorInputModel
    {
        public Guid Id { get; set; }
    }
}
