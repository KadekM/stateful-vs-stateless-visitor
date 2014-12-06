namespace FunctionalVisitor.Impl
{
    internal interface IVisitor<out T>
    {
        T Visit(Car car);
        T Visit(Wheel wheel);
        T Visit(Engine engine);
    }
}