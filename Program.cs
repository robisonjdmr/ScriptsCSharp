using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControla;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Pontos- Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados- Fundamentos", LendoDados.Executar},
                {"Formatando Numeros- Fundamentos", FormantoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos- Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", Operadoresunirarios.Executar},
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar},

                //Estrutura de controles
                {"Estrutura de IF - EstruturaDeControles", EstruturaIf.Executar},
                {"Estrutura de IF/Else - EstruturaDeControles", EstruturaIfElse.Executar},
                {"Estrutura de IF/Else/if - EstruturaDeControles", EstruturaIfElseIf.Executar},
                {"Estrutura Swith - EstruturaDeControles", EstruturaSwith.Executar},
                {"Estrutura While - EstruturaDeControles", EstruturaWhile.Executar},
                {"Estrutura Do While - EstruturaDeControles", EstrturaDoWhile.Executar},
                {"Estrutura For - EstruturaDeControles", EstrturaFor.Executar},
                {"Estrutura ForEach - EstruturaDeControles", EstruturaForEach.Executar},
                {"Estrutura Usando Break - EstruturaDeControles", UsandoBreak.Executar},
                {"Estrutura Usando Continue - EstruturaDeControles", UsandoContinue.Executar},

                //Classe e Metodos
                {"Membros - Classe e Metodos", Membros.Executar},
                {"Construtores - Classe e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classe e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classe e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classe e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classe e Metodos", DesafioAtributos.Executar},
                {"Parametros - Classe e Metodos", Params.Executar},
                {"Parametros Nomeados - Classe e Metodos", ParametrosNomeados.Executar},
                {"Get e Set - Classe e Metodos", GetSet.Executar},
                {"Props - Classe e Metodos", Props.Executar},
                {"Readonly- Classe e Metodos", Readonly.Executar},
                {"Exemplo Enum - Classe e Metodos", ExemploEnum.Executar},
                {"Struct - Classe e Metodos", ExemploStruct.Executar},
                {"Struct VC Classe - Classe e Metodos", StructVsClasse.Executar},
                {"Valor VC Refereancia Classe e Metodos", ValorVSReferencia.Executar},
                {"Parametros por Referencia - Classe e Metodos", ParametrosPorReferencia.Executar},
                {"Parametros Padrão - Classe e Metodos", ParametrosPadrao.Executar},


                //Coleções  
                {"Array - Coleções", Colecoes.Array.Executar},
                {"Coleções List - Coleções", ColecoesList.Executar},
                {"Coleções Array List - Coleções", ColecoesArrayList.Executar},
                {"Coleções Set - Coleções", ColecoesSet.Executar},
                {"Coleções Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Coleções Stack - Coleções", ColecaoStack.Executar},
                {"Coleções Dictionary - Coleções", ColecoesDictionary.Executar},

                //Orientação a Objetos
                {"herança - OO", Heranca.Executar},
                {"Contrutor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},

                //Metodos & Funções
                {"Exemplo Lambda - Metodos & Funcoes", ExemploLambda.Executar},
                {"Lambda como Delegate - Metodos & Funcoes", LambdaDelegate.Executar},
                {"Usando Delegates - Metodos & Funcoes", UsandoDelegates.Executar},
                {"Delegate Função Anônima- Metodos & Funcoes", DelegateFuncAnonimas.Executar},
                {"Delegate com Parâmetros- Metodos & Funcoes", DelegatesComParametros.Executar},
                {"Metodos De Extensão- Metodos & Funcoes", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Exceção- Execeções", PrimeiraExcecao.Executar},

                //API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - API", LendoArquivos.Executar},
                {"Exemplo File Info - API", ExemploFileInfo.Executar},
                {"Diretórios - API", Diretorios.Executar},
                {"Exemplo DirectoruInfo - API", ExemplodirectoryInfo.Executar},
                {"Exemplo Path - API", ExemploPath.Executar},
                {"Exemplo Date Time - API", ExemploDateTime.Executar},
                {"Exemplo Time Span - API", ExemploTimeSpan.Executar},

                //Topicos Avançados
                {"LINQ1 - Topicos Avançados", LINQ1.Executar},
                {"LINQ2 - Topicos Avançados", LINQ2.Executar},
                {"Nullables - Topicos Avançados", Nullables.Executar},
                {"Dynamics - Topicos Avançados", Dynamics.Executar},
                {"Genericos - Topicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}