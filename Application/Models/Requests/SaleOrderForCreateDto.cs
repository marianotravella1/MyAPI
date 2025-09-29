using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class SaleOrderForCreateDto
    {
        public int UserId { get; set; }               // ID del usuario que hace la orden
        public List<int> ProductIds { get; set; } = []; // IDs de productos en la orden
    }
}
