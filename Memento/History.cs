using System.Collections.Generic;

namespace OOP
{
    public class History
    {
        private Stack<OrderMemento> _history = new Stack<OrderMemento>();

        public void Save(OrderMemento memento)
        {
            _history.Push(memento);
        }

        public OrderMemento Undo()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }
}
