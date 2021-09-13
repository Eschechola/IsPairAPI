namespace IsPairAPI.Services
{
    public class PairService : IPairService
    {
        public bool IsPair(decimal number)
            => (number % 2 == 0);
    }
}