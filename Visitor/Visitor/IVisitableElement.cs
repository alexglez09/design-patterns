namespace Visitor.Visitor
{
    public interface IVisitableElement
    {
        void Accept(IVisitor visitor);
    }
}
