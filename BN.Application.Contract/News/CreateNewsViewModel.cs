using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BN.Application.Contract.News
{
    public class CreateNewsViewModel
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public int NewsCategoryId { get; set; }

    }
}
