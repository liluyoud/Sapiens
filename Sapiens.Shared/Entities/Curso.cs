﻿using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Curso : Entidade
{
    [StringLength(100)]
    public string? Nome { get; set; }

    public int? CargaHoraria { get; set; }

    public TipoCurso Tipo { get; set; }

    public Professor? Coordenador { get; set; }

    public override string ToString()
    {
        return Nome ?? "";
    }

    public List<Disciplina> Disciplinas =>
        Context!.Disciplinas.Where(d => d.Curso!.Equals(this)).ToList();
}
