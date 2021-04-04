using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMivies.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This Field is Required.")]
        public string Name { get; set; }

        public List<MoviesGenees> MoviesGenees { get; set; } = new List<MoviesGenees>();
    }
}
