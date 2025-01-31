using Visitor.Visitor;

namespace Visitor.Models
{
    public class Vinyl : Item, IVisitableElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitVinyl(this);
        }
    }
}
