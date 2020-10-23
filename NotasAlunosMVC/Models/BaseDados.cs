using System.Collections.Generic;

namespace NotasAlunosMVC.Models
{
    public static class BaseDados
    {
        private static List<Aluno> alunos = new List<Aluno>();
        public static void Incluir(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public static List<Aluno> Listar()
        {
            return alunos;
        }

        
    }


}