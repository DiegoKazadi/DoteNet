﻿using System;

public class Acao
{

    public string codigo { get; private set; }
    public int quantidade { get; private set; }

    public Acao(string codigo, int quantidade)
    {
        this.codigo = codigo;
        this.quantidade = quantidade;

    }
}