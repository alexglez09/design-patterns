namespace Visitor.Visitor
{
    public class ObjectStructure
    {
        private readonly List<IVisitableElement> items;
        private readonly IAppLogger logger;

        public ObjectStructure(List<IVisitableElement> newItems, IAppLogger logger)
        {
            items = newItems;
            this.logger = logger;
        }

        public void ApplyVisitor(IVisitor visitor)
        {
            foreach (var item in items)
            {
                item.Accept(visitor);
            }

            var report = visitor.CreateReport();

            logger.Log(report);
        }

        public void RemoveItem(IVisitableElement item)
        {
            items.Remove(item);
        }
    }
}
