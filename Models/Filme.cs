using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Filme {


    [Key]
    public int FilmeId { get; set; }

    [MaxLength(100)]
    public string Titulo { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DataExibicao { get; set; }

    [MaxLength(100)]
    public string Genero { get; set; }

    public decimal Preco { get; set; }

}