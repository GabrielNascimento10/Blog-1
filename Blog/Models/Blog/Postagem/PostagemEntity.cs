﻿using Blog.Models.Blog.Autor;
using Blog.Models.Blog.Categoria;
using Blog.Models.Blog.Etiqueta;
using Blog.Models.Blog.Postagem.Revisao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        public string Titulo;
        public AutorEntity Autor;
        public CategoriaEntity Categoria;
<<<<<<< HEAD
=======

        public List <EtiquetaEntity> Etiquetas;
        public List<RevisaoEntity> Revisoes;


>>>>>>> cf9ae31ad0dfadef8f5852c607d34ab3b191f92d

        public List<EtiquetaEntity> Etiquetas;
        public List<RevisaoEntity> Revisoes;
    }
}