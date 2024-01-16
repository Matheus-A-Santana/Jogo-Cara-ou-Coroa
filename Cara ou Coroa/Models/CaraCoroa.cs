namespace Cara_ou_Coroa.Models
{
    public class CaraCoroa
    {
        public string Moeda(string Jogada)
        {
            var rand = new Random();
            Dictionary<int, string> moeda = new Dictionary<int, string>();
            moeda.Add(0, "Cara");
            moeda.Add(1, "Coroa");
            int result = rand.Next(moeda.Count);
            if(moeda[result].Trim() == "Cara")
            {
                Console.WriteLine($"Você tem sorte Ganhou !!!\n");
                return "Cara";
            }
            if(moeda[result].Trim() == "C")
            {
                Console.WriteLine($"Você tem sorte Ganhou !!!\n");
                return "Coroa";
            }
            else
            {
                Console.WriteLine("Sinto Muito, Você Perdeu, Mais Sorte na próxima vez.");
                return "Loser";
            }
        }
    }
}