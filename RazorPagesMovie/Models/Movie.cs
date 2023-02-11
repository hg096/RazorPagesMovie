using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;


public class Movie
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3, ErrorMessage = "제목을 3자이상 60자 이하로 입력해주세요")]
    [Required (ErrorMessage = "제목을 입력해주세요")]
    // public string? Title { get; set; } // string 다음의 물음표는 속성이 null 허용임을 나타냄
    public string Title { get; set; } = string.Empty;

    // [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string Genre { get; set; } = string.Empty;

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    public string Rating { get; set; } = string.Empty;

}
