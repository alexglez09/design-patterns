using Visitor.Visitor;

namespace Visitor.Models
{
    public class Book : Item, IVisitableElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBook(this);
        }
    }
}
