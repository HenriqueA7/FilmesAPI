﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(255, ErrorMessage = "O tamanho do título não pode exceder 255 caractéres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caractéres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração do filme deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
