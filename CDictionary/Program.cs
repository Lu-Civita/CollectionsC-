using System;
using System.Collections.Generic;
using static CQueue.Program;

namespace CDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 4 - Dicionário");

            Dictionary<string, string> Mentalidade = new Dictionary<string, string>();

            Mentalidade.Add("Mentalidade de Crescimento","Ter uma mentalidade de crescimento é acreditar que suas " +
                "competências mais básicas podem ser desenvolvidas através de dedicação e trabalho árduo." +
                " O cérebro e o talento são apenas o ponto de partida.");
            Mentalidade.Add("Mentalidade de Persistência", "Ser persistente significa que você continuará " +
                "tentando vez após vez. Em cada tentativa, você estará mais próximo do sucesso.");
            Mentalidade.Add("Mentalidade de Responsabilidade pessoal", "Responsabilidade pessoal significa " +
                "assumir a responsabilidade por suas próprias ações, trabalhando arduamente, " +
                "mantendo seus compromissos e não dando desculpas.");
            Mentalidade.Add("Mentalidade de Orientação ao Futuro", "Ter orientação ao futuro significa " +
                "estabelecer metas para o seu futuro, compreender como as ações de hoje impactam " +
                "nessas metas e verificar seu progresso com frequência.");
            Mentalidade.Add("Habilidade de Comunicação", "Uma boa comunicação significa capacidade de expressar " +
                "ideias de forma clara e concisa, com linguagem apropriada ao público, assim como ouvir com atençãom, " +
                "manter contato visual com seus interlocutores e tomar notas ao receber novas informações.");
            Mentalidade.Add("Habilidade de Proatividade", "Proatividade significa assumir a liderança em seu emprego " +
                "sem nenhum impulso de seu gerente, antecipando situações e tomando as ações preventivas que forem necessárias.");
            Mentalidade.Add("Habilidade de Orientação ao detalhe", "Orientação ao detalhe consiste em estar " +
                "constantemente atento aos detalhes ao executar tarefas, a fim de serem completadas com precisão e cuidado.");
            Mentalidade.Add("Habilidade de Trabalho em equipe", "Trabalho em equipe Consiste em um trupo de pessoas, " +
                "ou apenas duas pessoas, trabalhando em conjunto visando um objetivo em comum.");

            foreach (KeyValuePair <String, string> kvp in Mentalidade)
            {
                Console.WriteLine($"Mentalidade/Habilidade = {kvp.Key} | Definição = {kvp.Value}");
            }
        }
    }
}
