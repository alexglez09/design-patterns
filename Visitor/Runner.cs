using Visitor.Models;
using Visitor.Visitor;
using Visitor.Visitor.Visitors;

namespace Visitor
{
    public class Runner
    {
        public void Run(IAppLogger logger)
        {
            List<IVisitableElement> items = new List<IVisitableElement>
            {
                new Book { Id  = 1, Price = 2.99m },
                new Book { Id  = 2, Price = 4.99m },
                new Vinyl { Id  = 3, Price = 15.99m },
                new Book { Id  = 4, Price = 6.99m }
            };

            var cart = new ObjectStructure(items, logger);

            var discountVisitor = new DiscountVisitor();
            var salesVisitor = new SalesVisitor();

            cart.ApplyVisitor(discountVisitor);
            cart.ApplyVisitor(salesVisitor);

            cart.RemoveItem(items[0]);
            cart.ApplyVisitor(salesVisitor);
        }
    }
}
