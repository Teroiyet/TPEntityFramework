using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_webApplication.ViewModels
{
    public class CreateViewModel
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public IFormFile Photo { get; set; }

    }
}
