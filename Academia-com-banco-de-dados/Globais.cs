using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_com_banco_de_dados
{
    class Globais
    {
        public static string versao = "1.0"; //ff
        public static Boolean logado = false;
        public static int nivel = 0; // 1 = Básico , 2 = Gerente , 3 = Master
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomaBanco="BD_Academia.db";
        public static string caminhoBanco = caminho+@"\banco\";
        public static string caminhoFoto = caminho+@"\fotos\";
     
    }
}
