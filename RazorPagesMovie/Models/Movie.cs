using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;


public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; } // string 다음의 물음표는 속성이 null 허용임을 나타냄
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
}
