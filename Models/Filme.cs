﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage ="O título do filme é obrigatório")]
    [MaxLength(255, ErrorMessage ="O tamanho do título não pode exceder 255 caractéres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caractéres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(70, 600, ErrorMessage ="A duração do filme deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
