namespace Empires.Charachters
{
   public interface IShedualUnitProducer : IUnitProducer
    {
        bool CanProduceUnit { get; }
    }
}
